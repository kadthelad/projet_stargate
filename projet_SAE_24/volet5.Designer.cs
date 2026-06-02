namespace projet_SAE_24
{
    partial class volet5
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
            this.layPlanetes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuitterFenetre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // layPlanetes
            // 
            this.layPlanetes.AutoScroll = true;
            this.layPlanetes.Location = new System.Drawing.Point(12, 12);
            this.layPlanetes.Name = "layPlanetes";
            this.layPlanetes.Size = new System.Drawing.Size(776, 426);
            this.layPlanetes.TabIndex = 0;
            // 
            // btnQuitterFenetre
            // 
            this.btnQuitterFenetre.Font = new System.Drawing.Font("Arial", 10F);
            this.btnQuitterFenetre.Location = new System.Drawing.Point(794, 389);
            this.btnQuitterFenetre.Name = "btnQuitterFenetre";
            this.btnQuitterFenetre.Size = new System.Drawing.Size(103, 49);
            this.btnQuitterFenetre.TabIndex = 6;
            this.btnQuitterFenetre.Text = "Quitter la fenêtre";
            this.btnQuitterFenetre.UseVisualStyleBackColor = true;
            this.btnQuitterFenetre.Click += new System.EventHandler(this.btnQuitterFenetre_Click);
            // 
            // volet5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.btnQuitterFenetre);
            this.Controls.Add(this.layPlanetes);
            this.Name = "volet5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Informations sur les planètes";
            this.Load += new System.EventHandler(this.volet5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layPlanetes;
        private System.Windows.Forms.Button btnQuitterFenetre;
    }
}