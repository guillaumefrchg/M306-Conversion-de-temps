using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M306_Conversion_de_temps
{
    public partial class DBPage : Form
    {
        public DBPage()
        {
            InitializeComponent();
        }

        private void DBPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Villes' table. You can move, or remove it, as needed.
            this.villesTableAdapter.Fill(this.dBDataSet.Villes);

        }
    }
}
