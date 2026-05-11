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

        public ucMembre(string nomMembre, string nomImage)
        {
            InitializeComponent();
            string cheminProjet = Application.StartupPath;
            Image img = Image.FromFile(cheminProjet);

            lblNomMembre.Text = nomMembre;
        }

        private void ucMembre_Load(object sender, EventArgs e)
        {

        }
    }
}
