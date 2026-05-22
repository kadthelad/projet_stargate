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

        public void Creation_De_Panel(string nomRecherche = "", string couleurRecherche = "", bool allieRecherche = false, bool ennemiRecherche = false)
        {
            layEspece.Controls.Clear();

            //Boucle pour afficher toutes les espèces du DataSet
            for (int i = 0; i < maDB.Tables["Espece"].Rows.Count; i++)
            {
                string nom = maDB.Tables["Espece"].Rows[i]["nom"].ToString();
                string couleur = maDB.Tables["Espece"].Rows[i]["couleur"].ToString();
                int idEspece = Convert.ToInt32(maDB.Tables["Espece"].Rows[i]["id"]);

                bool estAllie = false;
                bool estEnnemi = false;

                string bienveillance = "";
                string instrument = "";

                string agressivite = "";
                string arme = "";

                Panel p = new Panel();
                PictureBox pb = new PictureBox();
                Label lblNom = new Label();
                Label lblCouleur = new Label();
                Label lblOrigine = new Label();
                Label lblBienveillance = new Label();
                Label lblInstrumentMusique = new Label();
                Label lblAgressivite = new Label();
                Label lblTypeArme = new Label();

                for (int j = 0; j < maDB.Tables["Allie"].Rows.Count; j++)
                {
                    if (Convert.ToInt32(maDB.Tables["Allie"].Rows[j]["idEspece"]) == idEspece)
                    {
                        estAllie = true;

                        bienveillance = maDB.Tables["Allie"].Rows[j]["degreBienveillance"].ToString();
                        instrument = maDB.Tables["Allie"].Rows[j]["instrumentMusique"].ToString();

                        break;
                    }
                }

                if (estAllie)
                {
                    lblBienveillance.Text = "Bienveillance : " + bienveillance;
                    lblInstrumentMusique.Text = instrument;
                    lblInstrumentMusique.ForeColor = Color.Green;

                    lblBienveillance.Left = 110;
                    lblBienveillance.Top = 50;
                    lblBienveillance.AutoSize = true;

                    lblInstrumentMusique.Left = 110;
                    lblInstrumentMusique.Top = 80;
                    lblInstrumentMusique.AutoSize = true;

                    p.Controls.Add(lblBienveillance);
                    p.Controls.Add(lblInstrumentMusique);
                }

                for (int j = 0; j < maDB.Tables["Ennemi"].Rows.Count; j++)
                {
                    if (Convert.ToInt32(maDB.Tables["Ennemi"].Rows[j]["idEspece"]) == idEspece)
                    {
                        estEnnemi = true;

                        agressivite = maDB.Tables["Ennemi"].Rows[j]["degreAgressivite"].ToString();
                        arme = maDB.Tables["Ennemi"].Rows[j]["typeArme"].ToString();

                        break;
                    }
                }

                if (estEnnemi)
                {
                    lblAgressivite.Text = "Agressivité : " + agressivite;
                    lblTypeArme.Text = arme;
                    lblTypeArme.ForeColor = Color.Green;

                    lblAgressivite.Left = 110;
                    lblAgressivite.Top = 50;
                    lblAgressivite.AutoSize = true;

                    lblTypeArme.Left = 110;
                    lblTypeArme.Top = 80;
                    lblTypeArme.AutoSize = true;

                    p.Controls.Add(lblAgressivite);
                    p.Controls.Add(lblTypeArme);
                }

                if ((nomRecherche != "" && !nom.ToLower().Contains(nomRecherche.ToLower())) || (couleurRecherche != "" && !couleur.ToLower().Contains(couleurRecherche.ToLower())))
                {
                    continue;
                }

                bool aucunFiltre = !allieRecherche && !ennemiRecherche;

                bool afficher =
                    aucunFiltre ||
                    (allieRecherche && estAllie) ||
                    (ennemiRecherche && estEnnemi);

                if (!afficher)
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

                string couleurEspece = maDB.Tables["Espece"].Rows[i]["couleur"].ToString();

                pb.Image = Image.FromFile(projectPath + "/img/monstres/" + couleurEspece + ".jpg");

                lblNom.Text = "---> " + maDB.Tables["Espece"].Rows[i]["nom"].ToString();
                lblNom.Font = new Font(lblNom.Font, FontStyle.Bold);
                lblNom.Left = 110;
                lblNom.Top = 20;
                lblNom.AutoSize = true;

                lblCouleur.Text = maDB.Tables["Espece"].Rows[i]["couleur"].ToString();
                lblCouleur.Left = 110;
                lblCouleur.Top = 35;
                lblCouleur.AutoSize = true;

                for (int j = 0; j < maDB.Tables["Habiter"].Rows.Count; j++)
                {
                    if (maDB.Tables["Espece"].Rows[i]["id"].ToString() == maDB.Tables["Habiter"].Rows[j]["idEspece"].ToString())
                    {
                        planete += maDB.Tables["Habiter"].Rows[j]["nomPlanete"].ToString() + "/";
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
                lblOrigine.Top = 65;
                lblOrigine.AutoSize = true;

                p.Controls.Add(pb);
                p.Controls.Add(lblNom);
                p.Controls.Add(lblCouleur);
                p.Controls.Add(lblOrigine);

                layEspece.Controls.Add(p);
            }
        }

        private void volet4_Load(object sender, EventArgs e)
        {
            Creation_De_Panel();
        }

        private void btn_filtre_Click(object sender, EventArgs e)
        {
            filtre fenetreFiltre = new filtre();

            if (fenetreFiltre.ShowDialog() == DialogResult.OK)
            {
                string couleurRecherche = fenetreFiltre.Couleur;
                string nomRecherche = fenetreFiltre.NomEspece;

                Creation_De_Panel(nomRecherche, couleurRecherche, fenetreFiltre.Allie, fenetreFiltre.Ennemi);
            }
        }

        private void btnPlantes_Click(object sender, EventArgs e)
        {
            volet5 fenetrePlanete = new volet5();

            fenetrePlanete.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
