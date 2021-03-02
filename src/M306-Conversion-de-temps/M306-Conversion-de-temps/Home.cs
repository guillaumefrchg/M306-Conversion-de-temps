using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Data.OleDb;

namespace M306_Conversion_de_temps
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=testapp.accdb");
            OleDbCommand cmd = con.CreateCommand();
            
            con.Close();





        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            



        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Conversion(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cbx1.Enabled == true)
            {
                lblTimeNow.Text = DateTime.Now.ToString("HH:mm:ss");
                //Affichage de l'heure
            }
            else
            {

            }
            
        }

        private void villesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cbxVille1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTimeNow_Click(object sender, EventArgs e)
        {

        }
    }
}
