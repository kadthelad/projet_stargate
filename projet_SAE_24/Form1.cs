using System;
using static projet_SAE_24.Connexion;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using appliPandora;

namespace projet_SAE_24
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        SQLiteConnection maConnec = Connexion.Connec;
        DataSet maDB = MesDatas.DsGlobal;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Mode déconnecté
            string query = "SELECT * FROM Espece";
            SQLiteCommand cmd = new SQLiteCommand(query, maConnec);
            SQLiteDataAdapter data = new SQLiteDataAdapter();
            data.SelectCommand = cmd;
            data.Fill(maDB, "especes");
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            // Variables pour définir le haut et la gauche
            int haut = 30;
            int gauche = 30;

            //Boucle pour afficher toutes les espèces du DataSet
            for(int i = 0; i < maDB.Tables["especes"].Rows.Count; i++)
            {
                PictureBox pb = new PictureBox();
                Label lb = new Label();

                // Selon la couleur, on affiche une image différente
                if(maDB.Tables["especes"].Rows[i]["couleur"].ToString() == "Violet")
                {
                    pb.Image = Image.FromFile("U:\\SAE\\projet_SAE_24\\bin\\Debug\\Steve_Jobs.jpg");
                }
                else
                {
                    pb.Image = Image.FromFile("U:\\SAE\\projet_SAE_24\\bin\\Debug\\Linus_Torvald.jpeg");
                }
                
                // Paramètres pour bien placer l'image et le texte
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                lb.Text = maDB.Tables["especes"].Rows[i]["couleur"].ToString();
                pb.Top = haut;
                lb.Top = haut + 10;
                pb.Left = gauche;
                lb.Left = gauche;
                haut += 30;
                gauche += 30;

                // Ajout du label et de l'image dans le Layout
                ctrLayout.Controls.Add(pb);
                ctrLayout.Controls.Add(lb);
            }
        }
    }
}
