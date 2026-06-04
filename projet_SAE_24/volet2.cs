using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_SAE_24
{
	// FORMULAIRE EN MODE CONNECTE
	public partial class FormADM : Form
	{
		const int MAX_PARTICIPANTS = 20;
		const String TEXTE_RESET_DEFAUT = "Réinitialiser";
		const String TEXTE_RESET_CONFIRMATION = "Confirmer?";

		String missionNumero = "1";

		Dictionary<String, String> matricules = new Dictionary<String, String>(); // "nom prenom - role" : "M001"
		Dictionary<String, String> especes = new Dictionary<String, String>(); // "nomEspece - couleur" : "1" (id)
		Dictionary<String, int> objectifs_capture = new Dictionary<String, int>(); // "nomEspece - couleur" : 1 (nbCaptures)

		public FormADM()
		{
			InitializeComponent();
			dtpDateRetour.MinDate = dtpDateDepart.Value;
		}

		private bool estDisponible(String matricule)
		{
			// On cherche les personnes qui ont des matricules qui apparaissent durant une mission
			// dans une plage de temps donnée avec les DateTimePickers
			try
			{
				if (matricule == "")
				{
					return false;
				}
				String requete = "SELECT c.matriculeMembre " +
								 "FROM Composer c, Mission m " +
								 "WHERE c.nomPlanete = m.nomPlanete AND c.numeroMission = m.numero " +
								 "AND (" +
									$"('{dtpDateRetour.Value.ToString("yyyy-MM-dd")}' >= m.dateDepart AND '{dtpDateRetour.Value.ToString("yyyy-MM-dd")}' <= m.dateRetour) " +
									"OR " +
									$"('{dtpDateDepart.Value.ToString("yyyy-MM-dd")}' <= m.dateRetour AND '{dtpDateDepart.Value.ToString("yyyy-MM-dd")}' >= m.dateDepart) " +
									"OR " +
									$"('{dtpDateDepart.Value.ToString("yyyy-MM-dd")}' <= m.dateDepart AND '{dtpDateRetour.Value.ToString("yyyy-MM-dd")}' >= m.dateRetour) " +
								")";

				SQLiteCommand commande = new SQLiteCommand(requete, Connexion.Connec);
				commande.CommandType = CommandType.Text;
				SQLiteDataReader queryResponse = commande.ExecuteReader();
				while (queryResponse.Read())
				{
					if (queryResponse.GetString(0) == matricule)
					{
						return false;
					}
				}
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erreur lors de la verification de disponibilite!\nPlus d'informations: " + ex.Message);
			}
			return false;
		}

		private void verifDispnibiliteTous()
		{
			if (!matricules.ContainsKey(cboChefMission.Text))
			{
				return;
			}

			if (!estDisponible(matricules[cboChefMission.Text]))
			{
				MessageBox.Show($"{cboChefMission.Text} est déjà chef dans une autre mission durant cette plage de temps!");
				cboChefMission.SelectedIndex = -1;
				lsbxParticipants.Items.Clear();
			}

			try
			{
				foreach (String membre in lsbxParticipants.Items)
				{
					if (!estDisponible(matricules[membre]))
					{
						MessageBox.Show($"{membre} n'est pas présent durant cette plage de date, il/elle sera retiré.e de la liste des participants.");
						lsbxParticipants.Items.Remove(membre);
					}
				}
			}
			catch
			{

			}
		}
		private void reinitialiser_volet()
		{
			// Remettre toutes les valeuers par défaut
			btnReinitialiser.Text = TEXTE_RESET_DEFAUT;
			lblWarning.Visible = false;

			// tabInfos
			cboChoixPlanete.SelectedIndex = -1;
			lblNomMission.Text = "Nom de la mission: ";

			cboChefMission.SelectedIndex = -1;

			dtpDateDepart.Value = DateTime.Now;
			dtpDateRetour.Value = DateTime.Now;

			rtbFeuilleRoute.Text = "";

			nudQteTonnes.Value = nudQteTonnes.Minimum;
			nudBudget.Value = nudBudget.Minimum;

			// tabDetails
			cboAjoutMembre.Items.Clear();
			cboAjoutMembre.Enabled = false;
			lsbxParticipants.Items.Clear();

			cboObjectifCapture.Items.Clear();
			cboObjectifCapture.Enabled = false;
			nudNbCapture.Enabled = false;
			nudNbCapture.Value = nudNbCapture.Minimum;
			lsbxCaptures.Items.Clear();

			// Retourner au tab principal
			tabControl1.SelectedIndex = 0;
		}

		// Permet d'échapper les apostrophes pour les requetes SQL
		private String echApostrophe(String texte)
		{
			String returnTexte = "";
			foreach (char ch in texte)
			{
				if (ch == '\'')
				{
					returnTexte += ch + "'";
				}
				else
				{
					returnTexte += ch;
				}
			}

			return returnTexte;
		}

		private void FormADM_Load(object sender, EventArgs e)
		{
			// Remplissage des ComboBox en mode connecté
			try
			{
				// cboPlanetes
				SQLiteCommand cd1 = new SQLiteCommand("SELECT nom FROM Planete", Connexion.Connec);
				cd1.CommandType = CommandType.Text;
				SQLiteDataReader queryResponse = cd1.ExecuteReader();
				while (queryResponse.Read())
				{
					cboChoixPlanete.Items.Add(queryResponse.GetValue(0).ToString());
				}

				// cboChefMission
				// Je pars du principe que seulement les militaires peuvent être chef de mission DISPONIBLES
				SQLiteCommand cd2 = new SQLiteCommand("SELECT m.nom || ' ' || m.prenom || ' - ' || mi.grade || ' (Militaire)' as 'Chef', m.matricule " +
														"FROM Membre m, Militaire mi " +
														"WHERE m.matricule = mi.matriculeMembre ",
														Connexion.Connec);
				cd2.CommandType = CommandType.Text;
				queryResponse = cd2.ExecuteReader();
				while (queryResponse.Read())
				{
					cboChefMission.Items.Add(queryResponse.GetValue(0).ToString());
					cboAjoutMembre.Items.Add(queryResponse.GetValue(0).ToString());
					matricules[queryResponse.GetValue(0).ToString()] = queryResponse.GetValue(1).ToString();
				}

				// cboAjoutMembre
				// Ajouter les civils
				SQLiteCommand cd3 = new SQLiteCommand("SELECT m.nom || ' ' || m.prenom || ' - ' || c.Specialite || ' (Civil)' as 'Civil', m.matricule " +
														"FROM Membre m, Civil c " +
														"WHERE m.matricule = c.matriculeMembre",
														Connexion.Connec);
				cd3.CommandType = CommandType.Text;
				queryResponse = cd3.ExecuteReader();
				while (queryResponse.Read())
				{
					cboAjoutMembre.Items.Add(queryResponse.GetValue(0).ToString());
					matricules[queryResponse.GetValue(0).ToString()] = queryResponse.GetValue(1).ToString();
				}
			}
			catch (Exception err)
			{
				MessageBox.Show("Erreur lors du chargement des ComboBox!\nPlus de détails: " + err.Message);
				DialogResult = DialogResult.Cancel; // Quitter la fenêtre en cas de problème
			}
		}


		private void btnReinitialiser_Click(object sender, EventArgs e)
		{
			// Demander confirmation avant de reinitialiser
			if (btnReinitialiser.Text == TEXTE_RESET_DEFAUT)
			{
				btnReinitialiser.Text = TEXTE_RESET_CONFIRMATION;
				lblWarning.Visible = true;
			}
			else
			{
				reinitialiser_volet();
			}
		}

		private void btnReinitialiser_MouseLeave(object sender, EventArgs e)
		{
			// Reinitialisation non confirmée
			btnReinitialiser.Text = TEXTE_RESET_DEFAUT;
			lblWarning.Visible = false;
		}

		private void btnCreerMission_Click(object sender, EventArgs e)
		{
			// Vérifications
			if (btnCreerMission.Text == "Suivant")
			{
				tabControl1.SelectedIndex = 1;
				btnCreerMission.Text = "Créer Mission";
				return;
			}

			if (cboChefMission.Text == "" || cboChoixPlanete.Text == "")
			{
				MessageBox.Show("Vous ne pouvez pas créer de mission sans planète et sans chef!");
				return;
			}

			// Créer la mission dans la base de donnée
			try
			{
				// Mission
				if (rtbFeuilleRoute.Text == "")
				{
					rtbFeuilleRoute.Text = "Feuille de route vide.";
				}
				String nomPlanete = echApostrophe(cboChoixPlanete.Text);

				// Construction de la requete SQL
				String requete = "INSERT INTO Mission (nomPlanete, numero, nbMembreRequis, dateDepart, dateRetour, " +
														"matriculeChef, feuilleDeRoute, objectifDatabaz, budget) " +
									$"VALUES ('{nomPlanete}', {missionNumero}, {lsbxParticipants.Items.Count}, '{dtpDateDepart.Value.ToString("yyyy-MM-dd")}', " +
									$"'{dtpDateRetour.Value.ToString("yyyy-MM-dd")}', '{matricules[cboChefMission.Text]}', '{echApostrophe(rtbFeuilleRoute.Text)}', " +
									$"{nudQteTonnes.Value}, {nudBudget.Value}); ";

				// Composer
				for (int i=0; i < lsbxParticipants.Items.Count; i++)
				{
					requete += "INSERT INTO Composer (nomPlanete, numeroMission, matriculeMembre) " +
								$"VALUES ('{nomPlanete}', {missionNumero}, '{matricules[lsbxParticipants.Items[i].ToString()]}'); ";

				}

				// ObjectifCapture
				foreach (String especeEnnemi in objectifs_capture.Keys)
				{
					requete += "INSERT INTO ObjectifCapture (nomPlanete, numeroMission, idEspeceEnnemi, objectif) " +
								$"VALUES ('{nomPlanete}', {missionNumero}, " +
								$"'{especes[especeEnnemi]}', {objectifs_capture[especeEnnemi]}); ";
				}

				// Commit les changements
				SQLiteCommand cd1 = new SQLiteCommand(requete, Connexion.Connec);
				cd1.ExecuteNonQuery();

				// La mission sera dans la base de donnée, mais pas dans mesDatas, alors on l'ajoute
				// Table Mission
				string requete2 = $"SELECT * FROM Mission WHERE nomPlanete = '{nomPlanete}' AND numero = {missionNumero}";
				SQLiteCommand commande = new SQLiteCommand(requete2, Connexion.Connec);
				SQLiteDataAdapter donnees = new SQLiteDataAdapter();
				donnees.SelectCommand = commande;
				donnees.Fill(MesDatas.DsGlobal, "Mission");
				// Table Composer
				string requete3 = $"SELECT * FROM Composer WHERE nomPlanete = '{nomPlanete}' AND numeroMission = {missionNumero}";
				commande = new SQLiteCommand(requete3, Connexion.Connec);
				donnees = new SQLiteDataAdapter();
				donnees.SelectCommand = commande;
				donnees.Fill(MesDatas.DsGlobal, "Composer");
				// Table ObjectifCapture
				string requete4 = $"SELECT * FROM ObjectifCapture WHERE nomPlanete = '{nomPlanete}' AND numeroMission = {missionNumero}";
				commande = new SQLiteCommand(requete4, Connexion.Connec);
				donnees = new SQLiteDataAdapter();
				donnees.SelectCommand = commande;
				donnees.Fill(MesDatas.DsGlobal, "ObjectifCapture");

				// Tout s'est bien passé si il n'y a pas d'exception levée
				MessageBox.Show("Mission ajoutée avec succès!");

				// Reinitialiser le volet après la création de la mission
				reinitialiser_volet();
			}
			catch (Exception err)
			{
				MessageBox.Show("Erreur lors de la création de la mission!\nPlus de détails: " + err.Message);
			}
		}


		private void cboChoixPlanete_SelectionChangeCommitted(object sender, EventArgs e)
		{
			// Créer un nom pour la mission
			try
			{
				SQLiteCommand cd1 = new SQLiteCommand("SELECT COUNT(numero) FROM Mission WHERE LOWER(nomPlanete)='" + cboChoixPlanete.Text.ToLower() + "'", Connexion.Connec);
				cd1.CommandType = CommandType.Text;
				int numMission = Convert.ToInt32(cd1.ExecuteScalar().ToString()) + 1;
				lblNomMission.Text = "Nom de la mission: " + cboChoixPlanete.Text + " " + numMission;
				missionNumero = numMission.ToString();
				// Clear la liste d'objectifs aussi
				lsbxCaptures.Items.Clear();
			}
			catch (Exception err)
			{
				MessageBox.Show("Erreur lors de la création du nom de la mission!\nPlus de détails: " + err.Message);
			}
		}

		private void dtpDateDepart_ValueChanged(object sender, EventArgs e)
		{
			// Faire en sorte que date retour ne puisse pas être avant date depart
			dtpDateRetour.MinDate = dtpDateDepart.Value;

			// Vérifier que le chef choisi (et membres de la mission) est présent avant/après cette date
			verifDispnibiliteTous();
		}
		private void dtpDateRetour_ValueChanged(object sender, EventArgs e)
		{
			verifDispnibiliteTous();
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Si un chef n'est pas choisi, on prévient l'utilisateur qu'il ne pourra pas ajouter/retirer de membres pour la mission
			if (tabControl1.SelectedIndex == 1) // tabDetails
			{
				btnCreerMission.Text = "Créer Mission";
				btnRetour.Text = "Retour";
				btnRetour.ForeColor = Color.Black;
				if (!cboAjoutMembre.Enabled)
				{
					MessageBox.Show("Vous n'avez pas asigné de chef pour la mission, vous ne pourrez pas ajouter/retirer de membres pour celle-ci!", "Attention!");
				}
				if (!cboObjectifCapture.Enabled)
				{
					MessageBox.Show("Vous n'avez pas asigné de planete pour la mission, vous ne pourrez pas ajouter d'objectif de capture pour celle-ci!", "Attention!");
				}
			}
			else
			{
				btnCreerMission.Text = "Suivant";
			}
		}
		
		private void cboChefMission_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Si un chef de mission est sélectionné, autoriser l'utilisateur à ajouter/retirer des membrres pour la mission
			if (cboChefMission.SelectedIndex != -1) // Chef sélectionné
			{
				lsbxParticipants.Items.Clear(); // Rafraichir la liste des participants

				if (!estDisponible(matricules[cboChefMission.Text]))
				{
					MessageBox.Show($"{cboChefMission.Text} est déjà dans une mission durant cette plage de temps!");
					cboChefMission.SelectedIndex = -1;
					return;
				}

				cboAjoutMembre.Enabled = true;

				lsbxParticipants.Items.Clear();
				lsbxParticipants.Items.Add(cboChefMission.Text);
				cboAjoutMembre.Items.Remove(cboChefMission.Text);
			}
			else // Pas de chef sélectionné
			{
				cboAjoutMembre.Enabled = false;
			}

		}

		private void cboChoixPlanete_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Si une planete est sélectionnée, autoriser l'ajout de capture d'especes en objectif
			if (cboChoixPlanete.SelectedIndex != -1) // Planete sélectionnée
			{
				cboObjectifCapture.Enabled = true;

				lsbxCaptures.Items.Clear();

				// charger cboObjectifCapture
				cboObjectifCapture.Items.Clear();
				objectifs_capture.Clear();
				nudNbCapture.Value = nudNbCapture.Minimum;
				nudNbCapture.Enabled = false;


				String requete_tout_ennemi = "SELECT es.nom || ' - ' || es.couleur as 'Monstre Ennemi', es.id " +
									"FROM Espece es, Ennemi en " +
									"WHERE es.id = en.idEspece";
				String requete_planete_ennemis = "SELECT es.nom || ' - ' || es.couleur as 'Monstre Ennemi', es.id " +
																"FROM Espece es, Ennemi en, Habiter h " +
																"WHERE es.id = en.idEspece AND es.id = h.idEspece AND h.nomPlanete = '" + cboChoixPlanete.Text + "'";
				String requete = requete_planete_ennemis;
				if (ckbAfficherTousEnnemis.Checked)
				{
					requete = requete_tout_ennemi;
				}

				SQLiteCommand cd1 = new SQLiteCommand(requete, Connexion.Connec);
				cd1.CommandType = CommandType.Text;
				SQLiteDataReader queryResponse = cd1.ExecuteReader();
				while (queryResponse.Read())
				{
					cboObjectifCapture.Items.Add(queryResponse.GetValue(0).ToString());
					especes[queryResponse.GetValue(0).ToString()] = queryResponse.GetValue(1).ToString();
				}
			}
			else // Pas de planete sélectionnée
			{
				cboObjectifCapture.Enabled = false;
			}
		}

		private void cboAjoutMembre_SelectionChangeCommitted(object sender, EventArgs e)
		{
			// Ajouter un membre dans la liste des membres de la misison
			if (lsbxParticipants.Items.Count >= MAX_PARTICIPANTS)
			{
				MessageBox.Show("Vous ne pouvez pas ajouter plus de membres pour la mission!");
			}
			else if (!estDisponible(matricules[cboAjoutMembre.Text]))
			{
				MessageBox.Show("Cette personne est déjà dans une mission durant cette plage de temps!");
			}
			else
			{
				lsbxParticipants.Items.Add(cboAjoutMembre.Text);
				cboAjoutMembre.Items.Remove(cboAjoutMembre.Text);
			}
		}

		private void lsbxParticipants_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Retirer un membre de la mission
			if (lsbxParticipants.SelectedIndex != -1)
			{
				if (lsbxParticipants.SelectedItem.ToString() != cboChefMission.Text)
				{
					cboAjoutMembre.Items.Add(lsbxParticipants.SelectedItem);
					lsbxParticipants.Items.Remove(lsbxParticipants.SelectedItem);
				}
			}
		}

		private void ckbAfficherTousEnnemis_CheckedChanged(object sender, EventArgs e)
		{
			cboChoixPlanete_SelectedIndexChanged(sender, e);
		}

		private void lsbxCaptures_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Retirer un objectif de la mission
			if (lsbxCaptures.SelectedIndex != -1)
			{
				objectifs_capture.Remove(objectifs_capture.Keys.ToList()[lsbxCaptures.SelectedIndex]);
				lsbxCaptures.Items.RemoveAt(lsbxCaptures.SelectedIndex);
			}
		}

		private void cboObjectifCapture_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboObjectifCapture.SelectedIndex != -1)
			{
				nudNbCapture.Enabled = true;
			}
			else
			{
				nudNbCapture.Enabled = false;
				nudNbCapture.Value = nudNbCapture.Minimum;
			}
		}

		private void nudNbCapture_ValueChanged(object sender, EventArgs e)
		{
			if (nudNbCapture.Value != nudNbCapture.Minimum && nudNbCapture.Enabled)
			{
				btnAjoutObjectif.Enabled = true;
			}
			else
			{
				btnAjoutObjectif.Enabled = false;
			}
		}
		private void btnAjoutObjectif_Click(object sender, EventArgs e)
		{
			// Ajouter objectif
			if (!objectifs_capture.ContainsKey(cboObjectifCapture.Text)) // Si la clé n'existe pas...
			{
				objectifs_capture[cboObjectifCapture.Text] = Convert.ToInt32(nudNbCapture.Value);
			}
			else
			{
				objectifs_capture[cboObjectifCapture.Text] += Convert.ToInt32(nudNbCapture.Value);
			}

			// Actualiser la liste des objectifs
			lsbxCaptures.Items.Clear();
			foreach (String especeEnnemi in objectifs_capture.Keys)
			{
				lsbxCaptures.Items.Add(especeEnnemi + " ---> " + objectifs_capture[especeEnnemi].ToString());
			}
		}

		private void btnRetour_Click(object sender, EventArgs e)
		{
			if (btnRetour.Text == "Retour")
			{
				tabControl1.SelectedIndex = 0;
				btnRetour.Text = "Retour au Tableau de Bord";
				btnRetour.ForeColor = Color.Red;
			}
			else
			{
				DialogResult = DialogResult.Abort;
			}
		}
	}
}
