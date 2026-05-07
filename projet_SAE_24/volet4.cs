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
    public partial class volet4 : Form
    {
        public volet4()
        {
            InitializeComponent();
        }

        SQLiteConnection maConnec = Connexion.Connec;
        DataSet maDB = MesDatas.DsGlobal;

        private void volet4_Load(object sender, EventArgs e)
        {
            // Mode déconnecté
            string query = "SELECT * FROM Espece";
            SQLiteCommand cmd = new SQLiteCommand(query, maConnec);
            SQLiteDataAdapter data = new SQLiteDataAdapter();
            data.SelectCommand = cmd;
            data.Fill(maDB, "especes");

            // Mode déconnecté
            query = "SELECT * FROM Habiter";
            SQLiteCommand cmd2 = new SQLiteCommand(query, maConnec);
            SQLiteDataAdapter data2 = new SQLiteDataAdapter();
            data.SelectCommand = cmd2;
            data.Fill(maDB, "habiter");
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            //Boucle pour afficher toutes les espèces du DataSet
            for (int i = 0; i < maDB.Tables["especes"].Rows.Count; i++)
            {
                Panel p = new Panel();
                PictureBox pb = new PictureBox();
                Label lblNom = new Label();
                Label lblCouleur = new Label();
                Label lblOrigine = new Label();

                string planete = "";

                p.Width = 250;
                p.Height = 110;

                pb.Width = 100;
                pb.Height = 100;
                pb.Left = 0;
                pb.Top = 0;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;

                if (maDB.Tables["especes"].Rows[i]["couleur"].ToString() == "Violet")
                {
                    pb.Image = Image.FromFile("U:\\SAE\\projet_SAE_24\\bin\\Debug\\img\\monstres\\Steve_Jobs.jpg");
                }
                else
                {
                    pb.Image = Image.FromFile("U:\\SAE\\projet_SAE_24\\bin\\Debug\\img\\monstres\\Linus_Torvald.jpeg");
                }

                lblNom.Text =  "---> " + maDB.Tables["especes"].Rows[i]["nom"].ToString();
                lblNom.Font = new Font(lblNom.Font, FontStyle.Bold);
                lblNom.Left = 110;
                lblNom.Top = 20;
                lblNom.AutoSize = true;

                lblCouleur.Text = maDB.Tables["especes"].Rows[i]["couleur"].ToString();
                lblCouleur.Left = 110;
                lblCouleur.Top = 50;
                lblCouleur.AutoSize = true;

                for(int j = 0; j < maDB.Tables["habiter"].Rows.Count; j++)
                {
                    if(maDB.Tables["especes"].Rows[i]["id"].ToString() == maDB.Tables["habiter"].Rows[j]["idEspece"].ToString())
                    {
                        planete += maDB.Tables["habiter"].Rows[j]["nomPlanete"].ToString() + "/";
                    }
                }

                if (planete == string.Empty)
                {
                    planete = "Origine inconnue";
                }

                if (planete == "Origine inconnue")
                {
                    lblOrigine.Text = planete;
                    lblOrigine.ForeColor = Color.Red;
                }
                else
                {
                    lblOrigine.Text = planete.Substring(0, planete.Length - 1);
                }

                lblOrigine.Left = 110;
                lblOrigine.Top = 70;
                lblOrigine.AutoSize = true;

                p.Controls.Add(pb);
                p.Controls.Add(lblNom);
                p.Controls.Add(lblCouleur);
                p.Controls.Add(lblOrigine);

                lay_espece.Controls.Add(p);
            }
        }
    }
}
