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

        public visionMission(string nomPlanete)
        {
            InitializeComponent();

            MessageBox.Show("je suis la planète " + nomPlanete);
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
                }
            }
        }

        private void btnQuitterFenetre_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
