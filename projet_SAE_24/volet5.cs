using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_SAE_24
{
    public partial class volet5 : Form
    {
        public volet5()
        {
            InitializeComponent();
        }

        SQLiteConnection maConnec = Connexion.Connec;
        DataSet maDB = MesDatas.DsGlobal;

        string projectPath = Application.StartupPath;

        private void volet5_Load(object sender, EventArgs e)
        {
            foreach (DataRow ligne in maDB.Tables["Planete"].Rows)
            {
                PictureBox pb1 = new PictureBox();
                PictureBox pb2 = new PictureBox();
                Panel p = new Panel();
                Label lblNomPlanete = new Label();
                Label lblTemperature = new Label();
                Label lblGravite = new Label();
                Label lblDataBaz = new Label();

                //Pour donner un nom à chacun de mes labels
                p.Name = ligne["nom"].ToString();

                string planete = ligne["nom"].ToString().Trim();
                string gravite = ligne["gravite"].ToString().Trim();
                string databaz = "";

                Image img1 = (Image)Properties.Resources.ResourceManager.GetObject(planete);

                pb1.Image = img1;
                pb1.SizeMode = PictureBoxSizeMode.StretchImage;

                //Couleur d'arrière-plan non définitive
                p.BackColor = Color.Magenta;
                p.Width = 300;
                p.Height = 300;

                p.Margin = new Padding(30);

                pb1.Width = 150;
                pb1.Height = 100;
                pb1.Left = p.Width / 2 - pb1.Width / 2;
                pb1.Top = p.Height / 2 - pb1.Height;

                lblNomPlanete.Text = planete;
                lblNomPlanete.Left = 100;
                lblNomPlanete.Top = 5;
                lblNomPlanete.AutoSize = true;
                lblNomPlanete.Font = new Font("Arial", 16, FontStyle.Bold);

                lblNomPlanete.Top = pb1.Bottom + 5;
                lblNomPlanete.Left = pb1.Left + (pb1.Width - lblNomPlanete.PreferredWidth) / 2;

                //Si la température n'est pas nulle, on affiche une image différente en fonction du niveau de température
                if (ligne["temperature"] != DBNull.Value)
                {
                    int temperature = Convert.ToInt32(ligne["temperature"]);
                    lblTemperature.Text = temperature.ToString() + "°";

                    if (temperature < 0)
                    {
                        pb2.Image = (Image)Properties.Resources.ResourceManager.GetObject("enerve");
                    }
                    else if (temperature >= 0 && temperature <= 100)
                    {
                        pb2.Image = (Image)Properties.Resources.ResourceManager.GetObject("normal");
                    }
                    else if (temperature > 100)
                    {
                        pb2.Image = (Image)Properties.Resources.ResourceManager.GetObject("heureux");
                    }
                }

                pb2.SizeMode = PictureBoxSizeMode.StretchImage;

                pb2.Width = 20;
                pb2.Height = 20;

                pb2.Left = pb1.Left;
                pb2.Top = lblNomPlanete.Bottom + 10;

                lblTemperature.AutoSize = true;
                lblTemperature.Left = pb2.Right + 10;
                lblTemperature.Top = pb2.Top;
                lblTemperature.Font = new Font("Arial", 16);

                //Gravité vide = on affiche rien
                if(gravite == "")
                {
                    lblGravite.Text = "";
                }
                else
                {
                    lblGravite.Text = "Gravité : " + gravite;
                }

                lblGravite.AutoSize = true;
                lblGravite.Top = lblTemperature.Bottom + 5;
                lblGravite.Left = p.Width / 2 - pb1.Width / 2; ;
                lblGravite.Font = new Font("Arial", 13);

                //Si la présence de DataBaz n'est pas nulle, on stocke un texte différent avec une couleur différente en fonction de la présence de DataBaz
                if (ligne["dataBazON"] != DBNull.Value)
                {
                    int db = Convert.ToInt32(ligne["dataBazON"]);

                    switch (db)
                    {
                        case 1:
                            databaz = "Présence de DataBaz";
                            lblDataBaz.ForeColor = Color.GreenYellow;
                            break;
                        case 0:
                            databaz = "Pas de DataBaz";
                            lblDataBaz.ForeColor = Color.DarkRed;
                            break;
                        default:
                            databaz = "";
                            break;
                    }
                }
                
                lblDataBaz.Text = databaz;
                lblDataBaz.AutoSize = true;
                lblDataBaz.Top = lblGravite.Bottom + 5;
                lblDataBaz.Left = pb1.Width / 2;
                lblDataBaz.Font = new Font("Arial", 14);

                p.Controls.Add(pb1);
                p.Controls.Add(pb2);
                p.Controls.Add(lblNomPlanete);
                p.Controls.Add(lblTemperature);
                p.Controls.Add(lblGravite);
                p.Controls.Add(lblDataBaz);
                layPlanetes.Controls.Add(p);

                //Comme le Panel a été généré dynamiquement, on est obligé de faire un événement dynamiquement pour pouvoir l'utiliser
                p.Click += MonPanel_Click;
            }
        }

        private void MonPanel_Click(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;

            visionMission vm = new visionMission(p.Name);
            vm.ShowDialog();
        }

        private void btnQuitterFenetre_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
