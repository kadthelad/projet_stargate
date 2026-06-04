namespace projet_SAE_24
{
    partial class ucMembre
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcbPhotoMembre = new System.Windows.Forms.PictureBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhotoMembre)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbPhotoMembre
            // 
            this.pcbPhotoMembre.Location = new System.Drawing.Point(3, 3);
            this.pcbPhotoMembre.Name = "pcbPhotoMembre";
            this.pcbPhotoMembre.Size = new System.Drawing.Size(144, 91);
            this.pcbPhotoMembre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPhotoMembre.TabIndex = 0;
            this.pcbPhotoMembre.TabStop = false;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(53, 97);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(53, 125);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // ucMembre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.pcbPhotoMembre);
            this.Name = "ucMembre";
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhotoMembre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbPhotoMembre;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
    }
}
