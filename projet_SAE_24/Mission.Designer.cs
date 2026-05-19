namespace projet_SAE_24
{
	partial class Mission
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblDateDepart = new System.Windows.Forms.Label();
            this.lblNomChef = new System.Windows.Forms.Label();
            this.lblDateFinEstimee = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 73);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(195, 76);
            this.lblBudget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(41, 13);
            this.lblBudget.TabIndex = 1;
            this.lblBudget.Text = "Budget";
            // 
            // lblDateDepart
            // 
            this.lblDateDepart.AutoSize = true;
            this.lblDateDepart.Location = new System.Drawing.Point(94, 50);
            this.lblDateDepart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateDepart.Name = "lblDateDepart";
            this.lblDateDepart.Size = new System.Drawing.Size(62, 13);
            this.lblDateDepart.TabIndex = 2;
            this.lblDateDepart.Text = "DateDepart";
            // 
            // lblNomChef
            // 
            this.lblNomChef.AutoSize = true;
            this.lblNomChef.Location = new System.Drawing.Point(94, 76);
            this.lblNomChef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomChef.Name = "lblNomChef";
            this.lblNomChef.Size = new System.Drawing.Size(51, 13);
            this.lblNomChef.TabIndex = 3;
            this.lblNomChef.Text = "NomChef";
            // 
            // lblDateFinEstimee
            // 
            this.lblDateFinEstimee.AutoSize = true;
            this.lblDateFinEstimee.Location = new System.Drawing.Point(195, 50);
            this.lblDateFinEstimee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateFinEstimee.Name = "lblDateFinEstimee";
            this.lblDateFinEstimee.Size = new System.Drawing.Size(81, 13);
            this.lblDateFinEstimee.TabIndex = 4;
            this.lblDateFinEstimee.Text = "DateFinEstimee";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Noto Sans Hebrew", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(91, 8);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(65, 29);
            this.lblTitre.TabIndex = 5;
            this.lblTitre.Text = "Titre";
            // 
            // Mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblDateFinEstimee);
            this.Controls.Add(this.lblNomChef);
            this.Controls.Add(this.lblDateDepart);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Mission";
            this.Size = new System.Drawing.Size(354, 104);
            this.Load += new System.EventHandler(this.Mission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblBudget;
		private System.Windows.Forms.Label lblDateDepart;
		private System.Windows.Forms.Label lblNomChef;
		private System.Windows.Forms.Label lblDateFinEstimee;
		private System.Windows.Forms.Label lblTitre;
	}
}
