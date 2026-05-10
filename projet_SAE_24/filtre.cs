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
    public partial class filtre : Form
    {
        public filtre()
        {
            InitializeComponent();
        }

        SQLiteConnection conn = Connexion.Connec;
        DataSet ds = MesDatas.DsGlobal;

        private void filtre_Load(object sender, EventArgs e)
        {
            cboCouleur.Items.Clear();
            ds.Tables["couleurs"]?.Clear();

            string query = "SELECT DISTINCT couleur FROM Espece";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataAdapter data = new SQLiteDataAdapter();
            data.SelectCommand = cmd;
            data.Fill(ds, "couleurs");

            for(int i = 0; i < ds.Tables["couleurs"].Rows.Count; i++)
            {
                cboCouleur.Items.Add(ds.Tables["couleurs"].Rows[i]["couleur"].ToString());
            }
        }

        public string NomEspece
        {
            get { return txtNom.Text; }
        }

        public string Couleur
        {
            get { return cboCouleur.Text; }
        }

        public bool Allie
        {
            get { return rdbAllie.Checked; }
        }

        public bool Ennemi
        {
            get { return rdbEnnemi.Checked; }
        }

        private void rdbAllie_CheckedChanged(object sender, EventArgs e)
        {
            rdbEnnemi.Enabled = true;
        }

        private void rdbEnnemi_CheckedChanged(object sender, EventArgs e)
        {
            rdbAllie.Enabled = true;
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            txtNom.Text = string.Empty;
            rdbAllie.Checked = false;
            rdbEnnemi.Checked = false;
            cboCouleur.Text = string.Empty;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
