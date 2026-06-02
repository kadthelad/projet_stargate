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

            Image btnontact = Properties.Resources.ajouterContact;
            btnontact.Image = contact;
            btnContact.Width = contact.Width + 10;
            btnContact.Height = contact.Height + 10;

            Image depenses = Properties.Resources.depenses;
            btnDepense.Image = depenses;
            btnDepense.Width = depenses.Width + 10;
            btnDepense.Height = depenses.Height + 10;

            Image evenement = Properties.Resources._event;
            btnEvenement.Image = evenement;
            btnEvenement.Width = evenement.Width + 10;
            btnEvenement.Height = evenement.Height + 10;


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
             TAppreciation
                );

        }
    }
}
