using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
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
                MessageBox.Show(ligne["nom"].ToString());
            }
        }
    }
}
