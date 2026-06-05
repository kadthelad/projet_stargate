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
using System.Diagnostics;
using Org.BouncyCastle.Utilities.Encoders;


namespace projet_SAE_24
{
    public partial class Volet3 : Form
    {
        readonly int m_missioNumero;
        readonly string m_missionPlanete;
        int m_montantRestant = 0;
        public Volet3(int nbMissionPlanete, string missionPlanete)
        {
            InitializeComponent();
            m_missioNumero = nbMissionPlanete;
            m_missionPlanete = missionPlanete;

        }

        DataSet monds = MesDatas.DsGlobal;

        private void recapMission_Load(object sender, EventArgs e)
        {
            remplirForm();
        }

        private void remplirForm()
        {
            // ajout de l'icone de journal sur le bouton de journal
            pcbJournal.Image = Properties.Resources.journal;

            //ajout de l'image de la planete
            pcbPlanete.Image = (Image)Properties.Resources.ResourceManager.GetObject(m_missionPlanete);

            //ajout de l'image de retour
            pcbRetour.Image = Properties.Resources.fleche_retour;

            //ajout de l'image de retour
            pcbModifier.Image = Properties.Resources.crayon;


            // recuperation de la table des missions
            DataTable tblMission = monds.Tables["Mission"];

            // recuperation de la mission
            DataRow ligneDeLaMission = tblMission.Select($"nomPlanete = '{m_missionPlanete}' AND numero = {m_missioNumero}").CopyToDataTable().Rows[0];
            string matriculeChef = ligneDeLaMission["matriculeChef"].ToString();

            // pour le nom de la mission
            lblMisssion.Text = ligneDeLaMission["nomPlanete"].ToString();

            // pour les dates
            lblDateDepartFill.Text = ligneDeLaMission["dateDepart"].ToString();
            lblDateRetourFill.Text = ligneDeLaMission["dateRetour"].ToString();

            //pour le journal de bord
            rtbFeuilleDeRoute.Text = ligneDeLaMission["feuilleDeRoute"].ToString();

            // pour le budget
            int budget = Convert.ToInt32(ligneDeLaMission["budget"]);
            lblBudgetFill.Text = budget.ToString();


            // pour sold restant
            //DataTable tblDepenses = monds.Tables["Depense"];
            int depenseTotal = 0;
            DataRow[] lignesDepense = monds.Tables["Depense"].Select($"nomPlanete = '{m_missionPlanete}' AND numeroMission = {m_missioNumero}");
            DataRow[] lignesContact = monds.Tables["Contact"].Select($"nomPlanete = '{m_missionPlanete}' AND numeroMission = {m_missioNumero}");

            if (lignesDepense.Length > 0)
            {
                DataTable tblTotalDepenses = lignesDepense.CopyToDataTable();
                foreach (DataRow ligne in tblTotalDepenses.Rows)
                {
                    depenseTotal += Convert.ToInt32(ligne["montant"]);
                }
            }

            if (lignesContact.Length > 0)
            {
                DataTable tblTotalContact = lignesContact.CopyToDataTable();
                foreach (DataRow ligne in tblTotalContact.Rows)
                {
                    depenseTotal += Convert.ToInt32(ligne["sommeVersee"]);
                }
            }

            //Quand on a calculer toutes les dépenses
            m_montantRestant = budget - depenseTotal;
            lblSoldeRestantFill.Text = (budget - depenseTotal).ToString();



            // Ajout des membres

            flpMembres.Controls.Clear();
            DataTable membresDeLaMission = monds.Tables["Composer"].Select($"numeroMission = {m_missioNumero} AND nomPlanete = '{m_missionPlanete}'").CopyToDataTable();
            foreach (DataRow membreMission in membresDeLaMission.Rows)
            {
                string matriculeMembre = membreMission["matriculeMembre"].ToString();
                string typeMembre = matriculeMembre.Substring(0, 1);
                switch (typeMembre)
                {
                    case "C":
                        typeMembre = "civil";
                        break;
                    case "M":
                        typeMembre = "militaire";
                        break;
                }

                DataTable tableMembre = monds.Tables["Membre"];
                string nomMembre = tableMembre.Select($"matricule = '{matriculeMembre}'").CopyToDataTable().Rows[0]["Nom"].ToString();
                string prenomMembre = tableMembre.Select($"matricule = '{matriculeMembre}'").CopyToDataTable().Rows[0]["Prenom"].ToString();
                ucMembre membre = new ucMembre(nomMembre, prenomMembre, typeMembre);

                if (matriculeChef == matriculeMembre)
                {
                    membre.definirChef();
                }

                flpMembres.Controls.Add(membre);
            }

            // Création table captures
            DataRow[] lignesObjectifCapture = monds.Tables["ObjectifCapture"].Select($"nomPlanete = '{m_missionPlanete}' AND numeroMission = {m_missioNumero}");
            DataRow[] lignesCapture = monds.Tables["Capturer"].Select($"nomPlanete = '{m_missionPlanete}' AND numeroMission = {m_missioNumero}");


            int maxIteration = Math.Max(lignesCapture.Length, lignesObjectifCapture.Length);
            if (maxIteration > 0)
            {
                flpCapture.Controls.Clear();
                for (int i = 0; i < maxIteration; i++)
                {
                    int idEnnemie;
                    string nomEnnemie = "";

                    int objectifPrises = 0;
                    int prises = 0;

                    // On verifie que la ligne existe
                    if (lignesObjectifCapture.Length - 1 >= i)
                    {
                        DataRow objectifDeCapture = lignesObjectifCapture[i];

                        idEnnemie = Convert.ToInt32(objectifDeCapture["idEspeceEnnemi"]);
                        nomEnnemie = monds.Tables["Espece"].Select($"id = {idEnnemie}")[0]["Nom"].ToString();
                        objectifPrises = Convert.ToInt32(objectifDeCapture["objectif"]);
                    }

                    // On verifie que la ligne existe
                    if (lignesCapture.Length - 1 >= i)
                    {
                        DataRow lignePrises = lignesCapture[i];
                        idEnnemie = Convert.ToInt32(lignePrises["idEspeceEnnemi"]);
                        nomEnnemie = monds.Tables["Espece"].Select($"id = {idEnnemie}")[0]["Nom"].ToString();
                        prises = Convert.ToInt32(lignePrises["nombre"]);
                    }
                    Label lblObjectif = new Label();
                    lblObjectif.AutoSize = true;


                    // On affecte le texte au label

                    lblObjectif.Text = $"{nomEnnemie} --> {prises}/{objectifPrises} prise(s)";
                    flpCapture.Controls.Add(lblObjectif);
                }
            }

            // Création de la table de capture de compte rendu de mission
            DataTable tblResultatCapture = new DataTable();

            //Ajout des differentes colones
            tblResultatCapture.Columns.Add("nomEspece");
            tblResultatCapture.Columns.Add("objectifInitial");
            tblResultatCapture.Columns.Add("resultatFinal");
            tblResultatCapture.Columns.Add("tauxReussite");


            for (int i = 0; i < lignesCapture.Length; i++)
            {
                DataRow ligneResultat = lignesCapture[i];
                DataRow ligneObjectif = monds.Tables["objectifCapture"].NewRow();
                if(lignesObjectifCapture.Length-1 >= i)
                {
                    ligneObjectif = lignesObjectifCapture[i];
                }
                

                    int idEspece = Convert.ToInt32(ligneObjectif["idEspeceEnnemi"]);
                string nomEspece = monds.Tables["Espece"].Select($"id = {idEspece}")[0]["nom"].ToString();
                int objectifInital = Convert.ToInt32(ligneObjectif["objectif"]);
                int resultatFinal = 0;
                double tauxReussite;

                resultatFinal = Convert.ToInt32(ligneResultat["nombre"]);
                tauxReussite = Math.Round(objectifInital / (double)resultatFinal)*100;

                tblResultatCapture.Rows.Add(
                    nomEspece,
                    objectifInital,
                    resultatFinal,
                    tauxReussite
                    );
            }
            string tblName = $"BilanCapture{m_missionPlanete}-{m_missioNumero}";
            tblResultatCapture.TableName = tblName;
            if (monds.Tables[tblName]!= null)
            {
                monds.Tables.Remove(tblName);
            }
            monds.Tables.Add(tblResultatCapture);
        }

        private void pcbJournal_Click(object sender, EventArgs e)
        {
            Journal journal = new Journal(m_missionPlanete, m_missioNumero);
            journal.MaximumSize = journal.Size;
            journal.MinimumSize = journal.Size;
            journal.ShowDialog();
        }

        private void pcbRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbModifier_Click(object sender, EventArgs e)
        {
            EditeurJournal editeurJournal = new EditeurJournal(m_missioNumero, m_missionPlanete);
            editeurJournal.MaximumSize = editeurJournal.Size;
            editeurJournal.MinimumSize = editeurJournal.Size;
            editeurJournal.MontantRestant = m_montantRestant;
            editeurJournal.ShowDialog();
            remplirForm();
        }
    }
}
