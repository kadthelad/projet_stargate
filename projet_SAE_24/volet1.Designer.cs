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
			this.btnRegistrePlanetes = new System.Windows.Forms.Button();
			this.btnRegistreEspece = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbToutes = new System.Windows.Forms.RadioButton();
			this.rdbEnpreparation = new System.Windows.Forms.RadioButton();
			this.rdbEstterminee = new System.Windows.Forms.RadioButton();
			this.rdbEncours = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.cboFiltre = new System.Windows.Forms.ComboBox();
			this.btnReinitialiser = new System.Windows.Forms.Button();
			this.btnOrdre = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Salmon;
			this.panel1.Controls.Add(this.lblTitre);
			this.panel1.Location = new System.Drawing.Point(-9, -1);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(657, 124);
			this.panel1.TabIndex = 0;
			// 
			// lblTitre
			// 
			this.lblTitre.AutoSize = true;
			this.lblTitre.Font = new System.Drawing.Font("Rubik", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitre.Location = new System.Drawing.Point(61, 28);
			this.lblTitre.Name = "lblTitre";
			this.lblTitre.Size = new System.Drawing.Size(513, 71);
			this.lblTitre.TabIndex = 1;
			this.lblTitre.Text = "Tableau De Bord";
			// 
			// flpTableauDeBord
			// 
			this.flpTableauDeBord.AutoScroll = true;
			this.flpTableauDeBord.BackColor = System.Drawing.Color.Firebrick;
			this.flpTableauDeBord.Location = new System.Drawing.Point(624, 139);
			this.flpTableauDeBord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.flpTableauDeBord.Name = "flpTableauDeBord";
			this.flpTableauDeBord.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
			this.flpTableauDeBord.Size = new System.Drawing.Size(904, 548);
			this.flpTableauDeBord.TabIndex = 1;
			// 
			// btnCreerMission
			// 
			this.btnCreerMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreerMission.ForeColor = System.Drawing.Color.Red;
			this.btnCreerMission.Location = new System.Drawing.Point(132, 19);
			this.btnCreerMission.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCreerMission.Name = "btnCreerMission";
			this.btnCreerMission.Size = new System.Drawing.Size(196, 84);
			this.btnCreerMission.TabIndex = 2;
			this.btnCreerMission.Text = "Créer une mission";
			this.btnCreerMission.UseVisualStyleBackColor = true;
			this.btnCreerMission.Click += new System.EventHandler(this.btnCreerMission_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.BurlyWood;
			this.panel2.Controls.Add(this.btnRegistrePlanetes);
			this.panel2.Controls.Add(this.btnRegistreEspece);
			this.panel2.Controls.Add(this.btnCreerMission);
			this.panel2.Location = new System.Drawing.Point(645, -1);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(901, 124);
			this.panel2.TabIndex = 2;
			// 
			// btnRegistrePlanetes
			// 
			this.btnRegistrePlanetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrePlanetes.Location = new System.Drawing.Point(584, 19);
			this.btnRegistrePlanetes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRegistrePlanetes.Name = "btnRegistrePlanetes";
			this.btnRegistrePlanetes.Size = new System.Drawing.Size(196, 81);
			this.btnRegistrePlanetes.TabIndex = 4;
			this.btnRegistrePlanetes.Text = "Registre des Planètes";
			this.btnRegistrePlanetes.UseVisualStyleBackColor = true;
			this.btnRegistrePlanetes.Click += new System.EventHandler(this.btnRegistrePlanetes_Click);
			// 
			// btnRegistreEspece
			// 
			this.btnRegistreEspece.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistreEspece.Location = new System.Drawing.Point(360, 19);
			this.btnRegistreEspece.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRegistreEspece.Name = "btnRegistreEspece";
			this.btnRegistreEspece.Size = new System.Drawing.Size(196, 84);
			this.btnRegistreEspece.TabIndex = 3;
			this.btnRegistreEspece.Text = "Registre des Espèces";
			this.btnRegistreEspece.UseVisualStyleBackColor = true;
			this.btnRegistreEspece.Click += new System.EventHandler(this.btnRegistreEspece_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.BurlyWood;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(592, 122);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(19, 565);
			this.flowLayoutPanel1.TabIndex = 11;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.BurlyWood;
			this.groupBox1.Controls.Add(this.rdbToutes);
			this.groupBox1.Controls.Add(this.rdbEnpreparation);
			this.groupBox1.Controls.Add(this.rdbEstterminee);
			this.groupBox1.Controls.Add(this.rdbEncours);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(331, 209);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox1.Size = new System.Drawing.Size(267, 199);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Status des missions";
			// 
			// rdbToutes
			// 
			this.rdbToutes.Checked = true;
			this.rdbToutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbToutes.Location = new System.Drawing.Point(100, 49);
			this.rdbToutes.Margin = new System.Windows.Forms.Padding(4);
			this.rdbToutes.Name = "rdbToutes";
			this.rdbToutes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rdbToutes.Size = new System.Drawing.Size(143, 29);
			this.rdbToutes.TabIndex = 7;
			this.rdbToutes.TabStop = true;
			this.rdbToutes.Text = "Toutes";
			this.rdbToutes.UseVisualStyleBackColor = true;
			this.rdbToutes.Click += new System.EventHandler(this.rdbToutes_Click);
			// 
			// rdbEnpreparation
			// 
			this.rdbEnpreparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbEnpreparation.Location = new System.Drawing.Point(34, 160);
			this.rdbEnpreparation.Margin = new System.Windows.Forms.Padding(4);
			this.rdbEnpreparation.Name = "rdbEnpreparation";
			this.rdbEnpreparation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rdbEnpreparation.Size = new System.Drawing.Size(209, 29);
			this.rdbEnpreparation.TabIndex = 9;
			this.rdbEnpreparation.Text = "En préparation";
			this.rdbEnpreparation.UseVisualStyleBackColor = true;
			this.rdbEnpreparation.Click += new System.EventHandler(this.rdbToutes_Click);
			// 
			// rdbEstterminee
			// 
			this.rdbEstterminee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbEstterminee.Location = new System.Drawing.Point(53, 123);
			this.rdbEstterminee.Margin = new System.Windows.Forms.Padding(4);
			this.rdbEstterminee.Name = "rdbEstterminee";
			this.rdbEstterminee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rdbEstterminee.Size = new System.Drawing.Size(190, 29);
			this.rdbEstterminee.TabIndex = 6;
			this.rdbEstterminee.Text = "Est terminée";
			this.rdbEstterminee.UseVisualStyleBackColor = true;
			this.rdbEstterminee.Click += new System.EventHandler(this.rdbToutes_Click);
			// 
			// rdbEncours
			// 
			this.rdbEncours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbEncours.Location = new System.Drawing.Point(84, 86);
			this.rdbEncours.Margin = new System.Windows.Forms.Padding(4);
			this.rdbEncours.Name = "rdbEncours";
			this.rdbEncours.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rdbEncours.Size = new System.Drawing.Size(159, 29);
			this.rdbEncours.TabIndex = 8;
			this.rdbEncours.Text = "En cours";
			this.rdbEncours.UseVisualStyleBackColor = true;
			this.rdbEncours.Click += new System.EventHandler(this.rdbToutes_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(78, 149);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 31);
			this.label1.TabIndex = 13;
			this.label1.Text = "Trier par : ";
			// 
			// cboFiltre
			// 
			this.cboFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboFiltre.FormattingEnabled = true;
			this.cboFiltre.Location = new System.Drawing.Point(224, 149);
			this.cboFiltre.Margin = new System.Windows.Forms.Padding(4);
			this.cboFiltre.Name = "cboFiltre";
			this.cboFiltre.Size = new System.Drawing.Size(310, 33);
			this.cboFiltre.TabIndex = 12;
			this.cboFiltre.SelectedIndexChanged += new System.EventHandler(this.cboFiltre_SelectedIndexChanged);
			// 
			// btnReinitialiser
			// 
			this.btnReinitialiser.Image = global::projet_SAE_24.Properties.Resources.fleche_retour;
			this.btnReinitialiser.Location = new System.Drawing.Point(84, 339);
			this.btnReinitialiser.Name = "btnReinitialiser";
			this.btnReinitialiser.Size = new System.Drawing.Size(69, 69);
			this.btnReinitialiser.TabIndex = 16;
			this.btnReinitialiser.UseVisualStyleBackColor = true;
			this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
			// 
			// btnOrdre
			// 
			this.btnOrdre.Image = global::projet_SAE_24.Properties.Resources.fleche_haut;
			this.btnOrdre.Location = new System.Drawing.Point(542, 146);
			this.btnOrdre.Margin = new System.Windows.Forms.Padding(4);
			this.btnOrdre.Name = "btnOrdre";
			this.btnOrdre.Size = new System.Drawing.Size(42, 42);
			this.btnOrdre.TabIndex = 10;
			this.btnOrdre.Text = "\r\n";
			this.btnOrdre.UseVisualStyleBackColor = true;
			this.btnOrdre.Click += new System.EventHandler(this.btnOrdre_Click);
			// 
			// FormTDB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Firebrick;
			this.ClientSize = new System.Drawing.Size(1540, 673);
			this.Controls.Add(this.btnReinitialiser);
			this.Controls.Add(this.btnOrdre);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.flpTableauDeBord);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.cboFiltre);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximumSize = new System.Drawing.Size(1558, 720);
			this.MinimumSize = new System.Drawing.Size(1558, 720);
			this.Name = "FormTDB";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Missions - Tableau de bord";
			this.Load += new System.EventHandler(this.FormTDB_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblTitre;
		private System.Windows.Forms.FlowLayoutPanel flpTableauDeBord;
		private System.Windows.Forms.Button btnCreerMission;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnRegistrePlanetes;
		private System.Windows.Forms.Button btnRegistreEspece;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdbToutes;
		private System.Windows.Forms.RadioButton rdbEnpreparation;
		private System.Windows.Forms.RadioButton rdbEstterminee;
		private System.Windows.Forms.RadioButton rdbEncours;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboFiltre;
		private System.Windows.Forms.Button btnOrdre;
		private System.Windows.Forms.Button btnReinitialiser;
	}
}