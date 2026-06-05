using Org.BouncyCastle.Crypto.Engines;
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
        int m_montantRestant = 0;

        public EditeurJournal(int nbMissionPlanete, string missionPlanete)
        {
            InitializeComponent();
            m_missioNumero = nbMissionPlanete;
            m_missionPlanete = missionPlanete;
        }

        public int MontantRestant
        {
            get { return m_montantRestant; }
            set { m_montantRestant = value; }
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
            // Remplir cboInformateur
            DataTable tblInformateur = monds.Tables["Informateur"];
            cboInformateurs.DataSource = tblInformateur;
            cboInformateurs.DisplayMember = "nom";
            cboInformateurs.ValueMember = "nomCode";


            // Remplir cboTypeDepense
            DataTable tblTypeDepense = monds.Tables["TypeDepense"];
            cboTypeDepense.DataSource = tblTypeDepense;
            cboTypeDepense.DisplayMember = "libelle";
            cboTypeDepense.ValueMember = "id";


            // Remplir cboEspeceCapture
            DataTable tblEspece = monds.Tables["Espece"];
            cboEspece.DataSource = tblEspece;
            cboEspece.DisplayMember = "nom";
            cboEspece.ValueMember = "id";

            // Bloqué les dates selectionables entre le debut et la fin de la mission.
            DataTable tblMission = monds.Tables["Mission"];
            DataRow ligneMission = tblMission.Select($"nomPlanete = '{m_missionPlanete}' AND numero = {m_missioNumero}").CopyToDataTable().Rows[0];
            DateTime dateMissionDepart = DateTime.Parse(ligneMission["dateDepart"].ToString());
            DateTime dateMissionRetour = DateTime.Parse(ligneMission["dateRetour"].ToString());
            dtpDateContact.MinDate = dateMissionDepart;
            dtpDateContact.MaxDate = dateMissionRetour;

            dtpDateDepense.MinDate = dateMissionDepart;
            dtpDateDepense.MaxDate = dateMissionRetour;
            
            dtpEvent.MinDate = dateMissionDepart;
            dtpEvent.MaxDate = dateMissionRetour;
        }

        private void annulerModif_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnValiderContact_Click(object sender, EventArgs e)
        {
            appliquerContact();
        }


       

        private void btnValiderDepense_Click(object sender, EventArgs e)
        {
            appliquerDepense();
        }

        private void btnValiderEvent_Click(object sender, EventArgs e)
        {
            appliquerEvent();
        }

        private void btnValiderCapture_Click(object sender, EventArgs e)
        {
            appliquerCapture();
        }

        private void estUnChiffre(object sender, KeyPressEventArgs e)
        {
            // On verifie si le charactère saisis est bien un chiffre
            char keyChar = e.KeyChar;
            if (!Char.IsDigit(keyChar))
            {
                if (keyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
            if (e.KeyChar == (char)Keys.Return)
            {
                string txtName = ((TextBox)sender).Name;
                if (txtName== "txtSomme")
                {
                    appliquerContact();
                }
                else if(txtName == "txtMontantDepense")
                {
                    appliquerDepense();
                }
                else if(txtName == "txtNombreCapture")
                {
                    appliquerCapture();
                }
            }
        }

   
        private void appliquerContact()
        {
            int sommeContact = Convert.ToInt32(txtSomme.Text);
            if (sommeContact > m_montantRestant)
            {
                errSomme.SetError(txtSomme, "Pas assez d'argent");
            }
            else
            {
                monds.Tables["Contact"].Rows.Add(
                  m_missionPlanete,
                  m_missioNumero,
                  dtpDateContact.Value.ToString("yyyy-MM-dd"),
                  sommeContact,
                  echApostrophe(rtbAppreciation.Text),
                  cboInformateurs.SelectedValue
                     );
                this.Close();
            }
        }

        private void appliquerDepense()
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

            int montantDepense = Convert.ToInt32(txtMontantDepense.Text);
            // faire affichage erreur pas assez d'argent
            if (montantDepense > m_montantRestant)
            {
                errSomme.SetError(txtMontantDepense, "Pas assez d'argent");
            }
            else
            {
                monds.Tables["Depense"].Rows.Add(
                 m_missionPlanete,
                 m_missioNumero,
                 idDepense,
                 dtpDateDepense.Value.ToString("yyyy-MM-dd"),
                 montantDepense,
                 echApostrophe(rtbMotifDepense.Text),
                 cboTypeDepense.SelectedValue
                    );
                this.Close();
            }
        }

        private void appliquerEvent()
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

        private void appliquerCapture()
        {
            bool especeDejaPresente = false;
            int indexLigneEspecePresente = 0;
            DataTable tblCapture = monds.Tables["Capturer"];
            for (int i = 0; i < tblCapture.Rows.Count; i++)
            {
                DataRow ligne = tblCapture.Rows[i];
                if (Convert.ToInt32(ligne["idEspeceEnnemi"]) == Convert.ToInt32(cboEspece.SelectedValue))
                {
                    especeDejaPresente = true;
                    indexLigneEspecePresente = i;
                }
            }


            if (!especeDejaPresente)
            // Si l'espece n'est pas ajouté on crée une nouvelle ligne et on l'ajoute
            {
                monds.Tables["Capturer"].Rows.Add(
                    m_missionPlanete,
                    m_missioNumero,
                    Convert.ToInt32(cboEspece.SelectedValue),
                    Convert.ToInt32(txtNombreCapture.Text)
                    );
            }
            else
            // Sinon on incremente juste le nombre d'especes deja capturé
            {
                int nbDejaCapturer = Convert.ToInt32(monds.Tables["Capturer"].Rows[indexLigneEspecePresente]["nombre"]);
                monds.Tables["Capturer"].Rows[indexLigneEspecePresente]["nombre"] = nbDejaCapturer + Convert.ToInt32(txtNombreCapture.Text);
            }
            this.Close();
        }


    }
}
