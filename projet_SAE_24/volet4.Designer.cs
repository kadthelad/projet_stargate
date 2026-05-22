namespace projet_SAE_24
{
    partial class volet4
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
            this.layEspece = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.btnPlantes = new System.Windows.Forms.Button();
            this.btnQuitterFenetre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // layEspece
            // 
            this.layEspece.AutoScroll = true;
            this.layEspece.Location = new System.Drawing.Point(12, 12);
            this.layEspece.Name = "layEspece";
            this.layEspece.Size = new System.Drawing.Size(644, 426);
            this.layEspece.TabIndex = 2;
            // 
            // btnFiltre
            // 
            this.btnFiltre.Font = new System.Drawing.Font("Arial", 14F);
            this.btnFiltre.Location = new System.Drawing.Point(662, 12);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(126, 49);
            this.btnFiltre.TabIndex = 3;
            this.btnFiltre.Text = "Filtrer";
            this.btnFiltre.UseVisualStyleBackColor = true;
            this.btnFiltre.Click += new System.EventHandler(this.btn_filtre_Click);
            // 
            // btnPlantes
            // 
            this.btnPlantes.Font = new System.Drawing.Font("Arial", 10F);
            this.btnPlantes.Location = new System.Drawing.Point(662, 389);
            this.btnPlantes.Name = "btnPlantes";
            this.btnPlantes.Size = new System.Drawing.Size(126, 49);
            this.btnPlantes.TabIndex = 4;
            this.btnPlantes.Text = "Liste des planètes";
            this.btnPlantes.UseVisualStyleBackColor = true;
            this.btnPlantes.Click += new System.EventHandler(this.btnPlantes_Click);
            // 
            // btnQuitterFenetre
            // 
            this.btnQuitterFenetre.Font = new System.Drawing.Font("Arial", 10F);
            this.btnQuitterFenetre.Location = new System.Drawing.Point(662, 334);
            this.btnQuitterFenetre.Name = "btnQuitterFenetre";
            this.btnQuitterFenetre.Size = new System.Drawing.Size(126, 49);
            this.btnQuitterFenetre.TabIndex = 5;
            this.btnQuitterFenetre.Text = "Quitter la fenêtre";
            this.btnQuitterFenetre.UseVisualStyleBackColor = true;
            this.btnQuitterFenetre.Click += new System.EventHandler(this.button1_Click);
            // 
            // volet4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuitterFenetre);
            this.Controls.Add(this.btnPlantes);
            this.Controls.Add(this.btnFiltre);
            this.Controls.Add(this.layEspece);
            this.Name = "volet4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Informations sur les espèces";
            this.Load += new System.EventHandler(this.volet4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layEspece;
        private System.Windows.Forms.Button btnFiltre;
        private System.Windows.Forms.Button btnPlantes;
        private System.Windows.Forms.Button btnQuitterFenetre;
    }
}