using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_SAE_24
{
    public partial class ucMembre : UserControl
    {
        public ucMembre()
        {
            InitializeComponent();

        }

        public ucMembre(string nom, string prenom, string nomImage)
        {
            InitializeComponent();
            string cheminProjet = Application.StartupPath;
            try
            {
            Image img = Image.FromFile(cheminProjet + "/img/membres/" + nomImage + ".png");
            pcbPhotoMembre.Image = img;
            }
            catch(Exception error)
            {
                Image img = Image.FromFile(cheminProjet + "/img/membres/placeholder.png");
                pcbPhotoMembre.Image = img;
            }

            lblNom.Text = nom;
            lblPrenom.Text = prenom;
        }

        private void ucMembre_Load(object sender, EventArgs e)
        {

        }

        public void definirChef()
        {
            Font font = new Font(lblNom.Font, FontStyle.Underline);
            lblNom.Font = font;
            lblPrenom.Font = font;
        }
    }
}
