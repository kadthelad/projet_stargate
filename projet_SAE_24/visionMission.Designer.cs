namespace projet_SAE_24
{
    partial class visionMission
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.layMissions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuitterFenetre = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.grpEspeces = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // layMissions
            // 
            this.layMissions.Location = new System.Drawing.Point(12, 12);
            this.layMissions.Name = "layMissions";
            this.layMissions.Size = new System.Drawing.Size(580, 387);
            this.layMissions.TabIndex = 0;
            // 
            // btnQuitterFenetre
            // 
            this.btnQuitterFenetre.Font = new System.Drawing.Font("Arial", 10F);
            this.btnQuitterFenetre.Location = new System.Drawing.Point(618, 345);
            this.btnQuitterFenetre.Name = "btnQuitterFenetre";
            this.btnQuitterFenetre.Size = new System.Drawing.Size(126, 49);
            this.btnQuitterFenetre.TabIndex = 6;
            this.btnQuitterFenetre.Text = "Quitter la fenêtre";
            this.btnQuitterFenetre.UseVisualStyleBackColor = true;
            this.btnQuitterFenetre.Click += new System.EventHandler(this.btnQuitterFenetre_Click);
            // 
            // grpEspeces
            // 
            this.grpEspeces.Location = new System.Drawing.Point(598, 12);
            this.grpEspeces.Name = "grpEspeces";
            this.grpEspeces.Size = new System.Drawing.Size(167, 327);
            this.grpEspeces.TabIndex = 7;
            this.grpEspeces.TabStop = false;
            this.grpEspeces.Text = "Espèces présentes";
            // 
            // visionMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 406);
            this.Controls.Add(this.grpEspeces);
            this.Controls.Add(this.btnQuitterFenetre);
            this.Controls.Add(this.layMissions);
            this.MaximumSize = new System.Drawing.Size(791, 445);
            this.MinimumSize = new System.Drawing.Size(791, 445);
            this.Name = "visionMission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Missions sur la planète";
            this.Load += new System.EventHandler(this.visionMission_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel layMissions;
        private System.Windows.Forms.Button btnQuitterFenetre;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox grpEspeces;
    }
}