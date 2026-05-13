using System;
using static projet_SAE_24.Connexion;
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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
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
        }

		private void btnMissions_Click(object sender, EventArgs e)
		{
			FormTDB tableauDeBord = new FormTDB();
			tableauDeBord.ShowDialog();
		}

		private void btnDonnees_Click(object sender, EventArgs e)
		{
			volet4 volet4 = new volet4();
			volet4.ShowDialog();
		}

		private void btnQuit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
