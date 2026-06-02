using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
// Sans ça, la classe Image ne fonctionnera puisque iText crée une classe Image aussi
using Image = System.Drawing.Image;
using PdfImage = iText.Layout.Element.Image;

namespace projet_SAE_24
{
	public partial class Mission : UserControl
	{
		public enum StatusMissionEnum
		{
			EN_COURS,
			EN_PREPARATION,
			EST_TERMINEE,
		}

		private StatusMissionEnum _statusMission;

		public StatusMissionEnum StatusMission  // PascalCase pour la propriété
		{
			get { return _statusMission; }
			set { _statusMission = value; }
		}

		DataSet dsGlobal = MesDatas.DsGlobal;
		String projectPath = Application.StartupPath; // trouve où est le /bin/Debug

		// On préfèrerai garder ces données dans le script comme ça on a pas à refaire certaines procédures
		// de volet1.cs
		String nomPlanete = "";
		String numeroMission = "";
		String nomChef = "";

		public Mission(String CNomPlanete, String CNumeroMission)
		{
			InitializeComponent();
			dsGlobal = MesDatas.DsGlobal;
			try
			{
				// Actualiser les labels
				DataRow missionActuelle = dsGlobal.Tables["Mission"].Select($"nomPlanete = '{CNomPlanete}'")[0];

				nomPlanete = CNomPlanete;
				numeroMission = CNumeroMission;
				nomChef = dsGlobal.Tables["Membre"].Select($"matricule = '{missionActuelle["matriculeChef"]}'")[0]["nom"] + " " +
						dsGlobal.Tables["Membre"].Select($"matricule = '{missionActuelle["matriculeChef"]}'")[0]["prenom"];

				lblTitre.Text = nomPlanete + " " + numeroMission;
				lblDateDepart.Text = missionActuelle["dateDepart"].ToString();
				lblDateFinEstimee.Text = missionActuelle["dateRetour"].ToString();
				lblNomChef.Text = nomChef;
				lblBudget.Text = "Budget : " + missionActuelle["budget"] + "$G";

				// Déterminer si la mission est en cours, terminée ou en préparation
				String[] dateDepart = missionActuelle["dateDepart"].ToString().Split('-');
				String[] dateRetour = missionActuelle["dateRetour"].ToString().Split('-');
				if (DateTime.Compare(DateTime.Now, new DateTime(Convert.ToInt32(dateRetour[0]),
																Convert.ToInt32(dateRetour[1]),
																Convert.ToInt32(dateRetour[2])
																)) > 0) // Mission terminée
				{
					_statusMission = StatusMissionEnum.EST_TERMINEE;
					lblStatusMission.Text = "Est terminée";
					lblStatusMission.ForeColor = System.Drawing.Color.Red;
				}
				else if (DateTime.Compare(DateTime.Now, new DateTime(Convert.ToInt32(dateDepart[0]),
																	 Convert.ToInt32(dateDepart[1]),
																	 Convert.ToInt32(dateDepart[2])
																	)) > 0 &&
						DateTime.Compare(DateTime.Now, new DateTime(Convert.ToInt32(dateRetour[0]),
																	Convert.ToInt32(dateRetour[1]),
																	Convert.ToInt32(dateRetour[2])
																	)) < 0) // Mission en cours
				{
					_statusMission = StatusMissionEnum.EN_COURS;
					lblStatusMission.Text = "En cours";
					lblStatusMission.ForeColor = System.Drawing.Color.Green;
				}
				else // Mission en préparation
				{
					_statusMission = StatusMissionEnum.EN_PREPARATION;
					lblStatusMission.Text = "En préparation";
					lblStatusMission.ForeColor = System.Drawing.Color.Yellow;
				}

				// Chargement de l'image
				Image img = Image.FromFile(projectPath + "/img/planetes/" + nomPlanete + ".png");
				pictureBox1.Image = img;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erreur lors de la recherche de l'image de la planète! Plus d'informations:\n" + ex.Message);
			}
		}

		public Mission()
		{
			InitializeComponent();
		}

		private void Mission_Load(object sender, EventArgs e)
		{

		}

