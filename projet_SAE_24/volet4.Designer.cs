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
            this.ctrLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrLayout
            // 
            this.ctrLayout.AutoScroll = true;
            this.ctrLayout.Location = new System.Drawing.Point(12, 12);
            this.ctrLayout.Name = "ctrLayout";
            this.ctrLayout.Size = new System.Drawing.Size(644, 426);
            this.ctrLayout.TabIndex = 2;
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(662, 12);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(126, 49);
            this.btn_test.TabIndex = 3;
            this.btn_test.Text = "Nombre de lignes d\'espèces";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // volet4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.ctrLayout);
            this.Name = "volet4";
            this.Text = "volet4";
            this.Load += new System.EventHandler(this.volet4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ctrLayout;
        private System.Windows.Forms.Button btn_test;
    }
}