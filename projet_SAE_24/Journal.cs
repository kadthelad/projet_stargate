using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_SAE_24
{
    public partial class Journal : Form
    {
        public Journal()
        {
            InitializeComponent();
        }

        public Journal(string nomPlanete, int numeroMission)
        {
            InitializeComponent();
            m_missionPlanete = nomPlanete;
            m_missionNumero = numeroMission;
        }

        private void Journal_Load(object sender, EventArgs e)
        {

            // On lui donne les données
            DataTable dt = monds.Tables["JournalDeBord"];
            bsEvenement.DataSource = dt;

            // On lie les champs au BindingSource
            rtbEvenement.DataBindings.Add("Text", bsEvenement, "commentaires");
            lblDate.DataBindings.Add("Text", bsEvenement, "dateJ");


            // Ajout de l'icon pour le bouton de retour
            string cheminProjet = Application.StartupPath;
            try
            {
                Image img = Image.FromFile(cheminProjet + "/img/icons/retour.png");
                pcbRetour.Image = img;
            }
            catch (Exception error)
            {
                MessageBox.Show("error");
                Image img = Image.FromFile(cheminProjet + "/img/membres/placeholder.png");
                pcbRetour.Image = img;
            }



            // Creation de la table pour le contact avec les informateurs
            DataTable tblContactsInformateurs = new DataTable();
            tblContactsInformateurs.Columns.Add("Date");
            tblContactsInformateurs.Columns.Add("Somme");
            tblContactsInformateurs.Columns.Add("Appreciation");
            tblContactsInformateurs.Columns.Add("Informateurs");

            DataTable tblInformateurs = monds.Tables["Informateurs"];

            int sommeVerse = 0;
            DataTable tblContactMissionChoisis = monds.Tables["Contact"]
                .Select($"numeroMission = {m_missionNumero} AND nomPlanete = '{m_missionPlanete}'")
                .CopyToDataTable();
            foreach (DataRow ligne in tblContactMissionChoisis.Rows)
            {
                sommeVerse += Convert.ToInt32(ligne["sommeVersee"]);
                string codeInformateur = ligne["nomCodeInformateur"].ToString();
                string nomInformateur = monds.Tables["Informateur"].Select($"nomCode = '{codeInformateur}'")[0]["nom"].ToString();
                tblContactsInformateurs.Rows.Add(
                    ligne["dateC"],
                    ligne["sommeVersee"],
                    ligne["appreciation"],
                    nomInformateur
                    );
            }

            // Affichage table contacts
            dgvContacts.DataSource = tblContactsInformateurs;

            // Affichage somme versé
            lblTotalSommesVerse.Text += sommeVerse;

            // Création table dépenses
            DataTable tblDepenses = new DataTable();
            tblDepenses.Columns.Add("N°");
            tblDepenses.Columns.Add("Date");
            tblDepenses.Columns.Add("Motif");
            tblDepenses.Columns.Add("Montant");
            tblDepenses.Columns.Add("Type de dépense");


            int sommeDepense = 0;
            DataTable tblDepenseMissionChoisis = monds.Tables["Depense"]
                .Select($"numeroMission = {m_missionNumero} AND nomPlanete = '{m_missionPlanete}'")
                .CopyToDataTable();
            foreach (DataRow ligne in tblDepenseMissionChoisis.Rows)
            {
                sommeDepense += Convert.ToInt32(ligne["Montant"]);
                string libelleDepense = ligne["idTypeDepense"].ToString();
                tblDepenses.Rows.Add(
                ligne["id"],
                ligne["dateD"],
                ligne["motif"],
                ligne["montant"],
                libelleDepense
                    );
            }

            // Affichage table dépenses
            dgvDepenses.DataSource = tblDepenses;

            //Affichage dépenses total
            lblTotalDepenses.Text += sommeDepense;
        }

        private void btnDebut_Click(object sender, EventArgs e)
        {
            bsEvenement.MoveFirst();
        }

        private void btnPrecedant_Click(object sender, EventArgs e)
        {
            bsEvenement.MovePrevious();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            bsEvenement.MoveNext();
        }

        private void btnFIn_Click(object sender, EventArgs e)
        {
            bsEvenement.MoveLast();
        }

        private void pcbRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        }
    }
}
