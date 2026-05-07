namespace projet_SAE_24
{
	partial class Form1
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

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnMissions = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnDonnees = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMissions
            // 
            this.btnMissions.BackColor = System.Drawing.Color.ForestGreen;
            this.btnMissions.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMissions.Location = new System.Drawing.Point(204, 102);
            this.btnMissions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMissions.Name = "btnMissions";
            this.btnMissions.Size = new System.Drawing.Size(138, 50);
            this.btnMissions.TabIndex = 1;
            this.btnMissions.Text = "Missions";
            this.btnMissions.UseVisualStyleBackColor = false;
            this.btnMissions.Click += new System.EventHandler(this.btnMissions_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(146, 23);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(277, 53);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Projet Stargate";
            // 
            // btnDonnees
            // 
            this.btnDonnees.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDonnees.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonnees.Location = new System.Drawing.Point(204, 176);
            this.btnDonnees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDonnees.Name = "btnDonnees";
            this.btnDonnees.Size = new System.Drawing.Size(138, 50);
            this.btnDonnees.TabIndex = 3;
            this.btnDonnees.Text = "Données";
            this.btnDonnees.UseVisualStyleBackColor = false;
            this.btnDonnees.Click += new System.EventHandler(this.btnDonnees_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Projet SAE2.4 - Kadir EKICI; Jason-Scott BEBEY BENA; Kevin Vasilescu";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Crimson;
            this.btnQuit.Location = new System.Drawing.Point(502, 231);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(48, 52);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(560, 297);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDonnees);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnMissions);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(576, 336);
            this.MinimumSize = new System.Drawing.Size(576, 336);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projet Stargate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnMissions;
		private System.Windows.Forms.Label lblTitre;
		private System.Windows.Forms.Button btnDonnees;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnQuit;
	}
}

