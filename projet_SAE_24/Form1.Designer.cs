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
            this.btn_test = new System.Windows.Forms.Button();
            this.ctrLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(662, 12);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(126, 49);
            this.btn_test.TabIndex = 0;
            this.btn_test.Text = "Nombre de lignes d\'espèces";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // ctrLayout
            // 
            this.ctrLayout.AutoScroll = true;
            this.ctrLayout.Location = new System.Drawing.Point(12, 12);
            this.ctrLayout.Name = "ctrLayout";
            this.ctrLayout.Size = new System.Drawing.Size(644, 426);
            this.ctrLayout.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.ctrLayout);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.FlowLayoutPanel ctrLayout;
    }
}

