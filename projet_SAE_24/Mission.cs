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
	public partial class Mission : UserControl
	{
		public Mission(String nomPlanete, String titreMission,
			String dateDepart, String dateFinEstimee, String nomChef, String budget)
		{
			InitializeComponent();
			lblTitre.Text = titreMission;
			lblDateDepart.Text = dateDepart;
			lblDateFinEstimee.Text = dateFinEstimee;
			lblNomChef.Text = nomChef;
			lblBudget.Text = "Budget : " + budget + "$G";

			try
			{
				string projectPath = Application.StartupPath; // trouve où est le /bin/Debug
				Image img = Image.FromFile(projectPath + "/img/planetes/" + nomPlanete + ".png");
				pictureBox1.Image = img;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erreur lors de la recherche de l'image de la planète! Plus d'informations:\n" + ex.Message);
			}
		}

		public Mission()
		{
			InitializeComponent();
		}

		private void Mission_Load(object sender, EventArgs e)
		{

		}
	}
}
