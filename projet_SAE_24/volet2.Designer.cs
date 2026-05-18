namespace projet_SAE_24
{
	partial class FormADM
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.grpEtape1 = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.nudBudget = new System.Windows.Forms.NumericUpDown();
			this.nudQteTonnes = new System.Windows.Forms.NumericUpDown();
			this.nudNbPersonnes = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.rtbFeuilleRoute = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dtpDateRetour = new System.Windows.Forms.DateTimePicker();
			this.dtpDateDepart = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cboChefMission = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblNomMission = new System.Windows.Forms.Label();
			this.cboChoixPlanete = new System.Windows.Forms.ComboBox();
			this.btnReinitialiser = new System.Windows.Forms.Button();
			this.btnCreerMission = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabInfos = new System.Windows.Forms.TabPage();
			this.tabDetails = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAjoutObjectif = new System.Windows.Forms.Button();
			this.btnRetirerCapture = new System.Windows.Forms.Button();
			this.rtbObjectifCapture = new System.Windows.Forms.RichTextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.cboRetirerMembre = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.nudNbCapture = new System.Windows.Forms.NumericUpDown();
			this.rtbParticipants = new System.Windows.Forms.RichTextBox();
			this.cboObjectifCapture = new System.Windows.Forms.ComboBox();
			this.label22 = new System.Windows.Forms.Label();
			this.cboAjoutMembre = new System.Windows.Forms.ComboBox();
			this.label24 = new System.Windows.Forms.Label();
			this.lblWarning = new System.Windows.Forms.Label();
			this.grpEtape1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBudget)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudQteTonnes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNbPersonnes)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabInfos.SuspendLayout();
			this.tabDetails.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNbCapture)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Planète :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 11);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 13);
			this.label2.TabIndex = 1;
			// 
			// grpEtape1
			// 
			this.grpEtape1.Controls.Add(this.label12);
			this.grpEtape1.Controls.Add(this.label11);
			this.grpEtape1.Controls.Add(this.label10);
			this.grpEtape1.Controls.Add(this.nudBudget);
			this.grpEtape1.Controls.Add(this.nudQteTonnes);
			this.grpEtape1.Controls.Add(this.nudNbPersonnes);
			this.grpEtape1.Controls.Add(this.label9);
			this.grpEtape1.Controls.Add(this.label8);
			this.grpEtape1.Controls.Add(this.label7);
			this.grpEtape1.Controls.Add(this.rtbFeuilleRoute);
			this.grpEtape1.Controls.Add(this.label6);
			this.grpEtape1.Controls.Add(this.dtpDateRetour);
			this.grpEtape1.Controls.Add(this.dtpDateDepart);
			this.grpEtape1.Controls.Add(this.label5);
			this.grpEtape1.Controls.Add(this.label4);
			this.grpEtape1.Controls.Add(this.cboChefMission);
			this.grpEtape1.Controls.Add(this.label3);
			this.grpEtape1.Controls.Add(this.lblNomMission);
			this.grpEtape1.Controls.Add(this.cboChoixPlanete);
			this.grpEtape1.Controls.Add(this.label1);
			this.grpEtape1.Location = new System.Drawing.Point(5, 7);
			this.grpEtape1.Margin = new System.Windows.Forms.Padding(2);
			this.grpEtape1.Name = "grpEtape1";
			this.grpEtape1.Padding = new System.Windows.Forms.Padding(2);
			this.grpEtape1.Size = new System.Drawing.Size(346, 478);
			this.grpEtape1.TabIndex = 2;
			this.grpEtape1.TabStop = false;
			this.grpEtape1.Text = "1 - Informations de la mission";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(206, 442);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(21, 13);
			this.label12.TabIndex = 20;
			this.label12.Text = "$G";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(176, 412);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(45, 13);
			this.label11.TabIndex = 19;
			this.label11.Text = "tonne(s)";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(176, 381);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(62, 13);
			this.label10.TabIndex = 18;
			this.label10.Text = "personne(s)";
			// 
			// nudBudget
			// 
			this.nudBudget.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudBudget.Location = new System.Drawing.Point(126, 440);
			this.nudBudget.Margin = new System.Windows.Forms.Padding(2);
			this.nudBudget.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.nudBudget.Name = "nudBudget";
			this.nudBudget.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.nudBudget.Size = new System.Drawing.Size(75, 20);
			this.nudBudget.TabIndex = 17;
			// 
			// nudQteTonnes
			// 
			this.nudQteTonnes.Location = new System.Drawing.Point(126, 410);
			this.nudQteTonnes.Margin = new System.Windows.Forms.Padding(2);
			this.nudQteTonnes.Name = "nudQteTonnes";
			this.nudQteTonnes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.nudQteTonnes.Size = new System.Drawing.Size(45, 20);
			this.nudQteTonnes.TabIndex = 16;
			// 
			// nudNbPersonnes
			// 
			this.nudNbPersonnes.Location = new System.Drawing.Point(126, 379);
			this.nudNbPersonnes.Margin = new System.Windows.Forms.Padding(2);
			this.nudNbPersonnes.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
			this.nudNbPersonnes.Name = "nudNbPersonnes";
			this.nudNbPersonnes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.nudNbPersonnes.Size = new System.Drawing.Size(45, 20);
			this.nudNbPersonnes.TabIndex = 15;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(77, 442);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(50, 13);
			this.label9.TabIndex = 14;
			this.label9.Text = "Budget : ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(14, 410);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(108, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "Objectif de DataBaz :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(14, 379);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(113, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Nombre de membres : ";
			// 
			// rtbFeuilleRoute
			// 
			this.rtbFeuilleRoute.Location = new System.Drawing.Point(99, 226);
			this.rtbFeuilleRoute.Margin = new System.Windows.Forms.Padding(2);
			this.rtbFeuilleRoute.Name = "rtbFeuilleRoute";
			this.rtbFeuilleRoute.Size = new System.Drawing.Size(213, 115);
			this.rtbFeuilleRoute.TabIndex = 11;
			this.rtbFeuilleRoute.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(14, 226);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Feuille de route : ";
			// 
			// dtpDateRetour
			// 
			this.dtpDateRetour.Location = new System.Drawing.Point(97, 170);
			this.dtpDateRetour.Margin = new System.Windows.Forms.Padding(2);
			this.dtpDateRetour.Name = "dtpDateRetour";
			this.dtpDateRetour.Size = new System.Drawing.Size(180, 20);
			this.dtpDateRetour.TabIndex = 9;
			// 
			// dtpDateDepart
			// 
			this.dtpDateDepart.Location = new System.Drawing.Point(97, 138);
			this.dtpDateDepart.Margin = new System.Windows.Forms.Padding(2);
			this.dtpDateDepart.Name = "dtpDateDepart";
			this.dtpDateDepart.Size = new System.Drawing.Size(180, 20);
			this.dtpDateDepart.TabIndex = 8;
			this.dtpDateDepart.ValueChanged += new System.EventHandler(this.dtpDateDepart_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 170);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Date de retour : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 138);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Date de départ : ";
			// 
			// cboChefMission
			// 
			this.cboChefMission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboChefMission.FormattingEnabled = true;
			this.cboChefMission.Location = new System.Drawing.Point(137, 93);
			this.cboChefMission.Margin = new System.Windows.Forms.Padding(2);
			this.cboChefMission.Name = "cboChefMission";
			this.cboChefMission.Size = new System.Drawing.Size(194, 21);
			this.cboChefMission.TabIndex = 5;
			this.cboChefMission.SelectedIndexChanged += new System.EventHandler(this.cboChefMission_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 95);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Choix du chef de mission :";
			// 
			// lblNomMission
			// 
			this.lblNomMission.AutoSize = true;
			this.lblNomMission.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomMission.Location = new System.Drawing.Point(12, 57);
			this.lblNomMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNomMission.Name = "lblNomMission";
			this.lblNomMission.Size = new System.Drawing.Size(173, 22);
			this.lblNomMission.TabIndex = 3;
			this.lblNomMission.Text = "Nom de la mission: ";
			// 
			// cboChoixPlanete
			// 
			this.cboChoixPlanete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboChoixPlanete.FormattingEnabled = true;
			this.cboChoixPlanete.Location = new System.Drawing.Point(62, 25);
			this.cboChoixPlanete.Margin = new System.Windows.Forms.Padding(2);
			this.cboChoixPlanete.Name = "cboChoixPlanete";
			this.cboChoixPlanete.Size = new System.Drawing.Size(159, 21);
			this.cboChoixPlanete.TabIndex = 1;
			this.cboChoixPlanete.SelectedIndexChanged += new System.EventHandler(this.cboChoixPlanete_SelectedIndexChanged);
			this.cboChoixPlanete.SelectionChangeCommitted += new System.EventHandler(this.cboChoixPlanete_SelectionChangeCommitted);
			// 
			// btnReinitialiser
			// 
			this.btnReinitialiser.BackColor = System.Drawing.Color.IndianRed;
			this.btnReinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReinitialiser.Location = new System.Drawing.Point(18, 540);
			this.btnReinitialiser.Margin = new System.Windows.Forms.Padding(2);
			this.btnReinitialiser.Name = "btnReinitialiser";
			this.btnReinitialiser.Size = new System.Drawing.Size(103, 32);
			this.btnReinitialiser.TabIndex = 3;
			this.btnReinitialiser.Text = "Réinitialiser";
			this.btnReinitialiser.UseVisualStyleBackColor = false;
			this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
			this.btnReinitialiser.MouseLeave += new System.EventHandler(this.btnReinitialiser_MouseLeave);
			// 
			// btnCreerMission
			// 
			this.btnCreerMission.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnCreerMission.Enabled = false;
			this.btnCreerMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreerMission.Location = new System.Drawing.Point(258, 540);
			this.btnCreerMission.Margin = new System.Windows.Forms.Padding(2);
			this.btnCreerMission.Name = "btnCreerMission";
			this.btnCreerMission.Size = new System.Drawing.Size(106, 32);
			this.btnCreerMission.TabIndex = 4;
			this.btnCreerMission.Text = "Créer Mission";
			this.btnCreerMission.UseVisualStyleBackColor = false;
			this.btnCreerMission.Click += new System.EventHandler(this.btnCreerMission_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabInfos);
			this.tabControl1.Controls.Add(this.tabDetails);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(363, 516);
			this.tabControl1.TabIndex = 21;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabInfos
			// 
			this.tabInfos.Controls.Add(this.grpEtape1);
			this.tabInfos.Location = new System.Drawing.Point(4, 22);
			this.tabInfos.Name = "tabInfos";
			this.tabInfos.Padding = new System.Windows.Forms.Padding(3);
			this.tabInfos.Size = new System.Drawing.Size(355, 490);
			this.tabInfos.TabIndex = 0;
			this.tabInfos.Text = "1 -Informations";
			this.tabInfos.UseVisualStyleBackColor = true;
			// 
			// tabDetails
			// 
			this.tabDetails.Controls.Add(this.groupBox1);
			this.tabDetails.Location = new System.Drawing.Point(4, 22);
			this.tabDetails.Name = "tabDetails";
			this.tabDetails.Padding = new System.Windows.Forms.Padding(3);
			this.tabDetails.Size = new System.Drawing.Size(355, 490);
			this.tabDetails.TabIndex = 1;
			this.tabDetails.Text = "2 - Détails";
			this.tabDetails.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAjoutObjectif);
			this.groupBox1.Controls.Add(this.btnRetirerCapture);
			this.groupBox1.Controls.Add(this.rtbObjectifCapture);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.cboRetirerMembre);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.nudNbCapture);
			this.groupBox1.Controls.Add(this.rtbParticipants);
			this.groupBox1.Controls.Add(this.cboObjectifCapture);
			this.groupBox1.Controls.Add(this.label22);
			this.groupBox1.Controls.Add(this.cboAjoutMembre);
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.Location = new System.Drawing.Point(4, 6);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(346, 478);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "2 - Détails de la mission";
			// 
			// btnAjoutObjectif
			// 
			this.btnAjoutObjectif.Enabled = false;
			this.btnAjoutObjectif.ForeColor = System.Drawing.Color.Blue;
			this.btnAjoutObjectif.Location = new System.Drawing.Point(177, 450);
			this.btnAjoutObjectif.Name = "btnAjoutObjectif";
			this.btnAjoutObjectif.Size = new System.Drawing.Size(154, 23);
			this.btnAjoutObjectif.TabIndex = 28;
			this.btnAjoutObjectif.Text = "Ajouter objectif";
			this.btnAjoutObjectif.UseVisualStyleBackColor = true;
			this.btnAjoutObjectif.Click += new System.EventHandler(this.btnAjoutObjectif_Click);
			// 
			// btnRetirerCapture
			// 
			this.btnRetirerCapture.Enabled = false;
			this.btnRetirerCapture.ForeColor = System.Drawing.Color.Red;
			this.btnRetirerCapture.Location = new System.Drawing.Point(14, 450);
			this.btnRetirerCapture.Name = "btnRetirerCapture";
			this.btnRetirerCapture.Size = new System.Drawing.Size(153, 23);
			this.btnRetirerCapture.TabIndex = 27;
			this.btnRetirerCapture.Text = "Retirer le dernier objectif";
			this.btnRetirerCapture.UseVisualStyleBackColor = true;
			this.btnRetirerCapture.Click += new System.EventHandler(this.btnRetirerCapture_Click);
			// 
			// rtbObjectifCapture
			// 
			this.rtbObjectifCapture.Location = new System.Drawing.Point(14, 328);
			this.rtbObjectifCapture.Margin = new System.Windows.Forms.Padding(2);
			this.rtbObjectifCapture.Name = "rtbObjectifCapture";
			this.rtbObjectifCapture.ReadOnly = true;
			this.rtbObjectifCapture.Size = new System.Drawing.Size(317, 120);
			this.rtbObjectifCapture.TabIndex = 26;
			this.rtbObjectifCapture.Text = "";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(77, 267);
			this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(173, 22);
			this.label15.TabIndex = 25;
			this.label15.Text = "Objectifs de capture";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(49, 22);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(219, 22);
			this.label14.TabIndex = 24;
			this.label14.Text = "Participants de la mission";
			// 
			// cboRetirerMembre
			// 
			this.cboRetirerMembre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboRetirerMembre.Enabled = false;
			this.cboRetirerMembre.FormattingEnabled = true;
			this.cboRetirerMembre.Location = new System.Drawing.Point(123, 90);
			this.cboRetirerMembre.Margin = new System.Windows.Forms.Padding(2);
			this.cboRetirerMembre.Name = "cboRetirerMembre";
			this.cboRetirerMembre.Size = new System.Drawing.Size(205, 21);
			this.cboRetirerMembre.TabIndex = 23;
			this.cboRetirerMembre.SelectionChangeCommitted += new System.EventHandler(this.cboRetirerMembre_SelectionChangeCommitted);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(11, 93);
			this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(102, 13);
			this.label13.TabIndex = 22;
			this.label13.Text = "Retirer un membre : ";
			// 
			// nudNbCapture
			// 
			this.nudNbCapture.Enabled = false;
			this.nudNbCapture.Location = new System.Drawing.Point(276, 303);
			this.nudNbCapture.Name = "nudNbCapture";
			this.nudNbCapture.Size = new System.Drawing.Size(52, 20);
			this.nudNbCapture.TabIndex = 21;
			// 
			// rtbParticipants
			// 
			this.rtbParticipants.Location = new System.Drawing.Point(14, 115);
			this.rtbParticipants.Margin = new System.Windows.Forms.Padding(2);
			this.rtbParticipants.Name = "rtbParticipants";
			this.rtbParticipants.ReadOnly = true;
			this.rtbParticipants.Size = new System.Drawing.Size(317, 140);
			this.rtbParticipants.TabIndex = 11;
			this.rtbParticipants.Text = "";
			// 
			// cboObjectifCapture
			// 
			this.cboObjectifCapture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboObjectifCapture.Enabled = false;
			this.cboObjectifCapture.FormattingEnabled = true;
			this.cboObjectifCapture.Location = new System.Drawing.Point(118, 302);
			this.cboObjectifCapture.Margin = new System.Windows.Forms.Padding(2);
			this.cboObjectifCapture.Name = "cboObjectifCapture";
			this.cboObjectifCapture.Size = new System.Drawing.Size(150, 21);
			this.cboObjectifCapture.TabIndex = 5;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(8, 305);
			this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(106, 13);
			this.label22.TabIndex = 4;
			this.label22.Text = "Objectif de capture : ";
			// 
			// cboAjoutMembre
			// 
			this.cboAjoutMembre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboAjoutMembre.Enabled = false;
			this.cboAjoutMembre.FormattingEnabled = true;
			this.cboAjoutMembre.Location = new System.Drawing.Point(123, 57);
			this.cboAjoutMembre.Margin = new System.Windows.Forms.Padding(2);
			this.cboAjoutMembre.Name = "cboAjoutMembre";
			this.cboAjoutMembre.Size = new System.Drawing.Size(205, 21);
			this.cboAjoutMembre.TabIndex = 1;
			this.cboAjoutMembre.SelectionChangeCommitted += new System.EventHandler(this.cboAjoutMembre_SelectionChangeCommitted);
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(11, 60);
			this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(104, 13);
			this.label24.TabIndex = 0;
			this.label24.Text = "Ajouter un membre : ";
			// 
			// lblWarning
			// 
			this.lblWarning.AutoSize = true;
			this.lblWarning.ForeColor = System.Drawing.Color.Red;
			this.lblWarning.Location = new System.Drawing.Point(9, 527);
			this.lblWarning.Name = "lblWarning";
			this.lblWarning.Size = new System.Drawing.Size(178, 13);
			this.lblWarning.TabIndex = 22;
			this.lblWarning.Text = "Attention! Cela va TOUT reinitialiser!";
			this.lblWarning.Visible = false;
			// 
			// FormADM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 583);
			this.Controls.Add(this.lblWarning);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.btnCreerMission);
			this.Controls.Add(this.btnReinitialiser);
			this.Controls.Add(this.label2);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormADM";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Missions - Ajout d\'une mission";
			this.Load += new System.EventHandler(this.FormADM_Load);
			this.grpEtape1.ResumeLayout(false);
			this.grpEtape1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBudget)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudQteTonnes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudNbPersonnes)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabInfos.ResumeLayout(false);
			this.tabDetails.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNbCapture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox grpEtape1;
		private System.Windows.Forms.Label lblNomMission;
		private System.Windows.Forms.ComboBox cboChoixPlanete;
		private System.Windows.Forms.Button btnReinitialiser;
		private System.Windows.Forms.Button btnCreerMission;
		private System.Windows.Forms.ComboBox cboChefMission;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RichTextBox rtbFeuilleRoute;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtpDateRetour;
		private System.Windows.Forms.DateTimePicker dtpDateDepart;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown nudBudget;
		private System.Windows.Forms.NumericUpDown nudQteTonnes;
		private System.Windows.Forms.NumericUpDown nudNbPersonnes;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabInfos;
		private System.Windows.Forms.TabPage tabDetails;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox rtbParticipants;
		private System.Windows.Forms.ComboBox cboObjectifCapture;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.ComboBox cboAjoutMembre;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox cboRetirerMembre;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.NumericUpDown nudNbCapture;
		private System.Windows.Forms.RichTextBox rtbObjectifCapture;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label lblWarning;
		private System.Windows.Forms.Button btnRetirerCapture;
		private System.Windows.Forms.Button btnAjoutObjectif;
	}
}