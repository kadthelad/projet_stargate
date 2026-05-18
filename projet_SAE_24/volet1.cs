using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

		private void FormTDB_Load(object sender, EventArgs e)
		{
			Rafraichir_Missions();
		}

		private void Rafraichir_Missions()
		{
			// Ajouter les missions avec une boucle
			foreach (DataRow ligne in dsGlobal.Tables["Mission"].Rows)
			{
				DataRow[] dataRowsChef = dsGlobal.Tables["Membre"].Select("matricule = '" + ligne["matriculeChef"].ToString() + "'");

				if (dataRowsChef.Length > 0)
				{
					String nomChef = dataRowsChef[0]["nom"].ToString() + " " + dataRowsChef[0]["prenom"].ToString();

					Mission missionUC = new Mission(ligne["nomPlanete"].ToString(), ligne["numero"].ToString(),
						ligne["dateDepart"].ToString(), ligne["dateRetour"].ToString(),
						nomChef, ligne["budget"].ToString());
					flpTableauDeBord.Controls.Add(missionUC);
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
				if (frmAjoutDeMission.ShowDialog() == DialogResult.OK)
				{
					// Rafraichir les missions
				}
			}
		}
	}
}
