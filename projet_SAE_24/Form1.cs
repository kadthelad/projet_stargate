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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//string requete = "SELECT * FROM Mission";
			//SQLiteCommand commande = new SQLiteCommand(requete, Connexion.Connec);
			//SQLiteDataAdapter donnee = new SQLiteDataAdapter();
			//donnee.SelectCommand = commande;
			//donnee.Fill(MesDatas.DsGlobal, "mission");

			// Chargement de la base de donnée en local (pour le mode déconnecté)
			// - Missions
			DataTable dtSchema = Connexion.Connec.GetSchema("Tables");
			for (int i = 1; i < dtSchema.Rows.Count; i++)
			{

				//récupération des tables
				string nomTable = dtSchema.Rows[i]["TABLE_NAME"].ToString();

				string req = "select * from " + nomTable;
				SQLiteCommand cd = new SQLiteCommand(req, Connexion.Connec);
				SQLiteDataAdapter da = new SQLiteDataAdapter(cd);
				da.Fill(MesDatas.DsGlobal, nomTable);

			}
		}


        private void btnMissions_Click(object sender, EventArgs e)
		{
			Volet3 tableauDeBord = new Volet3(1);
			tableauDeBord.ShowDialog();
		}

		private void btnDonnees_Click(object sender, EventArgs e)
		{

		}

		private void btnQuit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
