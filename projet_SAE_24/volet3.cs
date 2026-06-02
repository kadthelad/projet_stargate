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


namespace projet_SAE_24
{
    public partial class Volet3 : Form
    {
        readonly int m_missioNumero;
        readonly string m_missionPlanete;
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
            pcbRetour.Image = Properties.Resources.retour;

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
            lblDateDepart.Text += ligneDeLaMission["dateDepart"].ToString();
            lblDateRetour.Text += ligneDeLaMission["dateRetour"].ToString();

            //pour le journal de bord
            rtbFeuilleDeRoute.Text = ligneDeLaMission["feuilleDeRoute"].ToString();

            // pour le budget
            lblBudget.Text += ligneDeLaMission["budget"].ToString();

            // pour sold restant
            DataTable tblDepenses = monds.Tables["Depense"];
            DataTable tblTotalDepenses = tblDepenses.Select("numeroMission = " + m_missioNumero.ToString()).CopyToDataTable();

            double depenseTotal = 0;
            foreach (DataRow ligne in tblTotalDepenses.Rows)
            {
                depenseTotal += Convert.ToDouble(ligne["montant"]);
            }
            lblSoldeRestant.Text += depenseTotal.ToString();

            // pour les membres
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
            DataTable tblObjectifCapture = monds.Tables["ObjectifCapture"].Select($"nomPlanete = '{m_missionPlanete}' AND numeroMission = {m_missioNumero}").CopyToDataTable();
            //int haut = 30;
            //int gauche = 30;
            foreach (DataRow objectifDeCapture in tblObjectifCapture.Rows)
            {
                int idEnnemie = Convert.ToInt32(objectifDeCapture["idEspeceEnnemi"]);
                string nomEnnemie = monds.Tables["Espece"].Select($"id = {idEnnemie}")[0]["Nom"].ToString();



                Label lblObjectif = new Label();
                string objectifPrises = objectifDeCapture["objectif"].ToString();
                lblObjectif.Text = $"{nomEnnemie} --> {objectifPrises} prise(s)";
                lblObjectif.AutoSize = true;


                flpCapture.Controls.Add(lblObjectif);
            }

            // Création de la table de capture de compte rendu de mission
            DataTable tblResultatCapture = new DataTable();

            //Ajout des differentes colones
            tblResultatCapture.Columns.Add("nomEspece");
            tblResultatCapture.Columns.Add("objectifInitial");
            tblResultatCapture.Columns.Add("resultatFinal");
            tblResultatCapture.Columns.Add("tauxReussite");

            DataTable tblCapture = monds.Tables["Capturer"];
            for (int i = 0; i < tblObjectifCapture.Rows.Count; i++)
            {
                DataRow ligneObjectif = tblObjectifCapture.Rows[i];
                DataRow ligneResultat = tblCapture.Rows[i];
                string nomEspece = monds.Tables["Espece"].Select($"id = {ligneObjectif["idEspeceEnnemi"]}")[0]["nom"].ToString();
                int objectifInital = Convert.ToInt32(ligneObjectif["objectif"]);
                int resultatFinal = Convert.ToInt32(ligneResultat["nombre"]);
                double tauxReussite = objectifInital / resultatFinal;

                tblResultatCapture.Rows.Add(
                    nomEspece,
                    objectifInital,
                    resultatFinal,
                    tauxReussite
                    );
            }
            string tblName = $"BilanCapture{m_missionPlanete}-{m_missioNumero}";
            tblResultatCapture.TableName = tblName;
            if (monds.Tables[tblName] != null)
            {
                monds.Tables.Add(tblResultatCapture);
            }
        }

        private void pcbJournal_Click(object sender, EventArgs e)
        {
            Journal journal = new Journal(m_missionPlanete, m_missioNumero);
            journal.ShowDialog();
        }

        private void pcbRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbModifier_Click(object sender, EventArgs e)
        {
            EditeurJournal editeurJournal = new EditeurJournal();
            editeurJournal.ShowDialog();
        }
    }
}
