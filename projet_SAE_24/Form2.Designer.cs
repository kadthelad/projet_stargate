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
			this.button1 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cboTri = new System.Windows.Forms.ComboBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
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
			this.flpTableauDeBord.Size = new System.Drawing.Size(650, 375);
			this.flpTableauDeBord.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(126, 52);
			this.button1.TabIndex = 2;
			this.button1.Text = "Placeholder1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.button1);
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
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(24, 17);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 75);
			this.button4.TabIndex = 0;
			this.button4.Text = "Refresh";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.label1.Location = new System.Drawing.Point(32, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Trier par:";
			// 
			// cboTri
			// 
			this.cboTri.FormattingEnabled = true;
			this.cboTri.Location = new System.Drawing.Point(0, 138);
			this.cboTri.Name = "cboTri";
			this.cboTri.Size = new System.Drawing.Size(121, 24);
			this.cboTri.TabIndex = 3;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.cboTri);
			this.panel3.Controls.Add(this.button4);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new System.Drawing.Point(669, 68);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(123, 369);
			this.panel3.TabIndex = 3;
			// 
			// FormTDB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkRed;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.flpTableauDeBord);
			this.Controls.Add(this.panel1);
			this.Name = "FormTDB";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Missions - Tableau de bord";
			this.Load += new System.EventHandler(this.FormTDB_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblTitre;
		private System.Windows.Forms.FlowLayoutPanel flpTableauDeBord;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboTri;
		private System.Windows.Forms.Panel panel3;
	}
}