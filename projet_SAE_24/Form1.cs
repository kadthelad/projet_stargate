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
			// Chargement de la base de donnée en local (pour le mode déconnecté)
			// - Missions
			string requete = "SELECT * FROM Mission";
			SQLiteCommand commande = new SQLiteCommand(requete, Connexion.Connec);
			SQLiteDataAdapter donnee = new SQLiteDataAdapter();
			donnee.SelectCommand = commande;
			donnee.Fill(MesDatas.DsGlobal, "missions");
		}

		private void btnMissions_Click(object sender, EventArgs e)
		{
			FormTDB tableauDeBord = new FormTDB();
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
