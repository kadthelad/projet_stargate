using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
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
using Image = System.Drawing.Image;
using PdfImage = iText.Layout.Element.Image;

namespace projet_SAE_24
{
    public partial class Journal : Form
    {
        string projectPath = Application.StartupPath;
        readonly int m_missionNumero;
        readonly string m_missionPlanete;
        DataSet monds = MesDatas.DsGlobal;
       
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

            pcbRetour.Image = Properties.Resources.fleche_retour;



            // Creation de la table pour le contact avec les informateurs
            DataTable tblContactsInformateurs = new DataTable();
            tblContactsInformateurs.Columns.Add("Date");
            tblContactsInformateurs.Columns.Add("Somme");
            tblContactsInformateurs.Columns.Add("Appreciation");
            tblContactsInformateurs.Columns.Add("Informateurs");

            DataTable tblInformateurs = monds.Tables["Informateurs"];

            int sommeVerse = 0;
            DataRow[] lignesContactMissionChoisis = monds.Tables["Contact"].Select($"numeroMission = {m_missionNumero} AND nomPlanete = '{m_missionPlanete}'");
            if (lignesContactMissionChoisis.Length > 0)
            {
                DataTable tblContactMissionChoisis = lignesContactMissionChoisis.CopyToDataTable();
                foreach (DataRow ligne in tblContactMissionChoisis.Rows)
                {
                    var test = ligne["nomCodeInformateur"];
                    sommeVerse += Convert.ToInt32(ligne["sommeVersee"]);
                    string codeInformateur = ligne["nomCodeInformateur"].ToString();
                    DataTable tblInformateur = monds.Tables["Informateur"].Select($"nomCode = '{codeInformateur}'").CopyToDataTable();
                    string nomInformateur = tblInformateur.Rows[0]["nom"].ToString();
                    tblContactsInformateurs.Rows.Add(
                        ligne["dateC"],
                        ligne["sommeVersee"],
                        ligne["appreciation"],
                        nomInformateur
                        );
                }
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
            DataRow[] lignesDepenseMissionChoisis = monds.Tables["Depense"].Select($"numeroMission = {m_missionNumero} AND nomPlanete = '{m_missionPlanete}'");

            if (lignesDepenseMissionChoisis.Length > 0)
            {

                DataTable tblDepenseMissionChoisis = lignesDepenseMissionChoisis.CopyToDataTable();
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
            }


            // Affichage table dépenses
            dgvDepenses.DataSource = tblDepenses;

            //Affichage dépenses total
            lblTotalDepenses.Text += sommeDepense;
        }

        public void creerPDF()
        {


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

        private void btnPdf_Click(object sender, EventArgs e)
        {
            // Création du fichier PDF
            string cheminPdf = Path.Combine(projectPath, "BilanCapture_" + m_missionPlanete + "_" + m_missionNumero + ".pdf"); // Chemin de sauvegarde

            PdfWriter writer = new PdfWriter(cheminPdf); // Permet d'écrire...
            PdfDocument pdf = new PdfDocument(writer); // ...dans ce PDF...
            Document document = new Document(pdf); // ...qui sera stocké dans ce fichier Document

            // Changement de la police d'écriture
            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            PdfFont fontBold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

            // Titre
            Paragraph titre = new Paragraph("Bilan Capture - " + m_missionPlanete + " " + m_missionNumero)
                .SetFont(fontBold) // En gras
                .SetFontSize(24) // La taille de la police
                .SetTextAlignment(TextAlignment.CENTER); // L'alignement du texte
            document.Add(titre); // Ajouter le texte dans le document

            document.Add(new Paragraph("\n")); // Pour ajouter un espace entre le titre et les infos

            bool tblEstPresent = true;
            DataTable tblBilanCapture = new DataTable();
            try
            {
                tblBilanCapture = monds.Tables[$"BilanCapture{m_missionPlanete}-{m_missionNumero}"];
                if(tblBilanCapture == null)
                {
                    tblEstPresent = false;
                }
            }
            catch
            {
                tblEstPresent = false;

            }

            if (tblEstPresent)
            {

                // Tableau des captures
                Table table = new Table(UnitValue.CreatePercentArray(new float[] { 2, 2, 2, 2 }));
                table.SetWidth(UnitValue.CreatePercentValue(100));

                // En-tetes du tableau
                table.AddHeaderCell(new Cell().Add(new Paragraph("Nom de l'espèce").SetFont(fontBold)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Objectif initial").SetFont(fontBold)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Nombre de captures réalisées").SetFont(fontBold)));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Taux de reussite (en %)").SetFont(fontBold)));

                // Remplir le tableau avec les données du DataSet...
                // On recupere la table BilanCapture pour la mission selectioné 

                foreach (DataRow lignecapture in tblBilanCapture.Rows)
                {
                    table.AddCell(lignecapture["nomEspece"].ToString());
                    table.AddCell(lignecapture["objectifInitial"].ToString());
                    table.AddCell(lignecapture["resultatFinal"].ToString());
                    table.AddCell(lignecapture["tauxReussite"].ToString());
                }
                document.Add(table); // Ajouter le tableau sur le pdf
            }
            else
            {
                document.Add(new Paragraph("Pas de capture").SetTextAlignment(TextAlignment.CENTER));
            }

            // Fermeture 
            document.Close();
            pdf.Close();
            writer.Close();
        }
    }
}
