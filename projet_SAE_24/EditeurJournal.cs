using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace projet_SAE_24
{
    public partial class EditeurJournal : Form
    {
        readonly int m_missioNumero;
        readonly string m_missionPlanete;
        public EditeurJournal()
        {
            InitializeComponent();
        }

        public EditeurJournal(int nbMissionPlanete, string missionPlanete)
        {
            InitializeComponent();
            m_missioNumero = nbMissionPlanete;
            m_missionPlanete = missionPlanete;
        }

        DataSet monds = MesDatas.DsGlobal;

        

        private void editeurJournal_Load(object sender, EventArgs e)
        {

        }

        private void btnContact_Click(object sender, EventArgs e)
        {
        }

        private void btnDepense_Click(object sender, EventArgs e)
        {

        }

        private void btnEvenement_Click(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
        }

        private void btnValiderContact_Click(object sender, EventArgs e)
        {
            DataTable tblContact = monds.Tables["Contact"];
            tblContact.Rows.Add(
             m_missionPlanete,
             m_missioNumero,
             dtpDate.Value,
             txtSomme.Text,
             rtbAppreciation.Text
                );

        }
    }
}
