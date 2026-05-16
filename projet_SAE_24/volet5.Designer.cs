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
            this.SuspendLayout();
            // 
            // layPlanetes
            // 
            this.layPlanetes.Location = new System.Drawing.Point(12, 12);
            this.layPlanetes.Name = "layPlanetes";
            this.layPlanetes.Size = new System.Drawing.Size(776, 426);
            this.layPlanetes.TabIndex = 0;
            // 
            // volet5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layPlanetes);
            this.Name = "volet5";
            this.Text = "volet5";
            this.Load += new System.EventHandler(this.volet5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layPlanetes;
    }
}