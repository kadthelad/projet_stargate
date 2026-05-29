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
        private Panel p;
        private Timer t;
        public visionMission(string nomPlanete)
        {
            InitializeComponent();

            m_nomPlanete = nomPlanete;
        }

        private void visionMission_Load(object sender, EventArgs e)
        {
            //Si le nom de la planète est pareil que le nom dans la table Mission, on affiche la ou les missions en cours/terminées
            for (int i = 0; i < maDB.Tables["Mission"].Rows.Count; i++)
            {
                if (m_nomPlanete == maDB.Tables["Mission"].Rows[i]["nomPlanete"].ToString())
                {
                    string numMission = maDB.Tables["Mission"].Rows[i]["numero"].ToString();
                    Mission miss = new Mission(m_nomPlanete, numMission);
                    layMissions.Controls.Add(miss);
                    /*Location : 12;12
                     Margin : 3;3;3;3
                     Size : 580; 387
                     */
                }
            }

            if(layMissions.Controls.Count == 0)
            {
                t = new Timer();
                p = new Panel();

                p.Width = 300;
                p.Height = 50;

                p.Left = (layMissions.Width - p.Width) / 2;
                p.Top = (layMissions.Height - p.Height) / 2;

                p.Location = new Point((layMissions.Width - p.Width) / 2, (layMissions.Height - p.Height) / 2);

                lblMission = new Label();

                lblMission.Text = "Pas de mission sur cette planète";
                lblMission.AutoSize = true;

                lblMission.Top = 20;
                lblMission.Left = p.Width;

                p.Controls.Add(lblMission);
                layMissions.Controls.Add(p);

                t.Interval = 50;
                t.Tick += DeplacerLabel;
                t.Start();
            }
        }

        private void DeplacerLabel(object sender, EventArgs e)
        {
            lblMission.Left -= 5;

            // Quand le texte sort complètement à gauche
            if (lblMission.Right < 0)
            {
                lblMission.Left = p.Width;
            }
        }

        private void btnQuitterFenetre_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
