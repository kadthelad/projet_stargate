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

        string projectPath = Application.StartupPath;

        public void Creation_De_Panel(string nomRecherche = "", string couleurRecherche = "")
        {
            lay_espece.Controls.Clear();

            //Boucle pour afficher toutes les espèces du DataSet
            for (int i = 0; i < maDB.Tables["especes"].Rows.Count; i++)
            {
                string nom = maDB.Tables["especes"].Rows[i]["nom"].ToString();
                string couleur = maDB.Tables["especes"].Rows[i]["couleur"].ToString();

                Panel p = new Panel();
                PictureBox pb = new PictureBox();
                Label lblNom = new Label();
                Label lblCouleur = new Label();
                Label lblOrigine = new Label();

                if ((nomRecherche != "" && !nom.ToLower().Contains(nomRecherche.ToLower())) || (couleurRecherche != "" && !couleur.ToLower().Contains(couleurRecherche.ToLower())))
                {
                    continue;
                }

                string planete = "";

                p.Width = 250;
                p.Height = 110;

                pb.Width = 100;
                pb.Height = 100;
                pb.Left = 0;
                pb.Top = 0;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;

                switch (maDB.Tables["especes"].Rows[i]["couleur"].ToString())
                {
                    case "Violet":
                        pb.Image = Image.FromFile(projectPath + "\\img\\monstres\\Steve_Jobs.jpg");
                        break;
                    case "Orange":
                        pb.Image = Image.FromFile(projectPath + "\\img\\monstres\\Linus_Torvald.jpeg");
                        break;
                    case "Marron":
                        pb.Image = Image.FromFile(projectPath + "\\img\\monstres\\smiling_rafa.jpg");
                        break;
                    case "Gris":
                        pb.Image = Image.FromFile(projectPath + "\\img\\monstres\\Mark_Zuckerberg.jpg");
                        break;
                    case "Pourpre":
                        pb.Image = Image.FromFile(projectPath + "\\img\\monstres\\Bill_Gates.jpg");
                        break;
                    case "Rose":
                        pb.Image = Image.FromFile(projectPath + "\\img\\monstres\\Shigeru_Miyamoto.jpg");
                        break;
                    case "Vert":
                        pb.Image = Image.FromFile(projectPath + "\\img\\monstres\\Hideo_Kojima.jpg");
                        break;
                    case "Bleu":
                        pb.Image = Image.FromFile(projectPath + "\\img\\monstres\\Elon_Musk.jpg");
                        break;
                    default:
                        pb.Image = Image.FromFile(projectPath + "\\img\\monstres\\jason-rugby.jpg");
                        break;
                }

                lblNom.Text = "---> " + maDB.Tables["especes"].Rows[i]["nom"].ToString();
                lblNom.Font = new Font(lblNom.Font, FontStyle.Bold);
                lblNom.Left = 110;
                lblNom.Top = 20;
                lblNom.AutoSize = true;

                lblCouleur.Text = maDB.Tables["especes"].Rows[i]["couleur"].ToString();
                lblCouleur.Left = 110;
                lblCouleur.Top = 50;
                lblCouleur.AutoSize = true;

                for (int j = 0; j < maDB.Tables["habiter"].Rows.Count; j++)
                {
                    if (maDB.Tables["especes"].Rows[i]["id"].ToString() == maDB.Tables["habiter"].Rows[j]["idEspece"].ToString())
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
                lblOrigine.Top = 80;
                lblOrigine.AutoSize = true;

                p.Controls.Add(pb);
                p.Controls.Add(lblNom);
                p.Controls.Add(lblCouleur);
                p.Controls.Add(lblOrigine);

                lay_espece.Controls.Add(p);
            }
        }

        private void volet4_Load(object sender, EventArgs e)
        {
            lay_espece.Controls.Clear();

            maDB.Tables["especes"]?.Clear();
            maDB.Tables["habiter"]?.Clear();

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
            data2.SelectCommand = cmd2;
            data2.Fill(maDB, "habiter");

            query = "SELECT * FROM Allie";
            SQLiteCommand cmd3 = new SQLiteCommand(query, maConnec);
            SQLiteDataAdapter data3 = new SQLiteDataAdapter();
            data3.SelectCommand = cmd3;
            data3.Fill(maDB, "allies");

            query = "SELECT * FROM Ennemi";
            SQLiteCommand cmd4 = new SQLiteCommand(query, maConnec);
            SQLiteDataAdapter data4 = new SQLiteDataAdapter();
            data4.SelectCommand = cmd4;
            data4.Fill(maDB, "ennemis");

            Creation_De_Panel();
        }

        private void btn_filtre_Click(object sender, EventArgs e)
        {
            filtre fenetreFiltre = new filtre();

            if (fenetreFiltre.ShowDialog() == DialogResult.OK)
            {
                string couleurRecherche = fenetreFiltre.Couleur;
                string nomRecherche = fenetreFiltre.NomEspece;

                Creation_De_Panel(nomRecherche, couleurRecherche);
            }
        }
    }
}
