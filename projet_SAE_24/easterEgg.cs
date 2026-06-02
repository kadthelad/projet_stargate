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
    public partial class easterEgg : Form
    {
        public easterEgg()
        {
            InitializeComponent();
        }

        private void easterEgg_Load(object sender, EventArgs e)
        {
            pbxLeao.Image = (Image)Properties.Resources.ResourceManager.GetObject("leao_ballon_d_or");
            pbxLeao.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
