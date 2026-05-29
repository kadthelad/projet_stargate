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

        SQLiteConnection maConnec = Connexion.Connec;
        DataSet maDB = MesDatas.DsGlobal;

        private void filtre_Load(object sender, EventArgs e)
        {
            cboCouleur.Items.Clear();
            cboPlanete.Items.Clear();

            for(int i = 0; i < maDB.Tables["Espece"].Rows.Count; i++)
            {
                if (!cboCouleur.Items.Contains(maDB.Tables["Espece"].Rows[i]["couleur"].ToString()))
                {
                    cboCouleur.Items.Add(maDB.Tables["Espece"].Rows[i]["couleur"].ToString());
                }
            }

            for(int i = 0; i < maDB.Tables["Planete"].Rows.Count;i++)
            {
                cboPlanete.Items.Add(maDB.Tables["Planete"].Rows[i]["nom"].ToString());
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

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;

            if (char.IsSeparator(e.KeyChar))
                e.Handled = true;

            if (char.IsPunctuation(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;

            if (e.KeyChar == '-' && txtNom.Text.Contains('-'))
                e.Handled = true;

            if (char.IsSymbol(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == 'µ')
                e.Handled = true;
        }
    }
}
