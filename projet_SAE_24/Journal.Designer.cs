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
            this.grpEvenement.BackColor = System.Drawing.Color.Firebrick;
            this.grpEvenement.Controls.Add(this.lblDate);
            this.grpEvenement.Controls.Add(this.btnFIn);
            this.grpEvenement.Controls.Add(this.btnSuivant);
            this.grpEvenement.Controls.Add(this.btnPrecedant);
            this.grpEvenement.Controls.Add(this.btnDebut);
            this.grpEvenement.Controls.Add(this.rtbEvenement);
            this.grpEvenement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpEvenement.Location = new System.Drawing.Point(53, 59);
            this.grpEvenement.Margin = new System.Windows.Forms.Padding(6);
            this.grpEvenement.Name = "grpEvenement";
            this.grpEvenement.Padding = new System.Windows.Forms.Padding(6);
            this.grpEvenement.Size = new System.Drawing.Size(759, 288);
            this.grpEvenement.TabIndex = 0;
            this.grpEvenement.TabStop = false;
            this.grpEvenement.Text = "Evénement du journal";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(11, 41);
            this.lblDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 24);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // btnFIn
            // 
            this.btnFIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFIn.Location = new System.Drawing.Point(416, 203);
            this.btnFIn.Margin = new System.Windows.Forms.Padding(6);
            this.btnFIn.Name = "btnFIn";
            this.btnFIn.Size = new System.Drawing.Size(55, 55);
            this.btnFIn.TabIndex = 5;
            this.btnFIn.Text = ">>";
            this.btnFIn.UseVisualStyleBackColor = true;
            this.btnFIn.Click += new System.EventHandler(this.btnFIn_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuivant.Location = new System.Drawing.Point(350, 203);
            this.btnSuivant.Margin = new System.Windows.Forms.Padding(6);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(55, 55);
            this.btnSuivant.TabIndex = 4;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedant
            // 
            this.btnPrecedant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrecedant.Location = new System.Drawing.Point(284, 203);
            this.btnPrecedant.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrecedant.Name = "btnPrecedant";
            this.btnPrecedant.Size = new System.Drawing.Size(55, 55);
            this.btnPrecedant.TabIndex = 3;
            this.btnPrecedant.Text = "<";
            this.btnPrecedant.UseVisualStyleBackColor = true;
            this.btnPrecedant.Click += new System.EventHandler(this.btnPrecedant_Click);
            // 
            // btnDebut
            // 
            this.btnDebut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDebut.Location = new System.Drawing.Point(218, 203);
            this.btnDebut.Margin = new System.Windows.Forms.Padding(6);
            this.btnDebut.Name = "btnDebut";
            this.btnDebut.Size = new System.Drawing.Size(55, 55);
            this.btnDebut.TabIndex = 2;
            this.btnDebut.Text = "<<";
            this.btnDebut.UseVisualStyleBackColor = true;
            this.btnDebut.Click += new System.EventHandler(this.btnDebut_Click);
            // 
            // rtbEvenement
            // 
            this.rtbEvenement.BackColor = System.Drawing.Color.Salmon;
            this.rtbEvenement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbEvenement.Enabled = false;
            this.rtbEvenement.Location = new System.Drawing.Point(141, 35);
            this.rtbEvenement.Margin = new System.Windows.Forms.Padding(6);
            this.rtbEvenement.Name = "rtbEvenement";
            this.rtbEvenement.Size = new System.Drawing.Size(607, 157);
            this.rtbEvenement.TabIndex = 1;
            this.rtbEvenement.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Controls.Add(this.dgvContacts);
            this.groupBox1.Location = new System.Drawing.Point(53, 358);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(759, 288);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contacts avec les informateurs";
            // 
            // dgvContacts
            // 
            this.dgvContacts.BackgroundColor = System.Drawing.Color.Salmon;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Location = new System.Drawing.Point(11, 35);
            this.dgvContacts.Margin = new System.Windows.Forms.Padding(6);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.Size = new System.Drawing.Size(737, 242);
            this.dgvContacts.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Controls.Add(this.dgvDepenses);
            this.groupBox2.Location = new System.Drawing.Point(823, 59);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(896, 587);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dépenses effectuées";
            // 
            // dgvDepenses
            // 
            this.dgvDepenses.BackgroundColor = System.Drawing.Color.Salmon;
            this.dgvDepenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepenses.Location = new System.Drawing.Point(11, 35);
            this.dgvDepenses.Margin = new System.Windows.Forms.Padding(6);
            this.dgvDepenses.Name = "dgvDepenses";
            this.dgvDepenses.ReadOnly = true;
            this.dgvDepenses.Size = new System.Drawing.Size(874, 541);
            this.dgvDepenses.TabIndex = 0;
            // 
            // lblTotalSommesVerse
            // 
            this.lblTotalSommesVerse.AutoSize = true;
            this.lblTotalSommesVerse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSommesVerse.Location = new System.Drawing.Point(187, 685);
            this.lblTotalSommesVerse.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalSommesVerse.Name = "lblTotalSommesVerse";
            this.lblTotalSommesVerse.Size = new System.Drawing.Size(250, 24);
            this.lblTotalSommesVerse.TabIndex = 3;
            this.lblTotalSommesVerse.Text = "Total des sommes versées : ";
            // 
            // lblTotalDepenses
            // 
            this.lblTotalDepenses.AutoSize = true;
            this.lblTotalDepenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDepenses.Location = new System.Drawing.Point(1084, 685);
            this.lblTotalDepenses.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalDepenses.Name = "lblTotalDepenses";
            this.lblTotalDepenses.Size = new System.Drawing.Size(191, 24);
            this.lblTotalDepenses.TabIndex = 4;
            this.lblTotalDepenses.Text = "Total des dépenses : ";
            // 
            // pcbRetour
            // 
            this.pcbRetour.Location = new System.Drawing.Point(1600, 685);
            this.pcbRetour.Margin = new System.Windows.Forms.Padding(6);
            this.pcbRetour.Name = "pcbRetour";
            this.pcbRetour.Size = new System.Drawing.Size(123, 124);
            this.pcbRetour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbRetour.TabIndex = 5;
            this.pcbRetour.TabStop = false;
            this.pcbRetour.Click += new System.EventHandler(this.pcbRetour_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(673, 751);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(6);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(343, 57);
            this.btnPdf.TabIndex = 6;
            this.btnPdf.Text = "Editer un PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1742, 831);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.pcbRetour);
            this.Controls.Add(this.lblTotalDepenses);
            this.Controls.Add(this.lblTotalSommesVerse);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpEvenement);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6);
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