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

                string planete = ligne["nom"].ToString().Trim();
                string gravite = ligne["gravite"].ToString().Trim();
                string databaz = "";

                pb1.Image = Image.FromFile(projectPath + "/img/planetes/" + planete + ".png");
                pb1.SizeMode = PictureBoxSizeMode.StretchImage;

                p.Width = 175;
                p.Height = 150;

                p.Margin = new Padding(30);

                lblNomPlanete.Text = planete;
                lblNomPlanete.Left = 100;
                lblNomPlanete.Top = 5;
                lblNomPlanete.AutoSize = true;
                lblNomPlanete.Font = new Font("Arial", 8, FontStyle.Bold);

                lblNomPlanete.Top = pb1.Bottom + 5;
                lblNomPlanete.Left = pb1.Left + (pb1.Width - lblNomPlanete.PreferredWidth) / 2;

                if (ligne["temperature"] != DBNull.Value)
                {
                    int temperature = Convert.ToInt32(ligne["temperature"]);
                    lblTemperature.Text = temperature.ToString() + "°";

                    if (temperature < 0)
                    {
                        pb2.Image = Image.FromFile(projectPath + "/img/thermometre/enerve.jpg");
                    }
                    else if (temperature >= 0 && temperature <= 100)
                    {
                        pb2.Image = Image.FromFile(projectPath + "/img/thermometre/normal.jpg");
                    }
                    else if (temperature > 100)
                    {
                        pb2.Image = Image.FromFile(projectPath + "/img/thermometre/heureux.jpg");
                    }
                }

                lblTemperature.AutoSize = true;

                pb2.SizeMode = PictureBoxSizeMode.StretchImage;

                pb2.Width = 20;
                pb2.Height = 20;

                pb2.Left = p.Left;
                pb2.Top = pb1.Bottom + 20;

                lblTemperature.Left = pb2.Right + 10;
                lblTemperature.Top = pb2.Top + 5;

                lblGravite.Text = "Gravité : " + gravite;
                lblGravite.Top = pb2.Bottom + 5;
                lblGravite.Left = p.Left;

                if (ligne["dataBazON"] != DBNull.Value)
                {
                    int db = Convert.ToInt32(ligne["dataBazON"]);

                    switch (db)
                    {
                        case 1:
                            databaz = "Présence de DataBaz";
                            lblDataBaz.ForeColor = Color.Green;
                            break;
                        case 0:
                            databaz = "Pas de DataBaz";
                            lblDataBaz.ForeColor = Color.Red;
                            break;
                        default:
                            databaz = "";
                            break;
                    }
                }
                
                lblDataBaz.Text = databaz;
                lblDataBaz.AutoSize = true;
                lblDataBaz.Top = lblGravite.Bottom + 2;
                lblDataBaz.Left = p.Left;

                p.Controls.Add(pb1);
                p.Controls.Add(pb2);
                p.Controls.Add(lblNomPlanete);
                p.Controls.Add(lblTemperature);
                p.Controls.Add(lblGravite);
                p.Controls.Add(lblDataBaz);
                layPlanetes.Controls.Add(p);
                
            }
        }
    }
}
