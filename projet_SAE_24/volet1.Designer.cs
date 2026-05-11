namespace projet_SAE_24
{
	partial class FormTDB
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTitre = new System.Windows.Forms.Label();
			this.flpTableauDeBord = new System.Windows.Forms.FlowLayoutPanel();
			this.btnCreerMission = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Salmon;
			this.panel1.Controls.Add(this.lblTitre);
			this.panel1.Location = new System.Drawing.Point(-9, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(368, 58);
			this.panel1.TabIndex = 0;
			// 
			// lblTitre
			// 
			this.lblTitre.AutoSize = true;
			this.lblTitre.Font = new System.Drawing.Font("Rubik", 20F, System.Drawing.FontStyle.Bold);
			this.lblTitre.Location = new System.Drawing.Point(42, 10);
			this.lblTitre.Name = "lblTitre";
			this.lblTitre.Size = new System.Drawing.Size(293, 40);
			this.lblTitre.TabIndex = 1;
			this.lblTitre.Text = "Tableau De Bord";
			// 
			// flpTableauDeBord
			// 
			this.flpTableauDeBord.AutoScroll = true;
			this.flpTableauDeBord.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.flpTableauDeBord.Location = new System.Drawing.Point(12, 63);
			this.flpTableauDeBord.Name = "flpTableauDeBord";
			this.flpTableauDeBord.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.flpTableauDeBord.Size = new System.Drawing.Size(559, 375);
			this.flpTableauDeBord.TabIndex = 1;
			// 
			// btnCreerMission
			// 
			this.btnCreerMission.ForeColor = System.Drawing.Color.Red;
			this.btnCreerMission.Location = new System.Drawing.Point(13, 3);
			this.btnCreerMission.Name = "btnCreerMission";
			this.btnCreerMission.Size = new System.Drawing.Size(126, 52);
			this.btnCreerMission.TabIndex = 2;
			this.btnCreerMission.Text = "Créer une mission";
			this.btnCreerMission.UseVisualStyleBackColor = true;
			this.btnCreerMission.Click += new System.EventHandler(this.btnCreerMission_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.btnCreerMission);
			this.panel2.Location = new System.Drawing.Point(359, -1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(441, 58);
			this.panel2.TabIndex = 2;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(303, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(126, 52);
			this.button3.TabIndex = 4;
			this.button3.Text = "Placeholder3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(158, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(126, 52);
			this.button2.TabIndex = 3;
			this.button2.Text = "Placeholder2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// FormTDB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkRed;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.flpTableauDeBord);
			this.Controls.Add(this.panel1);
			this.MaximumSize = new System.Drawing.Size(818, 497);
			this.MinimumSize = new System.Drawing.Size(818, 497);
			this.Name = "FormTDB";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Missions - Tableau de bord";
			this.Load += new System.EventHandler(this.FormTDB_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblTitre;
		private System.Windows.Forms.FlowLayoutPanel flpTableauDeBord;
		private System.Windows.Forms.Button btnCreerMission;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
	}
}