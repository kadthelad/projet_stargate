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
			this.lblBudget = new System.Windows.Forms.Label();
			this.lblDateDepart = new System.Windows.Forms.Label();
			this.lblNomChef = new System.Windows.Forms.Label();
			this.lblDateFinEstimee = new System.Windows.Forms.Label();
			this.lblTitre = new System.Windows.Forms.Label();
			this.btnPDF = new System.Windows.Forms.Button();
			this.lblStatusMission = new System.Windows.Forms.Label();
			this.btnDetails = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblBudget
			// 
			this.lblBudget.AutoSize = true;
			this.lblBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBudget.Location = new System.Drawing.Point(453, 128);
			this.lblBudget.Name = "lblBudget";
			this.lblBudget.Size = new System.Drawing.Size(90, 29);
			this.lblBudget.TabIndex = 1;
			this.lblBudget.Text = "Budget";
			// 
			// lblDateDepart
			// 
			this.lblDateDepart.AutoSize = true;
			this.lblDateDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDateDepart.Location = new System.Drawing.Point(228, 84);
			this.lblDateDepart.Name = "lblDateDepart";
			this.lblDateDepart.Size = new System.Drawing.Size(135, 29);
			this.lblDateDepart.TabIndex = 2;
			this.lblDateDepart.Text = "DateDepart";
			// 
			// lblNomChef
			// 
			this.lblNomChef.AutoSize = true;
			this.lblNomChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomChef.Location = new System.Drawing.Point(228, 128);
			this.lblNomChef.Name = "lblNomChef";
			this.lblNomChef.Size = new System.Drawing.Size(115, 29);
			this.lblNomChef.TabIndex = 3;
			this.lblNomChef.Text = "NomChef";
			// 
			// lblDateFinEstimee
			// 
			this.lblDateFinEstimee.AutoSize = true;
			this.lblDateFinEstimee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDateFinEstimee.Location = new System.Drawing.Point(453, 84);
			this.lblDateFinEstimee.Name = "lblDateFinEstimee";
			this.lblDateFinEstimee.Size = new System.Drawing.Size(185, 29);
			this.lblDateFinEstimee.TabIndex = 4;
			this.lblDateFinEstimee.Text = "DateFinEstimee";
			// 
			// lblTitre
			// 
			this.lblTitre.AutoSize = true;
			this.lblTitre.Font = new System.Drawing.Font("Noto Sans Hebrew", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitre.Location = new System.Drawing.Point(223, 18);
			this.lblTitre.Name = "lblTitre";
			this.lblTitre.Size = new System.Drawing.Size(117, 55);
			this.lblTitre.TabIndex = 5;
			this.lblTitre.Text = "Titre";
			// 
			// btnPDF
			// 
			this.btnPDF.BackColor = System.Drawing.Color.White;
			this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPDF.Image = global::projet_SAE_24.Properties.Resources.pdf;
			this.btnPDF.Location = new System.Drawing.Point(755, 42);
			this.btnPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPDF.Name = "btnPDF";
			this.btnPDF.Size = new System.Drawing.Size(87, 82);
			this.btnPDF.TabIndex = 6;
			this.btnPDF.UseVisualStyleBackColor = false;
			this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
			// 
			// lblStatusMission
			// 
			this.lblStatusMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatusMission.Location = new System.Drawing.Point(595, 10);
			this.lblStatusMission.Name = "lblStatusMission";
			this.lblStatusMission.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblStatusMission.Size = new System.Drawing.Size(233, 30);
			this.lblStatusMission.TabIndex = 7;
			this.lblStatusMission.Text = "StatusMission";
			// 
			// btnDetails
			// 
			this.btnDetails.BackColor = System.Drawing.Color.White;
			this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDetails.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDetails.Image = global::projet_SAE_24.Properties.Resources.loupe;
			this.btnDetails.Location = new System.Drawing.Point(662, 42);
			this.btnDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDetails.Name = "btnDetails";
			this.btnDetails.Size = new System.Drawing.Size(87, 82);
			this.btnDetails.TabIndex = 8;
			this.btnDetails.UseVisualStyleBackColor = false;
			this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(15, 18);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(164, 149);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Mission
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Salmon;
			this.Controls.Add(this.btnDetails);
			this.Controls.Add(this.lblStatusMission);
			this.Controls.Add(this.btnPDF);
			this.Controls.Add(this.lblTitre);
			this.Controls.Add(this.lblDateFinEstimee);
			this.Controls.Add(this.lblNomChef);
			this.Controls.Add(this.lblDateDepart);
			this.Controls.Add(this.lblBudget);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Mission";
			this.Size = new System.Drawing.Size(845, 188);
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
		private System.Windows.Forms.Button btnDetails;
	}
}
