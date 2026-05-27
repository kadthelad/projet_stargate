namespace projet_SAE_24
{
    partial class Journal
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
            this.components = new System.ComponentModel.Container();
            this.grpEvenement = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnFIn = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedant = new System.Windows.Forms.Button();
            this.btnDebut = new System.Windows.Forms.Button();
            this.rtbEvenement = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDepenses = new System.Windows.Forms.DataGridView();
            this.lblTotalSommesVerse = new System.Windows.Forms.Label();
            this.lblTotalDepenses = new System.Windows.Forms.Label();
            this.pcbRetour = new System.Windows.Forms.PictureBox();
            this.bsEvenement = new System.Windows.Forms.BindingSource(this.components);
            this.btnPdf = new System.Windows.Forms.Button();
            this.grpEvenement.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRetour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvenement)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEvenement
            // 
            this.grpEvenement.Controls.Add(this.lblDate);
            this.grpEvenement.Controls.Add(this.btnFIn);
            this.grpEvenement.Controls.Add(this.btnSuivant);
            this.grpEvenement.Controls.Add(this.btnPrecedant);
            this.grpEvenement.Controls.Add(this.btnDebut);
            this.grpEvenement.Controls.Add(this.rtbEvenement);
            this.grpEvenement.Location = new System.Drawing.Point(29, 32);
            this.grpEvenement.Name = "grpEvenement";
            this.grpEvenement.Size = new System.Drawing.Size(414, 156);
            this.grpEvenement.TabIndex = 0;
            this.grpEvenement.TabStop = false;
            this.grpEvenement.Text = "Evénement du journal";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 22);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // btnFIn
            // 
            this.btnFIn.Location = new System.Drawing.Point(227, 110);
            this.btnFIn.Name = "btnFIn";
            this.btnFIn.Size = new System.Drawing.Size(30, 30);
            this.btnFIn.TabIndex = 5;
            this.btnFIn.Text = ">>";
            this.btnFIn.UseVisualStyleBackColor = true;
            this.btnFIn.Click += new System.EventHandler(this.btnFIn_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(191, 110);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(30, 30);
            this.btnSuivant.TabIndex = 4;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedant
            // 
            this.btnPrecedant.Location = new System.Drawing.Point(155, 110);
            this.btnPrecedant.Name = "btnPrecedant";
            this.btnPrecedant.Size = new System.Drawing.Size(30, 30);
            this.btnPrecedant.TabIndex = 3;
            this.btnPrecedant.Text = "<";
            this.btnPrecedant.UseVisualStyleBackColor = true;
            this.btnPrecedant.Click += new System.EventHandler(this.btnPrecedant_Click);
            // 
            // btnDebut
            // 
            this.btnDebut.Location = new System.Drawing.Point(119, 110);
            this.btnDebut.Name = "btnDebut";
            this.btnDebut.Size = new System.Drawing.Size(30, 30);
            this.btnDebut.TabIndex = 2;
            this.btnDebut.Text = "<<";
            this.btnDebut.UseVisualStyleBackColor = true;
            this.btnDebut.Click += new System.EventHandler(this.btnDebut_Click);
            // 
            // rtbEvenement
            // 
            this.rtbEvenement.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbEvenement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbEvenement.Enabled = false;
            this.rtbEvenement.Location = new System.Drawing.Point(107, 19);
            this.rtbEvenement.Name = "rtbEvenement";
            this.rtbEvenement.Size = new System.Drawing.Size(301, 85);
            this.rtbEvenement.TabIndex = 1;
            this.rtbEvenement.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvContacts);
            this.groupBox1.Location = new System.Drawing.Point(29, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contacts avec les informateurs";
            // 
            // dgvContacts
            // 
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Location = new System.Drawing.Point(6, 19);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.Size = new System.Drawing.Size(402, 131);
            this.dgvContacts.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDepenses);
            this.groupBox2.Location = new System.Drawing.Point(449, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 318);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dépenses effectuées";
            // 
            // dgvDepenses
            // 
            this.dgvDepenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepenses.Location = new System.Drawing.Point(6, 19);
            this.dgvDepenses.Name = "dgvDepenses";
            this.dgvDepenses.Size = new System.Drawing.Size(482, 298);
            this.dgvDepenses.TabIndex = 0;
            // 
            // lblTotalSommesVerse
            // 
            this.lblTotalSommesVerse.AutoSize = true;
            this.lblTotalSommesVerse.Location = new System.Drawing.Point(163, 375);
            this.lblTotalSommesVerse.Name = "lblTotalSommesVerse";
            this.lblTotalSommesVerse.Size = new System.Drawing.Size(141, 13);
            this.lblTotalSommesVerse.TabIndex = 3;
            this.lblTotalSommesVerse.Text = "Total des sommes versées : ";
            // 
            // lblTotalDepenses
            // 
            this.lblTotalDepenses.AutoSize = true;
            this.lblTotalDepenses.Location = new System.Drawing.Point(542, 375);
            this.lblTotalDepenses.Name = "lblTotalDepenses";
            this.lblTotalDepenses.Size = new System.Drawing.Size(109, 13);
            this.lblTotalDepenses.TabIndex = 4;
            this.lblTotalDepenses.Text = "Total des dépenses : ";
            // 
            // pcbRetour
            // 
            this.pcbRetour.Location = new System.Drawing.Point(873, 371);
            this.pcbRetour.Name = "pcbRetour";
            this.pcbRetour.Size = new System.Drawing.Size(67, 67);
            this.pcbRetour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbRetour.TabIndex = 5;
            this.pcbRetour.TabStop = false;
            this.pcbRetour.Click += new System.EventHandler(this.pcbRetour_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(367, 407);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(187, 31);
            this.btnPdf.TabIndex = 6;
            this.btnPdf.Text = "Editer un PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.pcbRetour);
            this.Controls.Add(this.lblTotalDepenses);
            this.Controls.Add(this.lblTotalSommesVerse);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpEvenement);
            this.Name = "Journal";
            this.Text = "Journal de Bord";
            this.Load += new System.EventHandler(this.Journal_Load);
            this.grpEvenement.ResumeLayout(false);
            this.grpEvenement.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRetour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvenement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEvenement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalSommesVerse;
        private System.Windows.Forms.Label lblTotalDepenses;
        private System.Windows.Forms.PictureBox pcbRetour;
        private System.Windows.Forms.DataGridView dgvDepenses;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.RichTextBox rtbEvenement;
        private System.Windows.Forms.Button btnFIn;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedant;
        private System.Windows.Forms.Button btnDebut;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.BindingSource bsEvenement;
        private System.Windows.Forms.Button btnPdf;
    }
}