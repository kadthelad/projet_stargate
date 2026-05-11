using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace projet_SAE_24
{
    public partial class Volet3 : Form
    {
        readonly int m_missionChoisis;
        public Volet3(int missionChoisi)
        {
            InitializeComponent();
            m_missionChoisis = missionChoisi;
        }

        DataSet monds = MesDatas.DsGlobal;

        private void recapMission_Load(object sender, EventArgs e)
        {
            remplirForm();
        }

        private void remplirForm()
        {
            DataTable tblMission = monds.Tables["Mission"];
            DataRow ligneDeLaMission = tblMission.Rows[m_missionChoisis];

            //pour le nom de la mission
            lblMisssion.Text = ligneDeLaMission["nomPlanete"].ToString();

            //pour les dates
            lblDateDepart.Text += ligneDeLaMission["dateDepart"].ToString();
            lblDateRetour.Text += ligneDeLaMission["dateRetour"].ToString();

            //pour le journal de bord
            rtbFeuilleDeRoute.Text = ligneDeLaMission["feuilleDeRoute"].ToString();

            //pour le budget
            lblBudget.Text += ligneDeLaMission["budget"].ToString();

            //pour sold restant
            DataTable tblDepenses = monds.Tables["Depense"];
            DataTable tblTotalDepenses = tblDepenses.Select("numeroMission = " + m_missionChoisis.ToString()).CopyToDataTable();

            double depenseTotal = 0;
            foreach (DataRow ligne in tblTotalDepenses.Rows)
            {
                depenseTotal += Convert.ToDouble(ligne["montant"]);
            }
            lblSoldeRestant.Text += depenseTotal.ToString();

            //pour les membres
            //ucMembre membre = new ucMembre("test");
            //pnlMembres.Controls.Add()

        }
    }
}
