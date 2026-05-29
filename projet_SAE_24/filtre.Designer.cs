namespace projet_SAE_24
{
    partial class filtre
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
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cboCouleur = new System.Windows.Forms.ComboBox();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.rdbAllie = new System.Windows.Forms.RadioButton();
            this.rdbEnnemi = new System.Windows.Forms.RadioButton();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.lblPlanete = new System.Windows.Forms.Label();
            this.cboPlanete = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(33, 36);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(55, 19);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(121, 37);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(164, 20);
            this.txtNom.TabIndex = 1;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // cboCouleur
            // 
            this.cboCouleur.FormattingEnabled = true;
            this.cboCouleur.Location = new System.Drawing.Point(121, 82);
            this.cboCouleur.Name = "cboCouleur";
            this.cboCouleur.Size = new System.Drawing.Size(164, 21);
            this.cboCouleur.TabIndex = 2;
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouleur.Location = new System.Drawing.Point(33, 81);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(80, 19);
            this.lblCouleur.TabIndex = 3;
            this.lblCouleur.Text = "Couleur :";
            // 
            // rdbAllie
            // 
            this.rdbAllie.AutoSize = true;
            this.rdbAllie.Location = new System.Drawing.Point(365, 38);
            this.rdbAllie.Name = "rdbAllie";
            this.rdbAllie.Size = new System.Drawing.Size(159, 17);
            this.rdbAllie.TabIndex = 4;
            this.rdbAllie.TabStop = true;
            this.rdbAllie.Text = "Uniquement les races alliées";
            this.rdbAllie.UseVisualStyleBackColor = true;
            this.rdbAllie.CheckedChanged += new System.EventHandler(this.rdbAllie_CheckedChanged);
            // 
            // rdbEnnemi
            // 
            this.rdbEnnemi.AutoSize = true;
            this.rdbEnnemi.Location = new System.Drawing.Point(365, 105);
            this.rdbEnnemi.Name = "rdbEnnemi";
            this.rdbEnnemi.Size = new System.Drawing.Size(175, 17);
            this.rdbEnnemi.TabIndex = 5;
            this.rdbEnnemi.TabStop = true;
            this.rdbEnnemi.Text = "Uniquement les races ennemies";
            this.rdbEnnemi.UseVisualStyleBackColor = true;
            this.rdbEnnemi.CheckedChanged += new System.EventHandler(this.rdbEnnemi_CheckedChanged);
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnValider.Location = new System.Drawing.Point(494, 156);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(109, 33);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReinitialiser.Location = new System.Drawing.Point(379, 156);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(109, 33);
            this.btnReinitialiser.TabIndex = 7;
            this.btnReinitialiser.Text = "Réinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = true;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // lblPlanete
            // 
            this.lblPlanete.AutoSize = true;
            this.lblPlanete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanete.Location = new System.Drawing.Point(33, 132);
            this.lblPlanete.Name = "lblPlanete";
            this.lblPlanete.Size = new System.Drawing.Size(76, 19);
            this.lblPlanete.TabIndex = 8;
            this.lblPlanete.Text = "Planète :";
            // 
            // cboPlanete
            // 
            this.cboPlanete.FormattingEnabled = true;
            this.cboPlanete.Location = new System.Drawing.Point(121, 133);
            this.cboPlanete.Name = "cboPlanete";
            this.cboPlanete.Size = new System.Drawing.Size(164, 21);
            this.cboPlanete.TabIndex = 9;
            // 
            // filtre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 201);
            this.Controls.Add(this.cboPlanete);
            this.Controls.Add(this.lblPlanete);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.rdbEnnemi);
            this.Controls.Add(this.rdbAllie);
            this.Controls.Add(this.lblCouleur);
            this.Controls.Add(this.cboCouleur);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Name = "filtre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajout de filtre";
            this.Load += new System.EventHandler(this.filtre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cboCouleur;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.RadioButton rdbAllie;
        private System.Windows.Forms.RadioButton rdbEnnemi;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.Label lblPlanete;
        private System.Windows.Forms.ComboBox cboPlanete;
    }
}