		private void btnPDF_Click(object sender, EventArgs e)
		{
			try
			{
				// Création du fichier PDF
				string cheminPdf = Path.Combine(projectPath, "RapportMission_" + nomPlanete + "_" + numeroMission + ".pdf"); // Chemin de sauvegarde

				PdfWriter writer = new PdfWriter(cheminPdf); // Permet d'écrire...
				PdfDocument pdf = new PdfDocument(writer); // ...dans ce PDF...
				Document document = new Document(pdf); // ...qui sera stocké dans ce fichier Document

				// Changement de la police d'écriture
				PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
				PdfFont fontBold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

				// Titre
				Paragraph titre = new Paragraph("Mission - " + nomPlanete + " " + numeroMission)
					.SetFont(fontBold) // En gras
					.SetFontSize(24) // La taille de la police
					.SetTextAlignment(TextAlignment.CENTER); // L'alignement du texte
				document.Add(titre); // Ajouter le texte dans le document

				document.Add(new Paragraph("\n")); // Pour ajouter un espace entre le titre et les infos

				// Ajouter les informations avec les données du DataSet...
				DataRow[] lignesMission = dsGlobal.Tables["Mission"].Select($"nomPlanete = '{nomPlanete}' AND numero = {numeroMission}");
				DataRow ligneMissionActuelle = lignesMission[0];

				// Paragraphes avec les informations de la mission
				Paragraph infosDate = new Paragraph("Date de départ: " + ligneMissionActuelle["dateDepart"] + " / Date de retour: " + ligneMissionActuelle["dateRetour"])
					.SetFontSize(12)
					.SetTextAlignment(TextAlignment.LEFT);
				document.Add(infosDate);

				Paragraph infosBudgetObjectif = new Paragraph("Budget: " + ligneMissionActuelle["budget"] + "$G / Objectif: " + ligneMissionActuelle["objectifDatabaz"] + " Databaz")
					.SetFontSize(12)
					.SetTextAlignment(TextAlignment.LEFT);
				document.Add(infosBudgetObjectif);

				Paragraph separateurMembres = new Paragraph("------------------ Membres de la mission ------------------")
						.SetFont(fontBold)
						.SetFontSize(12)
						.SetTextAlignment(TextAlignment.CENTER);
				document.Add(separateurMembres);

				Paragraph infosChef = new Paragraph("Chef de la mission: " + nomChef)
					.SetFont(fontBold)
					.SetFontSize(12)
					.SetTextAlignment(TextAlignment.LEFT);
				document.Add(infosChef);

				document.Add(new Paragraph("\n")); // Pour ajouter un espace entre les infos et le tableau

				// Tableau des membres de la mission
				Table table = new Table(UnitValue.CreatePercentArray(new float[] { 2, 2, 2 }));
				table.SetWidth(UnitValue.CreatePercentValue(100));

				// En-tetes du tableau
				table.AddHeaderCell(new Cell().Add(new Paragraph("Prénom").SetFont(fontBold)));
				table.AddHeaderCell(new Cell().Add(new Paragraph("Nom").SetFont(fontBold)));
				table.AddHeaderCell(new Cell().Add(new Paragraph("Grade/Specialite").SetFont(fontBold)));

				// Remplir le tableau avec les données du DataSet...
				// On fait un select dans Composer pour trouver les membres de cette mission en spécifique
				DataRow[] lignesComposer = dsGlobal.Tables["Composer"].Select($"nomPlanete = '{nomPlanete}' AND numeroMission = {numeroMission}");
				// Mettre le nom/prenom du membre
				foreach (DataRow lignesComposerActuel in lignesComposer)
				{
					DataRow ligneMembre = dsGlobal.Tables["Membre"].Select($"matricule = '{lignesComposerActuel["matriculeMembre"]}'")[0];
					table.AddCell(ligneMembre["prenom"].ToString());
					table.AddCell(ligneMembre["nom"].ToString());

					// Si c'est un militaire, chercher dans la table Militaire, sinon dans la table Membre
					if (ligneMembre["matricule"].ToString().Substring(0, 1) == "M")
					{
						// Pour chaqu'une des lignes de Militaire, si le matricule correspond à celui du Militaire
						// actuel, mettre son grade dans la table
						foreach (DataRow ligneMilitaire in dsGlobal.Tables["Militaire"].Select($"matriculeMembre = '{ligneMembre["matricule"]}'"))
						{
							table.AddCell(new Cell()
								.Add(new Paragraph(ligneMilitaire["grade"].ToString()))
								.SetFontColor(ColorConstants.GREEN) // Changer la couleur pour dire que c'est un militaire
							);
						}
					}
					else
					{
						// Meme chose que dans Militaire, mais c'est pour Civil
						foreach (DataRow ligneCivil in dsGlobal.Tables["Civil"].Select($"matriculeMembre = '{ligneMembre["matricule"].ToString()}'"))
						{
							table.AddCell(new Cell()
								.Add(new Paragraph(ligneCivil["specialite"].ToString()))
								.SetFontColor(ColorConstants.BLUE)
							);
						}
					}
				}

				document.Add(table); // Ajouter le tableau sur le pdf

				// Feuille de route
				Paragraph feuilledeRoute = new Paragraph("\nFeuille de route: \n" + ligneMissionActuelle["feuilleDeRoute"].ToString()).SetFontSize(12);
				document.Add(feuilledeRoute);

				// Journal de bord
				Paragraph jdbTitre = new Paragraph(" -=- Journal de bord -=- ")
					.SetFont(fontBold)
					.SetFontSize(15);
				document.Add(jdbTitre);

				DataRow[] lignesJournalDeBord = dsGlobal.Tables["JournalDeBord"].Select($"nomPlanete = '{nomPlanete}' AND numero = {numeroMission}");
				foreach (DataRow JDBActuel in lignesJournalDeBord)
				{
					Paragraph jdbLigne = new Paragraph($"Le {JDBActuel["dateJ"]} : {JDBActuel["commentaires"]}");
					document.Add(jdbLigne);
				}

				// Dépenses effectuées
				Paragraph deTitre = new Paragraph(" -=- Dépenses Effectuées -=- ")
					.SetFont(fontBold)
					.SetFontSize(15);
				document.Add(deTitre);

				DataRow[] lignesDepenses = dsGlobal.Tables["Depense"].Select($"nomPlanete = '{nomPlanete}' AND numeroMission = {numeroMission}");
				int i = 0;
				foreach (DataRow depensesActuel in lignesDepenses)
				{
					i++;
					Paragraph depLigne = new Paragraph($"{i}) Le {depensesActuel["dateD"]} : {depensesActuel["motif"]} -> {depensesActuel["montant"]}$G");
					document.Add(depLigne);
				}

				// Contacts avec les informateurs
				Paragraph ciTitre = new Paragraph(" -=- Contacts avec les informateurs -=- ")
					.SetFont(fontBold)
					.SetFontSize(15);
				document.Add(ciTitre);

				DataRow[] lignesContacts = dsGlobal.Tables["Contact"].Select($"nomPlanete = '{nomPlanete}' AND numeroMission = {numeroMission}");
				foreach (DataRow contactActuel in lignesContacts)
				{
					DataRow informant = dsGlobal.Tables["Informateur"].Select($"nomCode = '{contactActuel["nomCodeInformateur"]}'")[0];
					DataRow race_informant = dsGlobal.Tables["Espece"].Select($"id = '{informant["idEspeceEnnemi"]}'")[0];
					Paragraph contLigne = new Paragraph($"Le {contactActuel["dateC"]} : Contact avec {informant["nom"]} (de la race {race_informant["nom"]}). " +
														$"Intéraction: ({contactActuel["sommeVersee"]}) {contactActuel["appreciation"]}");
					document.Add(contLigne);
				}

				// Fermeture
				document.Close();
				pdf.Close();
				writer.Close();

				MessageBox.Show("Création du PDF avec succès! Emplacement du fichier: " + cheminPdf);
			}
			catch (Exception  ex)
			{
				MessageBox.Show("Erreur lors de la création du PDF!\nPlus d'informations: " + ex.Message);
			}
		}
	}
}
