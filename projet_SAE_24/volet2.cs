using System;
using System.Collections.Generic;
using System.ComponentModel;
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
		const String TEXTE_RESET_DEFAUT = "Réinitialiser";
		const String TEXTE_RESET_CONFIRMATION = "Confirmer?";

		List<string> membres_mission = new List<string>();
		List<string> objectifs_mission = new List<string>();

		public FormADM()
		{
			InitializeComponent();
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
				// Je pars du principe que seulement les militaires peuvent être chef de mission
				SQLiteCommand cd2 = new SQLiteCommand("SELECT m.nom || ' ' || m.prenom || ' - ' || mi.grade as 'Chef' " +
														"FROM Membre m, Militaire mi " +
														"WHERE m.matricule = mi.matriculeMembre", 
														Connexion.Connec);
				cd2.CommandType = CommandType.Text;
				queryResponse = cd2.ExecuteReader();
				while (queryResponse.Read())
				{
					cboChefMission.Items.Add(queryResponse.GetValue(0).ToString());
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
				nudNbPersonnes.Value = 0;
				nudQteTonnes.Value = 0;
				nudBudget.Value = 0;

				// tabDetails
				cboAjoutMembre.Enabled = false;
				cboRetirerMembre.Enabled = false;
				rtbParticipants.Text = "";
				cboObjectifCapture.Enabled = false;
				rtbObjectifCapture.Text = "";
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

		}

		private void cboChoixPlanete_SelectionChangeCommitted(object sender, EventArgs e)
		{
			// Créer un nom pour la mission
			try
			{
				SQLiteCommand cd1 = new SQLiteCommand("SELECT COUNT(numero) FROM Mission WHERE LOWER(nomPlanete)='" + cboChoixPlanete.Text.ToLower() + "'", Connexion.Connec);
				cd1.CommandType = CommandType.Text;
				// Dans le cas où la requete renvoie null
				string numMission = cd1.ExecuteScalar().ToString();
				lblNomMission.Text = "Nom de la mission: " + cboChoixPlanete.Text + " " + numMission;
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
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Si un chef n'est pas choisi, on prévient l'utilisateur qu'il ne pourra pas ajouter/retirer de membres pour la mission
			if (tabControl1.SelectedIndex == 1) // tabDetails
			{
				if (!cboAjoutMembre.Enabled || !cboRetirerMembre.Enabled)
				{
					MessageBox.Show("Vous n'avez pas asigné de chef pour la mission, vous ne pourrez pas ajouter/retirer de membres pour celle-ci!", "Attention!");
				}
				if (!cboObjectifCapture.Enabled)
				{
					MessageBox.Show("Vous n'avez pas asigné de planete pour la mission, vous ne pourrez pas ajouter d'objectif de capture pour celle-ci!", "Attention!");
				}
			}
		}

		private void cboChefMission_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Si un chef de mission est sélectionné, autoriser l'utilisateur à ajouter/retirer des membrres pour la mission
			if (cboChefMission.SelectedIndex != -1) // Chef sélectionné
			{
				cboAjoutMembre.Enabled = true;
				cboRetirerMembre.Enabled = true;

				rtbParticipants.Text = cboChefMission.Text + " [CHEF]";

				// Charger cboAjoutMembre
				cboAjoutMembre.Items.Clear();

				// Ajouter les civils
				SQLiteCommand cd1 = new SQLiteCommand("SELECT m.nom || ' ' || m.prenom || ' - ' || c.Specialite || ' (Civil)' as 'Civil' " +
														"FROM Membre m, Civil c " +
														"WHERE m.matricule = c.matriculeMembre",
														Connexion.Connec);
				cd1.CommandType = CommandType.Text;
				SQLiteDataReader queryResponse = cd1.ExecuteReader();
				while (queryResponse.Read())
				{
					cboAjoutMembre.Items.Add(queryResponse.GetValue(0).ToString());
				}

				// Ajouter les militaires
				// Vu qu'on a déjà cboChefMission qui contient tous les militaires, suffit de copier les items et de retirer le chef
				foreach (String militaire in cboChefMission.Items)
				{
					if (militaire != cboChefMission.Text)
					{
						cboAjoutMembre.Items.Add(militaire + " (Militaire)");
					}
				}
			}
			else // Rien sélectionné
			{
				cboAjoutMembre.Enabled = false;
				cboRetirerMembre.Enabled = false;
			}

		}

		private void cboChoixPlanete_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Si une planete est sélectionnée, autoriser l'ajout de capture d'especes en objectif
			if (cboChoixPlanete.SelectedIndex != -1) // Planete sélectionnée
			{
				cboObjectifCapture.Enabled = true;

				rtbObjectifCapture.Text = "";

				// charger cboObjectifCapture
				cboObjectifCapture.Items.Clear();

				SQLiteCommand cd1 = new SQLiteCommand("SELECT es.nom || ' - ' || es.couleur as 'Monstre Ennemi' " +
														"FROM Espece es, Ennemi en, Habiter h " +
														"WHERE es.id = en.idEspece AND es.id = h.idEspece AND h.nomPlanete = '" + cboChoixPlanete.Text + "'",
														Connexion.Connec);
				cd1.CommandType = CommandType.Text;
				SQLiteDataReader queryResponse = cd1.ExecuteReader();
				while (queryResponse.Read())
				{
					cboObjectifCapture.Items.Add(queryResponse.GetValue(0).ToString());
				}
			}
			else // Rien sélectionné
			{
				cboObjectifCapture.Enabled = false;
			}
		}

		private void btnRetirerCapture_Click(object sender, EventArgs e)
		{

		}

		private void btnAjoutObjectif_Click(object sender, EventArgs e)
		{

		}

		private void cboAjoutMembre_SelectionChangeCommitted(object sender, EventArgs e)
		{

		}

		private void cboRetirerMembre_SelectionChangeCommitted(object sender, EventArgs e)
		{

		}
	}
}
