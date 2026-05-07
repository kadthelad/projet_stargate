using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace projet_SAE_24
{
    public partial class recapMission : Form
    {
        public recapMission()
        {
            InitializeComponent();
        }

        SQLiteConnection maConnect = Connexion.Connec;
        DataSet monds = MesDatas.DsGlobal;
        int missionChoisis = 0;
        private void recapMission_Load(object sender, EventArgs e)
        {
            DataTable dtSchema = maConnect.GetSchema("Tables");
            for (int i = 1; i < dtSchema.Rows.Count; i++)
            {

                //récupération des tables
                string nomTable = dtSchema.Rows[i]["TABLE_NAME"].ToString();

                string req = "select * from " + nomTable;
                SQLiteCommand cd = new SQLiteCommand(req, maConnect);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cd);
                da.Fill(monds, nomTable);

            }


            //MessageBox.Show();
        }

        private void remplirForm()
        {
            DataTable tblMission = monds.Tables["Mission"];
            DataRow ligne = tblMission.Rows[missionChoisis];
            ligne["nomPlanete"] = ligne;
            //lblMisssion.Text = 
        }
    }
}
