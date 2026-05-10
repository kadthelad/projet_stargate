namespace projet_SAE_24
{
    partial class filtre
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
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cboCouleur = new System.Windows.Forms.ComboBox();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.rdbAllie = new System.Windows.Forms.RadioButton();
            this.rdbEnnemi = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(33, 36);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(55, 19);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(121, 37);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(164, 20);
            this.txtNom.TabIndex = 1;
            // 
            // cboCouleur
            // 
            this.cboCouleur.FormattingEnabled = true;
            this.cboCouleur.Location = new System.Drawing.Point(121, 104);
            this.cboCouleur.Name = "cboCouleur";
            this.cboCouleur.Size = new System.Drawing.Size(164, 21);
            this.cboCouleur.TabIndex = 2;
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouleur.Location = new System.Drawing.Point(33, 103);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(80, 19);
            this.lblCouleur.TabIndex = 3;
            this.lblCouleur.Text = "Couleur :";
            // 
            // rdbAllie
            // 
            this.rdbAllie.AutoSize = true;
            this.rdbAllie.Location = new System.Drawing.Point(365, 38);
            this.rdbAllie.Name = "rdbAllie";
            this.rdbAllie.Size = new System.Drawing.Size(85, 17);
            this.rdbAllie.TabIndex = 4;
            this.rdbAllie.TabStop = true;
            this.rdbAllie.Text = "radioButton1";
            this.rdbAllie.UseVisualStyleBackColor = true;
            // 
            // rdbEnnemi
            // 
            this.rdbEnnemi.AutoSize = true;
            this.rdbEnnemi.Location = new System.Drawing.Point(365, 105);
            this.rdbEnnemi.Name = "rdbEnnemi";
            this.rdbEnnemi.Size = new System.Drawing.Size(85, 17);
            this.rdbEnnemi.TabIndex = 5;
            this.rdbEnnemi.TabStop = true;
            this.rdbEnnemi.Text = "radioButton2";
            this.rdbEnnemi.UseVisualStyleBackColor = true;
            // 
            // filtre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 182);
            this.Controls.Add(this.rdbEnnemi);
            this.Controls.Add(this.rdbAllie);
            this.Controls.Add(this.lblCouleur);
            this.Controls.Add(this.cboCouleur);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Name = "filtre";
            this.Text = "Ajout de filtre";
            this.Load += new System.EventHandler(this.filtre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cboCouleur;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.RadioButton rdbAllie;
        private System.Windows.Forms.RadioButton rdbEnnemi;
    }
}