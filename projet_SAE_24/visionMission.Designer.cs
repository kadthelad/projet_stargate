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
            this.btnRequete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // layMissions
            // 
            this.layMissions.BackColor = System.Drawing.Color.BurlyWood;
            this.layMissions.Location = new System.Drawing.Point(12, 12);
            this.layMissions.Name = "layMissions";
            this.layMissions.Size = new System.Drawing.Size(651, 387);
            this.layMissions.TabIndex = 0;
            // 
            // btnQuitterFenetre
            // 
            this.btnQuitterFenetre.Font = new System.Drawing.Font("Arial", 10F);
            this.btnQuitterFenetre.Location = new System.Drawing.Point(669, 345);
            this.btnQuitterFenetre.Name = "btnQuitterFenetre";
            this.btnQuitterFenetre.Size = new System.Drawing.Size(80, 49);
            this.btnQuitterFenetre.TabIndex = 6;
            this.btnQuitterFenetre.Text = "Quitter la fenêtre";
            this.btnQuitterFenetre.UseVisualStyleBackColor = true;
            this.btnQuitterFenetre.Click += new System.EventHandler(this.btnQuitterFenetre_Click);
            // 
            // grpEspeces
            // 
            this.grpEspeces.BackColor = System.Drawing.Color.Salmon;
            this.grpEspeces.Location = new System.Drawing.Point(669, 12);
            this.grpEspeces.Name = "grpEspeces";
            this.grpEspeces.Size = new System.Drawing.Size(167, 327);
            this.grpEspeces.TabIndex = 7;
            this.grpEspeces.TabStop = false;
            this.grpEspeces.Text = "Espèces présentes";
            // 
            // btnRequete
            // 
            this.btnRequete.Font = new System.Drawing.Font("Arial", 9F);
            this.btnRequete.Location = new System.Drawing.Point(755, 345);
            this.btnRequete.Name = "btnRequete";
            this.btnRequete.Size = new System.Drawing.Size(80, 49);
            this.btnRequete.TabIndex = 8;
            this.btnRequete.Text = "Nombre de missions";
            this.btnRequete.UseVisualStyleBackColor = true;
            this.btnRequete.Click += new System.EventHandler(this.btnRequete_Click);
            // 
            // visionMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(843, 406);
            this.Controls.Add(this.btnRequete);
            this.Controls.Add(this.grpEspeces);
            this.Controls.Add(this.btnQuitterFenetre);
            this.Controls.Add(this.layMissions);
            this.MaximumSize = new System.Drawing.Size(859, 445);
            this.MinimumSize = new System.Drawing.Size(859, 445);
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
        private System.Windows.Forms.Button btnRequete;
    }
}