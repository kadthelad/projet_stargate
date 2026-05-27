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

            string cheminProjet = Application.StartupPath;
            // ajout de l'icone de journal sur le bouton de journal
            try
            {
                Image img = Image.FromFile(cheminProjet + "/img/icons/journal.png");
                pcbJournal.Image = img;
            }
            catch (Exception error)
            {
                Image img = Image.FromFile(cheminProjet + "/img/membres/placeholder.png");
                pcbJournal.Image = img;
            }

            //ajout de l'image de la planete
            try
            {
                Image img = Image.FromFile(cheminProjet + "/img/planetes/" + m_missionPlanete + ".png");
                pcbPlanete.Image = img;
            }
            catch (Exception error)
            {
                Image img = Image.FromFile(cheminProjet + "/img/membres/placeholder.png");
                pcbPlanete.Image = img;
            }

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
            int haut = 30;
            int gauche = 30;
            foreach (DataRow objectifDeCapture in tblObjectifCapture.Rows)
            {
                int idEnnemie = Convert.ToInt32(objectifDeCapture["idEspeceEnnemi"]);
                string nomEnnemie = monds.Tables["Espece"].Select($"id = {idEnnemie}")[0]["Nom"].ToString();

                

                Label lblObjectif = new Label();
                string objectifPrises = objectifDeCapture["objectif"].ToString();
                lblObjectif.Text = $"{nomEnnemie} --> {objectifPrises} prise(s)";
                lblObjectif.Top = haut;
                lblObjectif.Left = gauche;
                lblObjectif.AutoSize = true;

                haut += 20;

                grpObjectifCapture.Controls.Add(lblObjectif);
            }
        }

        private void pcbJournal_Click(object sender, EventArgs e)
        {
            Journal journal = new Journal();
            journal.Show();
        }
    }
}
