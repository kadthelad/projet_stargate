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
	public partial class FormTDB : Form
	{
		public FormTDB()
		{
			InitializeComponent();
		}

		private void FormTDB_Load(object sender, EventArgs e)
		{

			Mission testMisison = new Mission("planete", "TITRE", "01/01/1990", "01/01/2000", "Ayoub", 15000);
			flpTableauDeBord.Controls.Add(testMisison);
		}
	}
}
