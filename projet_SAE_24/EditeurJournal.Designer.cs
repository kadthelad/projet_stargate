namespace projet_SAE_24
{
    partial class EditeurJournal
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
            this.btnValiderContact = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblInformateur = new System.Windows.Forms.Label();
            this.cboInformateurs = new System.Windows.Forms.ComboBox();
            this.rtbAppreciation = new System.Windows.Forms.RichTextBox();
            this.txtSomme = new System.Windows.Forms.TextBox();
            this.dtpDateContact = new System.Windows.Forms.DateTimePicker();
            this.lblAppreciation = new System.Windows.Forms.Label();
            this.Somme = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabContact = new System.Windows.Forms.TabPage();
            this.grpAjouterContact = new System.Windows.Forms.GroupBox();
            this.lblDeviseContact = new System.Windows.Forms.Label();
            this.tabDepense = new System.Windows.Forms.TabPage();
            this.grpDepense = new System.Windows.Forms.GroupBox();
            this.lblDeviseDepense = new System.Windows.Forms.Label();
            this.btnValiderDepense = new System.Windows.Forms.Button();
            this.btnAnnulerDepense = new System.Windows.Forms.Button();
            this.lblTypeDepense = new System.Windows.Forms.Label();
            this.cboTypeDepense = new System.Windows.Forms.ComboBox();
            this.rtbMotifDepense = new System.Windows.Forms.RichTextBox();
            this.txtMontantDepense = new System.Windows.Forms.TextBox();
            this.dtpDateDepense = new System.Windows.Forms.DateTimePicker();
            this.lblMotifDepense = new System.Windows.Forms.Label();
            this.lblMontantDepense = new System.Windows.Forms.Label();
            this.lblDateDepense = new System.Windows.Forms.Label();
            this.tabEvent = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnValiderEvent = new System.Windows.Forms.Button();
            this.btnAnnulerEvent = new System.Windows.Forms.Button();
            this.rtbCommentaireEvent = new System.Windows.Forms.RichTextBox();
            this.dtpEvent = new System.Windows.Forms.DateTimePicker();
            this.lblCommentaireEvent = new System.Windows.Forms.Label();
            this.lblDateEvent = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabContact.SuspendLayout();
            this.grpAjouterContact.SuspendLayout();
            this.tabDepense.SuspendLayout();
            this.grpDepense.SuspendLayout();
            this.tabEvent.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValiderContact
            // 
            this.btnValiderContact.Location = new System.Drawing.Point(324, 354);
            this.btnValiderContact.Name = "btnValiderContact";
            this.btnValiderContact.Size = new System.Drawing.Size(100, 40);
            this.btnValiderContact.TabIndex = 8;
            this.btnValiderContact.Text = "Valider";
            this.btnValiderContact.UseVisualStyleBackColor = true;
            this.btnValiderContact.Click += new System.EventHandler(this.btnValiderContact_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(221, 354);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 40);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.annulerModif_Click);
            // 
            // lblInformateur
            // 
            this.lblInformateur.AutoSize = true;
            this.lblInformateur.Location = new System.Drawing.Point(6, 277);
            this.lblInformateur.Name = "lblInformateur";
            this.lblInformateur.Size = new System.Drawing.Size(104, 24);
            this.lblInformateur.TabIndex = 7;
            this.lblInformateur.Text = "Informateur";
            // 
            // cboInformateurs
            // 
            this.cboInformateurs.FormattingEnabled = true;
            this.cboInformateurs.Location = new System.Drawing.Point(139, 277);
            this.cboInformateurs.Name = "cboInformateurs";
            this.cboInformateurs.Size = new System.Drawing.Size(223, 32);
            this.cboInformateurs.TabIndex = 6;
            // 
            // rtbAppreciation
            // 
            this.rtbAppreciation.Location = new System.Drawing.Point(139, 136);
            this.rtbAppreciation.Name = "rtbAppreciation";
            this.rtbAppreciation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbAppreciation.Size = new System.Drawing.Size(223, 119);
            this.rtbAppreciation.TabIndex = 5;
            this.rtbAppreciation.Text = "";
            // 
            // txtSomme
            // 
            this.txtSomme.Location = new System.Drawing.Point(139, 89);
            this.txtSomme.Name = "txtSomme";
            this.txtSomme.Size = new System.Drawing.Size(100, 29);
            this.txtSomme.TabIndex = 4;
            this.txtSomme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSomme_KeyPress);
            // 
            // dtpDateContact
            // 
            this.dtpDateContact.Location = new System.Drawing.Point(139, 47);
            this.dtpDateContact.Name = "dtpDateContact";
            this.dtpDateContact.Size = new System.Drawing.Size(200, 29);
            this.dtpDateContact.TabIndex = 3;
            // 
            // lblAppreciation
            // 
            this.lblAppreciation.AutoSize = true;
            this.lblAppreciation.Location = new System.Drawing.Point(6, 136);
            this.lblAppreciation.Name = "lblAppreciation";
            this.lblAppreciation.Size = new System.Drawing.Size(127, 24);
            this.lblAppreciation.TabIndex = 2;
            this.lblAppreciation.Text = "Appereciation";
            // 
            // Somme
            // 
            this.Somme.AutoSize = true;
            this.Somme.Location = new System.Drawing.Point(6, 89);
            this.Somme.Name = "Somme";
            this.Somme.Size = new System.Drawing.Size(76, 24);
            this.Somme.TabIndex = 1;
            this.Somme.Text = "Somme";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 47);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 24);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabContact);
            this.tabControl1.Controls.Add(this.tabDepense);
            this.tabControl1.Controls.Add(this.tabEvent);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(449, 438);
            this.tabControl1.TabIndex = 3;
            // 
            // tabContact
            // 
            this.tabContact.Controls.Add(this.grpAjouterContact);
            this.tabContact.Location = new System.Drawing.Point(4, 22);
            this.tabContact.Name = "tabContact";
            this.tabContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabContact.Size = new System.Drawing.Size(441, 412);
            this.tabContact.TabIndex = 0;
            this.tabContact.Text = "Nouveau Contact";
            this.tabContact.UseVisualStyleBackColor = true;
            // 
            // grpAjouterContact
            // 
            this.grpAjouterContact.Controls.Add(this.lblDeviseContact);
            this.grpAjouterContact.Controls.Add(this.btnValiderContact);
            this.grpAjouterContact.Controls.Add(this.btnAnnuler);
            this.grpAjouterContact.Controls.Add(this.lblInformateur);
            this.grpAjouterContact.Controls.Add(this.cboInformateurs);
            this.grpAjouterContact.Controls.Add(this.rtbAppreciation);
            this.grpAjouterContact.Controls.Add(this.txtSomme);
            this.grpAjouterContact.Controls.Add(this.dtpDateContact);
            this.grpAjouterContact.Controls.Add(this.lblAppreciation);
            this.grpAjouterContact.Controls.Add(this.Somme);
            this.grpAjouterContact.Controls.Add(this.lblDate);
            this.grpAjouterContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAjouterContact.Location = new System.Drawing.Point(6, 6);
            this.grpAjouterContact.Name = "grpAjouterContact";
            this.grpAjouterContact.Size = new System.Drawing.Size(430, 400);
            this.grpAjouterContact.TabIndex = 2;
            this.grpAjouterContact.TabStop = false;
            // 
            // lblDeviseContact
            // 
            this.lblDeviseContact.AutoSize = true;
            this.lblDeviseContact.Location = new System.Drawing.Point(245, 92);
            this.lblDeviseContact.Name = "lblDeviseContact";
            this.lblDeviseContact.Size = new System.Drawing.Size(34, 24);
            this.lblDeviseContact.TabIndex = 9;
            this.lblDeviseContact.Text = "$G";
            // 
            // tabDepense
            // 
            this.tabDepense.Controls.Add(this.grpDepense);
            this.tabDepense.Location = new System.Drawing.Point(4, 22);
            this.tabDepense.Name = "tabDepense";
            this.tabDepense.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepense.Size = new System.Drawing.Size(369, 412);
            this.tabDepense.TabIndex = 1;
            this.tabDepense.Text = "Nouvelle dépense";
            this.tabDepense.UseVisualStyleBackColor = true;
            // 
            // grpDepense
            // 
            this.grpDepense.Controls.Add(this.lblDeviseDepense);
            this.grpDepense.Controls.Add(this.btnValiderDepense);
            this.grpDepense.Controls.Add(this.btnAnnulerDepense);
            this.grpDepense.Controls.Add(this.lblTypeDepense);
            this.grpDepense.Controls.Add(this.cboTypeDepense);
            this.grpDepense.Controls.Add(this.rtbMotifDepense);
            this.grpDepense.Controls.Add(this.txtMontantDepense);
            this.grpDepense.Controls.Add(this.dtpDateDepense);
            this.grpDepense.Controls.Add(this.lblMotifDepense);
            this.grpDepense.Controls.Add(this.lblMontantDepense);
            this.grpDepense.Controls.Add(this.lblDateDepense);
            this.grpDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDepense.Location = new System.Drawing.Point(6, 6);
            this.grpDepense.Name = "grpDepense";
            this.grpDepense.Size = new System.Drawing.Size(430, 400);
            this.grpDepense.TabIndex = 3;
            this.grpDepense.TabStop = false;
            // 
            // lblDeviseDepense
            // 
            this.lblDeviseDepense.AutoSize = true;
            this.lblDeviseDepense.Location = new System.Drawing.Point(199, 87);
            this.lblDeviseDepense.Name = "lblDeviseDepense";
            this.lblDeviseDepense.Size = new System.Drawing.Size(34, 24);
            this.lblDeviseDepense.TabIndex = 10;
            this.lblDeviseDepense.Text = "$G";
            // 
            // btnValiderDepense
            // 
            this.btnValiderDepense.Location = new System.Drawing.Point(324, 354);
            this.btnValiderDepense.Name = "btnValiderDepense";
            this.btnValiderDepense.Size = new System.Drawing.Size(100, 40);
            this.btnValiderDepense.TabIndex = 8;
            this.btnValiderDepense.Text = "Valider";
            this.btnValiderDepense.UseVisualStyleBackColor = true;
            this.btnValiderDepense.Click += new System.EventHandler(this.btnValiderDepense_Click);
            // 
            // btnAnnulerDepense
            // 
            this.btnAnnulerDepense.Location = new System.Drawing.Point(219, 354);
            this.btnAnnulerDepense.Name = "btnAnnulerDepense";
            this.btnAnnulerDepense.Size = new System.Drawing.Size(100, 40);
            this.btnAnnulerDepense.TabIndex = 8;
            this.btnAnnulerDepense.Text = "Annuler";
            this.btnAnnulerDepense.UseVisualStyleBackColor = true;
            this.btnAnnulerDepense.Click += new System.EventHandler(this.annulerModif_Click);
            // 
            // lblTypeDepense
            // 
            this.lblTypeDepense.AutoSize = true;
            this.lblTypeDepense.Location = new System.Drawing.Point(6, 274);
            this.lblTypeDepense.Name = "lblTypeDepense";
            this.lblTypeDepense.Size = new System.Drawing.Size(160, 24);
            this.lblTypeDepense.TabIndex = 7;
            this.lblTypeDepense.Text = "Type de dépense";
            // 
            // cboTypeDepense
            // 
            this.cboTypeDepense.FormattingEnabled = true;
            this.cboTypeDepense.Location = new System.Drawing.Point(172, 274);
            this.cboTypeDepense.Name = "cboTypeDepense";
            this.cboTypeDepense.Size = new System.Drawing.Size(156, 32);
            this.cboTypeDepense.TabIndex = 6;
            // 
            // rtbMotifDepense
            // 
            this.rtbMotifDepense.Location = new System.Drawing.Point(97, 134);
            this.rtbMotifDepense.Name = "rtbMotifDepense";
            this.rtbMotifDepense.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbMotifDepense.Size = new System.Drawing.Size(223, 119);
            this.rtbMotifDepense.TabIndex = 5;
            this.rtbMotifDepense.Text = "";
            // 
            // txtMontantDepense
            // 
            this.txtMontantDepense.Location = new System.Drawing.Point(93, 83);
            this.txtMontantDepense.Name = "txtMontantDepense";
            this.txtMontantDepense.Size = new System.Drawing.Size(100, 29);
            this.txtMontantDepense.TabIndex = 4;
            // 
            // dtpDateDepense
            // 
            this.dtpDateDepense.Location = new System.Drawing.Point(93, 43);
            this.dtpDateDepense.Name = "dtpDateDepense";
            this.dtpDateDepense.Size = new System.Drawing.Size(200, 29);
            this.dtpDateDepense.TabIndex = 3;
            // 
            // lblMotifDepense
            // 
            this.lblMotifDepense.AutoSize = true;
            this.lblMotifDepense.Location = new System.Drawing.Point(6, 133);
            this.lblMotifDepense.Name = "lblMotifDepense";
            this.lblMotifDepense.Size = new System.Drawing.Size(49, 24);
            this.lblMotifDepense.TabIndex = 2;
            this.lblMotifDepense.Text = "Motif";
            // 
            // lblMontantDepense
            // 
            this.lblMontantDepense.AutoSize = true;
            this.lblMontantDepense.Location = new System.Drawing.Point(6, 86);
            this.lblMontantDepense.Name = "lblMontantDepense";
            this.lblMontantDepense.Size = new System.Drawing.Size(77, 24);
            this.lblMontantDepense.TabIndex = 1;
            this.lblMontantDepense.Text = "Montant";
            // 
            // lblDateDepense
            // 
            this.lblDateDepense.AutoSize = true;
            this.lblDateDepense.Location = new System.Drawing.Point(6, 49);
            this.lblDateDepense.Name = "lblDateDepense";
            this.lblDateDepense.Size = new System.Drawing.Size(48, 24);
            this.lblDateDepense.TabIndex = 0;
            this.lblDateDepense.Text = "Date";
            // 
            // tabEvent
            // 
            this.tabEvent.Controls.Add(this.groupBox2);
            this.tabEvent.Location = new System.Drawing.Point(4, 22);
            this.tabEvent.Name = "tabEvent";
            this.tabEvent.Size = new System.Drawing.Size(369, 412);
            this.tabEvent.TabIndex = 2;
            this.tabEvent.Text = "Nouvel Evenement";
            this.tabEvent.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnValiderEvent);
            this.groupBox2.Controls.Add(this.btnAnnulerEvent);
            this.groupBox2.Controls.Add(this.rtbCommentaireEvent);
            this.groupBox2.Controls.Add(this.dtpEvent);
            this.groupBox2.Controls.Add(this.lblCommentaireEvent);
            this.groupBox2.Controls.Add(this.lblDateEvent);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 400);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnValiderEvent
            // 
            this.btnValiderEvent.Location = new System.Drawing.Point(324, 354);
            this.btnValiderEvent.Name = "btnValiderEvent";
            this.btnValiderEvent.Size = new System.Drawing.Size(100, 40);
            this.btnValiderEvent.TabIndex = 8;
            this.btnValiderEvent.Text = "Valider";
            this.btnValiderEvent.UseVisualStyleBackColor = true;
            this.btnValiderEvent.Click += new System.EventHandler(this.btnValiderEvent_Click);
            // 
            // btnAnnulerEvent
            // 
            this.btnAnnulerEvent.Location = new System.Drawing.Point(218, 354);
            this.btnAnnulerEvent.Name = "btnAnnulerEvent";
            this.btnAnnulerEvent.Size = new System.Drawing.Size(100, 40);
            this.btnAnnulerEvent.TabIndex = 8;
            this.btnAnnulerEvent.Text = "Annuler";
            this.btnAnnulerEvent.UseVisualStyleBackColor = true;
            this.btnAnnulerEvent.Click += new System.EventHandler(this.annulerModif_Click);
            // 
            // rtbCommentaireEvent
            // 
            this.rtbCommentaireEvent.Location = new System.Drawing.Point(169, 78);
            this.rtbCommentaireEvent.Name = "rtbCommentaireEvent";
            this.rtbCommentaireEvent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbCommentaireEvent.Size = new System.Drawing.Size(255, 250);
            this.rtbCommentaireEvent.TabIndex = 5;
            this.rtbCommentaireEvent.Text = "";
            // 
            // dtpEvent
            // 
            this.dtpEvent.Location = new System.Drawing.Point(169, 43);
            this.dtpEvent.Name = "dtpEvent";
            this.dtpEvent.Size = new System.Drawing.Size(200, 29);
            this.dtpEvent.TabIndex = 3;
            // 
            // lblCommentaireEvent
            // 
            this.lblCommentaireEvent.AutoSize = true;
            this.lblCommentaireEvent.Location = new System.Drawing.Point(6, 81);
            this.lblCommentaireEvent.Name = "lblCommentaireEvent";
            this.lblCommentaireEvent.Size = new System.Drawing.Size(123, 24);
            this.lblCommentaireEvent.TabIndex = 2;
            this.lblCommentaireEvent.Text = "Commentaire";
            // 
            // lblDateEvent
            // 
            this.lblDateEvent.AutoSize = true;
            this.lblDateEvent.Location = new System.Drawing.Point(6, 47);
            this.lblDateEvent.Name = "lblDateEvent";
            this.lblDateEvent.Size = new System.Drawing.Size(48, 24);
            this.lblDateEvent.TabIndex = 0;
            this.lblDateEvent.Text = "Date";
            // 
            // EditeurJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 454);
            this.Controls.Add(this.tabControl1);
            this.Name = "EditeurJournal";
            this.Text = "Modifier de modification";
            this.Load += new System.EventHandler(this.editeurJournal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabContact.ResumeLayout(false);
            this.grpAjouterContact.ResumeLayout(false);
            this.grpAjouterContact.PerformLayout();
            this.tabDepense.ResumeLayout(false);
            this.grpDepense.ResumeLayout(false);
            this.grpDepense.PerformLayout();
            this.tabEvent.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDateContact;
        private System.Windows.Forms.Label lblAppreciation;
        private System.Windows.Forms.Label Somme;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblInformateur;
        private System.Windows.Forms.ComboBox cboInformateurs;
        private System.Windows.Forms.RichTextBox rtbAppreciation;
        private System.Windows.Forms.TextBox txtSomme;
        private System.Windows.Forms.Button btnValiderContact;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabContact;
        private System.Windows.Forms.GroupBox grpAjouterContact;
        private System.Windows.Forms.TabPage tabDepense;
        private System.Windows.Forms.GroupBox grpDepense;
        private System.Windows.Forms.Button btnValiderDepense;
        private System.Windows.Forms.Button btnAnnulerDepense;
        private System.Windows.Forms.RichTextBox rtbMotifDepense;
        private System.Windows.Forms.TextBox txtMontantDepense;
        private System.Windows.Forms.DateTimePicker dtpDateDepense;
        private System.Windows.Forms.Label lblMotifDepense;
        private System.Windows.Forms.Label lblMontantDepense;
        private System.Windows.Forms.Label lblDateDepense;
        private System.Windows.Forms.TabPage tabEvent;
        private System.Windows.Forms.Label lblTypeDepense;
        private System.Windows.Forms.ComboBox cboTypeDepense;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnValiderEvent;
        private System.Windows.Forms.Button btnAnnulerEvent;
        private System.Windows.Forms.RichTextBox rtbCommentaireEvent;
        private System.Windows.Forms.DateTimePicker dtpEvent;
        private System.Windows.Forms.Label lblCommentaireEvent;
        private System.Windows.Forms.Label lblDateEvent;
        private System.Windows.Forms.Label lblDeviseContact;
        private System.Windows.Forms.Label lblDeviseDepense;
    }
}