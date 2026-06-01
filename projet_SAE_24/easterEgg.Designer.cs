namespace projet_SAE_24
{
    partial class easterEgg
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
            this.pbxLeao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLeao)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLeao
            // 
            this.pbxLeao.Location = new System.Drawing.Point(1, 0);
            this.pbxLeao.Name = "pbxLeao";
            this.pbxLeao.Size = new System.Drawing.Size(801, 450);
            this.pbxLeao.TabIndex = 0;
            this.pbxLeao.TabStop = false;
            // 
            // easterEgg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxLeao);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "easterEgg";
            this.Text = "easterEgg";
            this.Load += new System.EventHandler(this.easterEgg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLeao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLeao;
    }
}