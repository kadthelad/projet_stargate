using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_SAE_24
{
    public partial class volet5 : Form
    {
        public volet5()
        {
            InitializeComponent();
        }

        SQLiteConnection maConnec = Connexion.Connec;
        DataSet maDB = MesDatas.DsGlobal;

        string projectPath = Application.StartupPath;

        private void volet5_Load(object sender, EventArgs e)
        {
            foreach (DataRow ligne in maDB.Tables["Planete"].Rows)
            {
                PictureBox pb = new PictureBox();
                Panel p = new Panel();
                Label lblNomPlanete = new Label();

                string planete = ligne["nom"].ToString().Trim();

                /*MessageBox.Show(projectPath + "/img/planetes/" + planete + ".png");
                MessageBox.Show(File.Exists(projectPath + "/img//planetes/" + planete + ".png").ToString());*/

                pb.Image = Image.FromFile(projectPath + "/img/planetes/" + planete + ".png");
                pb.SizeMode = PictureBoxSizeMode.StretchImage;

                p.Width = 150;
                p.Height = 100;

                p.Margin = new Padding(30);

                lblNomPlanete.Text = planete;
                lblNomPlanete.Left = 100;
                lblNomPlanete.Top = 5;
                lblNomPlanete.AutoSize = true;
                lblNomPlanete.Font = new Font("Arial", 12, FontStyle.Bold);

                lblNomPlanete.Top = pb.Bottom + 5;
                lblNomPlanete.Left = pb.Left + (pb.Width - lblNomPlanete.PreferredWidth) / 2;

                p.Controls.Add(pb);
                p.Controls.Add(lblNomPlanete);
                layPlanetes.Controls.Add(p);
                
            }
        }
    }
}
