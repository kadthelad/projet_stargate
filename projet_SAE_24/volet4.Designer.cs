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
            this.lay_espece = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_filtre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lay_espece
            // 
            this.lay_espece.AutoScroll = true;
            this.lay_espece.Location = new System.Drawing.Point(12, 12);
            this.lay_espece.Name = "lay_espece";
            this.lay_espece.Size = new System.Drawing.Size(644, 426);
            this.lay_espece.TabIndex = 2;
            // 
            // btn_filtre
            // 
            this.btn_filtre.Font = new System.Drawing.Font("Arial", 14F);
            this.btn_filtre.Location = new System.Drawing.Point(662, 12);
            this.btn_filtre.Name = "btn_filtre";
            this.btn_filtre.Size = new System.Drawing.Size(126, 49);
            this.btn_filtre.TabIndex = 3;
            this.btn_filtre.Text = "Filtrer";
            this.btn_filtre.UseVisualStyleBackColor = true;
            this.btn_filtre.Click += new System.EventHandler(this.btn_filtre_Click);
            // 
            // volet4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_filtre);
            this.Controls.Add(this.lay_espece);
            this.Name = "volet4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "volet4";
            this.Load += new System.EventHandler(this.volet4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel lay_espece;
        private System.Windows.Forms.Button btn_filtre;
    }
}