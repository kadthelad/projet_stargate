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
		DataSet dsGlobal = MesDatas.DsGlobal;
		String projectPath = Application.StartupPath; // trouve où est le /bin/Debug

		// On préfèrerai garder ces données dans le script comme ça on a pas à refaire certaines procédures
		// de volet1.cs
		String nomPlanete = "";
		String numeroMission = "";
		String nomChef = "";

		public Mission(String CNomPlanete, String CNumeroMission,
			String dateDepart, String dateFinEstimee, String CNomChef, String budget)
		{
			InitializeComponent();
			nomPlanete = CNomPlanete;
			numeroMission = CNumeroMission;
			nomChef = CNomChef;

			lblTitre.Text = nomPlanete + " " + numeroMission;
			lblDateDepart.Text = dateDepart;
			lblDateFinEstimee.Text = dateFinEstimee;
			lblNomChef.Text = nomChef;
			lblBudget.Text = "Budget : " + budget + "$G";

			try
			{
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
				for (int i = 0; i < dsGlobal.Tables["Mission"].Rows.Count; i++)
				{
					DataRow ligneActuelle = dsGlobal.Tables["Mission"].Rows[i];
					if (ligneActuelle["nomPlanete"].ToString() == nomPlanete && ligneActuelle["numero"].ToString() == numeroMission)
					{
						// Paragraphes avec les informations de la mission
						Paragraph infosChef = new Paragraph("Chef de la mission: " + nomChef)
							.SetFont(fontBold)
							.SetFontSize(12)
							.SetTextAlignment(TextAlignment.LEFT);

						document.Add(infosChef);
						Paragraph infosDate = new Paragraph("Date de départ: " + ligneActuelle["dateDepart"] + " / Date de retour: " + ligneActuelle["dateRetour"])
							.SetFontSize(12)
							.SetTextAlignment(TextAlignment.LEFT);
						document.Add(infosDate);

						Paragraph infosBudgetObjectif = new Paragraph("Budget: " + ligneActuelle["budget"] + "$G / Objectif: " + ligneActuelle["objectifDatabaz"] + " Databaz")
							.SetFontSize(12)
							.SetTextAlignment(TextAlignment.LEFT);
						document.Add(infosBudgetObjectif);
					}
				}

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
				foreach (DataRow row in dsGlobal.Tables["Composer"].Select("nomPlanete = '" + nomPlanete + "' AND numeroMission = " + numeroMission))
				{
					// Mettre le nom/prenom du membre
					foreach (DataRow ligneMembre in dsGlobal.Tables["Membre"].Select("matricule = '" + row["matriculeMembre"].ToString() + "'"))
					{
						table.AddCell(ligneMembre["prenom"].ToString());
						table.AddCell(ligneMembre["nom"].ToString());
					}
					// Si c'est un militaire, chercher dans la table Militaire, sinon dans la table Membre
					if (row["matriculeMembre"].ToString().Substring(0, 1) == "M")
					{
						// Pour chaqu'une des lignes de Militaire, si le matricule correspond à celui du Militaire
						// actuel, mettre son grade dans la table
						foreach (DataRow ligneMilitaire in dsGlobal.Tables["Militaire"].Select("matriculeMembre = '" + row["matriculeMembre"].ToString() + "'"))
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
						foreach (DataRow ligneCivil in dsGlobal.Tables["Civil"].Select("matriculeMembre = '" + row["matriculeMembre"].ToString() + "'"))
						{
							table.AddCell(new Cell()
								.Add(new Paragraph(ligneCivil["specialite"].ToString()))
								.SetFontColor(ColorConstants.BLUE)
							); 
						}
					}
				}

				document.Add(table); // Ajouter le tableau sur le pdf

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
