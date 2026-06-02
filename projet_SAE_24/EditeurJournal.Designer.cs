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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblAppreciation = new System.Windows.Forms.Label();
            this.Somme = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabContact = new System.Windows.Forms.TabPage();
            this.ajouterContact = new System.Windows.Forms.GroupBox();
            this.tabDepense = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabEvent = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabContact.SuspendLayout();
            this.ajouterContact.SuspendLayout();
            this.tabDepense.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValiderContact
            // 
            this.btnValiderContact.Location = new System.Drawing.Point(260, 354);
            this.btnValiderContact.Name = "btnValiderContact";
            this.btnValiderContact.Size = new System.Drawing.Size(75, 23);
            this.btnValiderContact.TabIndex = 8;
            this.btnValiderContact.Text = "Valider";
            this.btnValiderContact.UseVisualStyleBackColor = true;
            this.btnValiderContact.Click += new System.EventHandler(this.btnValiderContact_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(178, 354);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // lblInformateur
            // 
            this.lblInformateur.AutoSize = true;
            this.lblInformateur.Location = new System.Drawing.Point(6, 272);
            this.lblInformateur.Name = "lblInformateur";
            this.lblInformateur.Size = new System.Drawing.Size(60, 13);
            this.lblInformateur.TabIndex = 7;
            this.lblInformateur.Text = "Informateur";
            // 
            // cboInformateurs
            // 
            this.cboInformateurs.FormattingEnabled = true;
            this.cboInformateurs.Location = new System.Drawing.Point(97, 272);
            this.cboInformateurs.Name = "cboInformateurs";
            this.cboInformateurs.Size = new System.Drawing.Size(156, 21);
            this.cboInformateurs.TabIndex = 6;
            // 
            // rtbAppreciation
            // 
            this.rtbAppreciation.Location = new System.Drawing.Point(97, 132);
            this.rtbAppreciation.Name = "rtbAppreciation";
            this.rtbAppreciation.Size = new System.Drawing.Size(223, 119);
            this.rtbAppreciation.TabIndex = 5;
            this.rtbAppreciation.Text = "";
            // 
            // txtSomme
            // 
            this.txtSomme.Location = new System.Drawing.Point(93, 81);
            this.txtSomme.Name = "txtSomme";
            this.txtSomme.Size = new System.Drawing.Size(100, 20);
            this.txtSomme.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(93, 41);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // lblAppreciation
            // 
            this.lblAppreciation.AutoSize = true;
            this.lblAppreciation.Location = new System.Drawing.Point(6, 131);
            this.lblAppreciation.Name = "lblAppreciation";
            this.lblAppreciation.Size = new System.Drawing.Size(72, 13);
            this.lblAppreciation.TabIndex = 2;
            this.lblAppreciation.Text = "Appereciation";
            // 
            // Somme
            // 
            this.Somme.AutoSize = true;
            this.Somme.Location = new System.Drawing.Point(6, 84);
            this.Somme.Name = "Somme";
            this.Somme.Size = new System.Drawing.Size(42, 13);
            this.Somme.TabIndex = 1;
            this.Somme.Text = "Somme";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 47);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
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
            this.tabControl1.Size = new System.Drawing.Size(652, 541);
            this.tabControl1.TabIndex = 3;
            // 
            // tabContact
            // 
            this.tabContact.Controls.Add(this.ajouterContact);
            this.tabContact.Location = new System.Drawing.Point(4, 22);
            this.tabContact.Name = "tabContact";
            this.tabContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabContact.Size = new System.Drawing.Size(644, 515);
            this.tabContact.TabIndex = 0;
            this.tabContact.Text = "Nouveau Contact";
            this.tabContact.UseVisualStyleBackColor = true;
            // 
            // ajouterContact
            // 
            this.ajouterContact.Controls.Add(this.btnValiderContact);
            this.ajouterContact.Controls.Add(this.btnAnnuler);
            this.ajouterContact.Controls.Add(this.lblInformateur);
            this.ajouterContact.Controls.Add(this.cboInformateurs);
            this.ajouterContact.Controls.Add(this.rtbAppreciation);
            this.ajouterContact.Controls.Add(this.txtSomme);
            this.ajouterContact.Controls.Add(this.dtpDate);
            this.ajouterContact.Controls.Add(this.lblAppreciation);
            this.ajouterContact.Controls.Add(this.Somme);
            this.ajouterContact.Controls.Add(this.lblDate);
            this.ajouterContact.Location = new System.Drawing.Point(6, 6);
            this.ajouterContact.Name = "ajouterContact";
            this.ajouterContact.Size = new System.Drawing.Size(341, 408);
            this.ajouterContact.TabIndex = 2;
            this.ajouterContact.TabStop = false;
            this.ajouterContact.Text = "groupBox2";
            // 
            // tabDepense
            // 
            this.tabDepense.Controls.Add(this.groupBox1);
            this.tabDepense.Location = new System.Drawing.Point(4, 22);
            this.tabDepense.Name = "tabDepense";
            this.tabDepense.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepense.Size = new System.Drawing.Size(644, 515);
            this.tabDepense.TabIndex = 1;
            this.tabDepense.Text = "Nouvelle dépense";
            this.tabDepense.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 408);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Informateur";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 272);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(97, 132);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(223, 119);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Appereciation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date";
            // 
            // tabEvent
            // 
            this.tabEvent.Location = new System.Drawing.Point(4, 22);
            this.tabEvent.Name = "tabEvent";
            this.tabEvent.Size = new System.Drawing.Size(644, 515);
            this.tabEvent.TabIndex = 2;
            this.tabEvent.Text = "Nouvel Evenement";
            this.tabEvent.UseVisualStyleBackColor = true;
            // 
            // EditeurJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 565);
            this.Controls.Add(this.tabControl1);
            this.Name = "EditeurJournal";
            this.Text = "Modifier de modification";
            this.Load += new System.EventHandler(this.editeurJournal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabContact.ResumeLayout(false);
            this.ajouterContact.ResumeLayout(false);
            this.ajouterContact.PerformLayout();
            this.tabDepense.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDate;
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
        private System.Windows.Forms.GroupBox ajouterContact;
        private System.Windows.Forms.TabPage tabDepense;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabEvent;
    }
}