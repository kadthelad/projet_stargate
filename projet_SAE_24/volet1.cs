using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_SAE_24
{
	public partial class FormTDB : Form
	{
		public FormTDB()
		{
			InitializeComponent();
		}
		DataSet dsGlobal = MesDatas.DsGlobal;
		String ordreTri = "ASC";

		private void FormTDB_Load(object sender, EventArgs e)
		{
			// Chargement de la base de donnée entière en local (pour le mode déconnecté)
			DataTable dtSchema = Connexion.Connec.GetSchema("Tables");
			for (int i = 0; i < dtSchema.Rows.Count; i++)
			{
				string nomTable = dtSchema.Rows[i]["TABLE_NAME"].ToString();
				string requete = "SELECT * FROM " + nomTable;
				SQLiteCommand commande = new SQLiteCommand(requete, Connexion.Connec);
				SQLiteDataAdapter donnees = new SQLiteDataAdapter();
				donnees.SelectCommand = commande;
				donnees.Fill(MesDatas.DsGlobal, nomTable);
			}

			// Remplir cboFiltres (tri)
			foreach (DataColumn colonne in dsGlobal.Tables["Mission"].Columns)
			{
				cboFiltre.Items.Add(colonne.ColumnName);
			}
			// Sélectionner nomPlanete comme tri par défaut
			cboFiltre.SelectedItem = "nomPlanete";
			Rafraichir_Missions();
		}

		private void Rafraichir_Missions()
		{
			flpTableauDeBord.Controls.Clear();
			// Ajouter les missions avec une boucle

			// Trier la table Mission
			if (cboFiltre.Text != "")
			{
				dsGlobal.Tables["Mission"].DefaultView.Sort = cboFiltre.Text + " " + ordreTri;
			}

			DataTable tableTriee = dsGlobal.Tables["Mission"].DefaultView.ToTable();
			foreach (DataRow ligne in tableTriee.Rows)
			{
				Mission missionUC = new Mission(ligne["nomPlanete"].ToString(), ligne["numero"].ToString());
				flpTableauDeBord.Controls.Add(missionUC);
			}

			if (!rdbToutes.Checked)
			{
				List<Mission> missionASupprimer = new List<Mission> { };
				foreach (Mission missionUC in flpTableauDeBord.Controls)
				{
					if (rdbEncours.Checked) // Que les missions en cours
					{
						if (missionUC.StatusMission != Mission.StatusMissionEnum.EN_COURS)
						{
							missionASupprimer.Add(missionUC);
						}
					}
					else if (rdbEnpreparation.Checked) // Que les missions en preparation
					{
						if (missionUC.StatusMission != Mission.StatusMissionEnum.EN_PREPARATION)
						{
							missionASupprimer.Add(missionUC);
						}
					}
					else // Que les missions terminées
					{
						if (missionUC.StatusMission != Mission.StatusMissionEnum.EST_TERMINEE)
						{
							missionASupprimer.Add(missionUC);
						}
					}
				}
				if (missionASupprimer.Count > 0)
				{
					foreach (Mission mission in missionASupprimer)
					{
						mission.Dispose();
					}
				}
			}
		}

		private void btnCreerMission_Click(object sender, EventArgs e)
		{
			FrmAdminAccess frmAdminAccess = new FrmAdminAccess();
			if (frmAdminAccess.ShowDialog() == DialogResult.OK)
			{
				// Lancer le volet d'ajout de mission
				MessageBox.Show("Authentification réussie!");
				FormADM frmAjoutDeMission = new FormADM();
				frmAjoutDeMission.ShowDialog();
				// Rafraichir les missions
				Rafraichir_Missions();
			}
		}

		private void btnOrdre_Click(object sender, EventArgs e)
		{
			if (ordreTri == "ASC")
			{
				// Aller en décroissant
				btnOrdre.Image = Properties.Resources.fleche_bas;
				ordreTri = "DESC";
			}
			else
			{
				// Aller en croissant
				btnOrdre.Image = Properties.Resources.fleche_haut;
				ordreTri = "ASC";
			}
			Rafraichir_Missions();
		}

		private void rdbToutes_Click(object sender, EventArgs e)
		{
			Rafraichir_Missions();
		}

		private void cboFiltre_SelectedIndexChanged(object sender, EventArgs e)
		{
			Rafraichir_Missions();
		}

		private void btnReinitialiser_Click(object sender, EventArgs e)
		{
			// Sélectionner nomPlanete comme tri par défaut
			cboFiltre.SelectedItem = "nomPlanete";
			btnOrdre.Image = Properties.Resources.fleche_haut;
			ordreTri = "ASC";
			rdbToutes.Checked = true;
			Rafraichir_Missions();
		}

		private void btnRegistreEspece_Click(object sender, EventArgs e)
		{

			volet4 frmRegistreEspeces = new volet4();
			frmRegistreEspeces.ShowDialog();
		}

		private void btnRegistrePlanetes_Click(object sender, EventArgs e)
		{

			volet5 frmRegistrePlanetes = new volet5();
			frmRegistrePlanetes.ShowDialog();
		}
	}
}
