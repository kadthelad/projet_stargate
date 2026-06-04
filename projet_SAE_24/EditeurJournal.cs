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
        

        public EditeurJournal(int nbMissionPlanete, string missionPlanete)
        {
            InitializeComponent();
            m_missioNumero = nbMissionPlanete;
            m_missionPlanete = missionPlanete;
        }

        DataSet monds = MesDatas.DsGlobal;

        private String echApostrophe(String texte)
        {
            String returnTexte = "";
            foreach (char ch in texte)
            {
                if (ch == '\'')
                {
                    returnTexte += ch + "'";
                }
                else
                {
                    returnTexte += ch;
                }
            }

            return returnTexte;
        }

        private void editeurJournal_Load(object sender, EventArgs e)
        {
            //Remplir cboInformateur
            DataTable tblInformateur = monds.Tables["Informateur"];
            cboInformateurs.DataSource = tblInformateur;
            cboInformateurs.DisplayMember = "nom";
            cboInformateurs.ValueMember = "nomCode";


            //Remplir cboTypeDepense
            DataTable tblTypeDepense = monds.Tables["TypeDepense"];
            cboTypeDepense.DataSource = tblTypeDepense;
            cboTypeDepense.DisplayMember = "libelle";
            cboTypeDepense.ValueMember = "id";

        }


        private void btnValiderContact_Click(object sender, EventArgs e)
        {
            monds.Tables["Contact"].Rows.Add(
              m_missionPlanete,
              m_missioNumero,
              dtpDateContact.Value.ToString("yyyy-MM-dd"),
              Convert.ToInt64(txtSomme.Text),
              echApostrophe(rtbAppreciation.Text),
              cboInformateurs.SelectedValue
                 );
            // Pour debug à enlever
            DataRow dr = monds.Tables["Contact"].Rows[monds.Tables["Contact"].Rows.Count-1];
            this.Close();

        }


        private void annulerModif_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValiderDepense_Click(object sender, EventArgs e)
        {

            DataTable tblDepense = monds.Tables["Depense"];

            int idDepense = 0;
            foreach (DataRow ligne in tblDepense.Rows)
            {
                int id = Convert.ToInt32(ligne["id"]);
                if (id > idDepense)
                {
                    idDepense = id;
                }

            }

            monds.Tables["Depense"].Rows.Add(
             m_missionPlanete,
             m_missioNumero,
             idDepense,
             dtpDateDepense.Value.ToString("yyyy-MM-dd"),
             Convert.ToInt32(txtMontantDepense.Text),
             echApostrophe(rtbMotifDepense.Text),
             cboTypeDepense.SelectedValue
                );
            MessageBox.Show(monds.Tables["Depense"].Rows.Count.ToString());

            

            this.Close();

        }

        private void btnValiderEvent_Click(object sender, EventArgs e)
        {
            DataTable tblDepense = monds.Tables["JournalDeBord"];


            tblDepense.Rows.Add(
             m_missionPlanete,
             m_missioNumero,
             dtpDateDepense.Value.ToString("yyyy-MM-dd"),
             echApostrophe(rtbCommentaireEvent.Text)
                );
            this.Close();
        }

        private void estUnChiffre(object sender, KeyPressEventArgs e)
        {
            // On verifie si le charactère saisis est bien un chiffre
            char keyChar = e.KeyChar;
            if (!Char.IsDigit(keyChar))
            {
                e.Handled = true;
            }
        }
    }
}
