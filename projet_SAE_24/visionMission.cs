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
    public partial class visionMission : Form
    {
        public visionMission()
        {
            InitializeComponent();
        }

        SQLiteConnection maConnec = Connexion.Connec;
        DataSet maDB = MesDatas.DsGlobal;

        private string m_nomPlanete;
        private Label lblMission;
        private Label lblEspece;
        private Panel p;
        private Timer t;
        public visionMission(string nomPlanete)
        {
            InitializeComponent();

            m_nomPlanete = nomPlanete;
        }

        private void visionMission_Load(object sender, EventArgs e)
        {
            string espece = "";
            string pourcentage = "";
            int idEspece;
            lblEspece = new Label();

            //Si le nom de la planète est pareil que le nom dans la table Mission, on affiche la ou les missions en cours/terminées
            for (int i = 0; i < maDB.Tables["Mission"].Rows.Count; i++)
            {
                if (m_nomPlanete == maDB.Tables["Mission"].Rows[i]["nomPlanete"].ToString())
                {
                    string numMission = maDB.Tables["Mission"].Rows[i]["numero"].ToString();
                    Mission miss = new Mission(m_nomPlanete, numMission);
                    layMissions.Controls.Add(miss);
                }
            }

            for(int i = 0; i < maDB.Tables["Habiter"].Rows.Count; i++)
            {
                if (maDB.Tables["Habiter"].Rows[i]["nomPlanete"].ToString() == m_nomPlanete)
                {
                    idEspece = Convert.ToInt32(maDB.Tables["Habiter"].Rows[i]["idEspece"]);
                    pourcentage = maDB.Tables["Habiter"].Rows[i]["pourcentage"].ToString() + " %";
                    for (int j = 0; j < maDB.Tables["Espece"].Rows.Count; j++)
                    {
                        if (Convert.ToInt32(maDB.Tables["Espece"].Rows[j]["id"]) == idEspece)
                        {
                            espece += maDB.Tables["Espece"].Rows[j]["nom"].ToString() + " : " + pourcentage + "\n";

                            break;
                        }
                    }
                }
            }

            lblEspece.Text = espece;
            lblEspece.Top = 20;
            lblEspece.Left = 10;
            lblEspece.AutoSize = true;
            lblEspece.Font = new Font("Arial", 12);

            grpEspeces.Controls.Add(lblEspece);

            if (layMissions.Controls.Count == 0)
            {
                layMissions.Dispose();

                t = new Timer();
                p = new Panel();

                p.Width = 300;
                p.Height = 50;

                p.Left = (this.ClientSize.Width - p.Width) / 2;
                p.Top = (this.ClientSize.Height - p.Height) / 2;

                lblMission = new Label();

                lblMission.Font = new Font("Arial", 16, FontStyle.Bold);
                lblMission.Text = "Pas de mission sur cette planète";
                lblMission.AutoSize = true;

                lblMission.Top = 20;
                lblMission.Left = p.Width;

                p.Controls.Add(lblMission);
                this.Controls.Add(p);

                t.Interval = 50;
                t.Tick += DeplacerLabelHorizontalement;
                t.Start();
            }

            if (espece == string.Empty)
            {
                t = new Timer();

                lblEspece.Font = new Font("Arial", 9, FontStyle.Bold);
                lblEspece.Text = "Pas d'espèce présente";
                lblEspece.AutoSize = true;

                t.Interval = 50;
                t.Tick += DeplacerLabelVerticalement;
                t.Start();
            }
        }

        private void DeplacerLabelHorizontalement(object sender, EventArgs e)
        {
            lblMission.Left -= 5;

            // Quand le texte sort complètement à gauche
            if (lblMission.Right < 0)
            {
                lblMission.Left = p.Width;
            }
        }

        private void DeplacerLabelVerticalement(object sender, EventArgs e)
        {
            lblEspece.Top += 5;

            // Quand le texte sort complètement en bas
            if (lblEspece.Top > grpEspeces.Bottom)
            {
                lblEspece.Top = grpEspeces.Top;
            }
        }

        private void btnQuitterFenetre_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
