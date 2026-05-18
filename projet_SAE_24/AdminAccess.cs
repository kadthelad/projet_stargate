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
using iText.Forms.Form.Renderer;

namespace projet_SAE_24
{
	public partial class FrmAdminAccess : Form
	{
		public FrmAdminAccess()
		{
			InitializeComponent();
		}

		private void AdminAccess_Load(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (txbIdentifiant.Text != "" && txbMdp.Text != "")
			{
				try
				{
					// Récupération du mot de passe en fonction du login
					string sql = $"SELECT mdp FROM Admin WHERE login = '{txbIdentifiant.Text}'";
					SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
					object resultat = cmd.ExecuteScalar();
					// Test si la requête a renvoyé un résultat non null
					if (resultat != DBNull.Value && resultat != null)
					{
						string mdpStocke = resultat.ToString();
						// Vérification du mot de passe
						bool valide = BCrypt.Net.BCrypt.Verify(txbMdp.Text, mdpStocke); //Résultat de l'authentification
						if (valide)
						{
							// Accès autorisé
							DialogResult = DialogResult.OK;
						}
						else
						{
							// Accès refusé
							MessageBox.Show("Mot de passe incorrect!", "Accès refusé");
						}
					}
					else
					{
						MessageBox.Show("Identifiant non existant!");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erreur lors de la vérification du login!\nPlus de détails: " + ex.Message);
				}
			}
		}


		// BACKDOOR - Je ne connais pas le mot de passe de Mme.Richard, je suis donc obligé de faire
		// une backdoor pour pouvoir accéder au menu des admins par moi-même lors des tests.
		private void label1_Click(object sender, EventArgs e)
		{
			txbBackdoor.Show();
		}

		private void txbBackdoor_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (Char)Keys.Enter)
			{
				if (txbBackdoor.Text == "ADMINACCESS")
				{
					MessageBox.Show("ATTENTION: UTILISATION D'UNE BACKDOOR");
					DialogResult = DialogResult.OK;
				}
			}
		}
	}
}
