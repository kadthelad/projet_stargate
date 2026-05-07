namespace projet_SAE_24
{
	partial class FrmAdminAccess
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txbIdentifiant = new System.Windows.Forms.TextBox();
			this.txbMdp = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(109, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Attention: accès restreint!";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Identifiant :";
			// 
			// txbIdentifiant
			// 
			this.txbIdentifiant.Location = new System.Drawing.Point(125, 90);
			this.txbIdentifiant.Name = "txbIdentifiant";
			this.txbIdentifiant.Size = new System.Drawing.Size(215, 22);
			this.txbIdentifiant.TabIndex = 2;
			// 
			// txbMdp
			// 
			this.txbMdp.Location = new System.Drawing.Point(125, 118);
			this.txbMdp.Name = "txbMdp";
			this.txbMdp.Size = new System.Drawing.Size(215, 22);
			this.txbMdp.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Mot de passe :";
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(125, 163);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(147, 36);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Se connecter";
			this.btnLogin.UseVisualStyleBackColor = true;
			// 
			// FrmAdminAccess
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 224);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txbMdp);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txbIdentifiant);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmAdminAccess";
			this.Text = "Connection en tant qu\'admin...";
			this.Load += new System.EventHandler(this.AdminAccess_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbIdentifiant;
		private System.Windows.Forms.TextBox txbMdp;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnLogin;
	}
}