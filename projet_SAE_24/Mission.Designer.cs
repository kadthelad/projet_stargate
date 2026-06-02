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
			this.btnPDF = new System.Windows.Forms.Button();
			this.lblStatusMission = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(11, 15);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(123, 121);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lblBudget
			// 
			this.lblBudget.AutoSize = true;
			this.lblBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBudget.Location = new System.Drawing.Point(362, 104);
			this.lblBudget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblBudget.Name = "lblBudget";
			this.lblBudget.Size = new System.Drawing.Size(70, 24);
			this.lblBudget.TabIndex = 1;
			this.lblBudget.Text = "Budget";
			// 
			// lblDateDepart
			// 
			this.lblDateDepart.AutoSize = true;
			this.lblDateDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDateDepart.Location = new System.Drawing.Point(171, 68);
			this.lblDateDepart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblDateDepart.Name = "lblDateDepart";
			this.lblDateDepart.Size = new System.Drawing.Size(103, 24);
			this.lblDateDepart.TabIndex = 2;
			this.lblDateDepart.Text = "DateDepart";
			// 
			// lblNomChef
			// 
			this.lblNomChef.AutoSize = true;
			this.lblNomChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomChef.Location = new System.Drawing.Point(171, 104);
			this.lblNomChef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNomChef.Name = "lblNomChef";
			this.lblNomChef.Size = new System.Drawing.Size(90, 24);
			this.lblNomChef.TabIndex = 3;
			this.lblNomChef.Text = "NomChef";
			// 
			// lblDateFinEstimee
			// 
			this.lblDateFinEstimee.AutoSize = true;
			this.lblDateFinEstimee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDateFinEstimee.Location = new System.Drawing.Point(362, 68);
			this.lblDateFinEstimee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblDateFinEstimee.Name = "lblDateFinEstimee";
			this.lblDateFinEstimee.Size = new System.Drawing.Size(143, 24);
			this.lblDateFinEstimee.TabIndex = 4;
			this.lblDateFinEstimee.Text = "DateFinEstimee";
			// 
			// lblTitre
			// 
			this.lblTitre.AutoSize = true;
			this.lblTitre.Font = new System.Drawing.Font("Noto Sans Hebrew", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitre.Location = new System.Drawing.Point(167, 15);
			this.lblTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTitre.Name = "lblTitre";
			this.lblTitre.Size = new System.Drawing.Size(92, 43);
			this.lblTitre.TabIndex = 5;
			this.lblTitre.Text = "Titre";
			// 
			// btnPDF
			// 
			this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPDF.Location = new System.Drawing.Point(550, 48);
			this.btnPDF.Margin = new System.Windows.Forms.Padding(2);
			this.btnPDF.Name = "btnPDF";
			this.btnPDF.Size = new System.Drawing.Size(65, 67);
			this.btnPDF.TabIndex = 6;
			this.btnPDF.Text = "PDF";
			this.btnPDF.UseVisualStyleBackColor = true;
			this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
			// 
			// lblStatusMission
			// 
			this.lblStatusMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatusMission.Location = new System.Drawing.Point(444, 15);
			this.lblStatusMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblStatusMission.Name = "lblStatusMission";
			this.lblStatusMission.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblStatusMission.Size = new System.Drawing.Size(175, 24);
			this.lblStatusMission.TabIndex = 7;
			this.lblStatusMission.Text = "StatusMission";
			// 
			// Mission
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Salmon;
			this.Controls.Add(this.lblStatusMission);
			this.Controls.Add(this.btnPDF);
			this.Controls.Add(this.lblTitre);
			this.Controls.Add(this.lblDateFinEstimee);
			this.Controls.Add(this.lblNomChef);
			this.Controls.Add(this.lblDateDepart);
			this.Controls.Add(this.lblBudget);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Mission";
			this.Size = new System.Drawing.Size(634, 153);
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
		private System.Windows.Forms.Button btnPDF;
		private System.Windows.Forms.Label lblStatusMission;
	}
}
