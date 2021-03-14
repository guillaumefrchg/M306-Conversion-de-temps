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



            






        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Villes' table. You can move, or remove it, as needed.
            this.villesTableAdapter.Fill(this.dBDataSet.Villes);
            // TODO: This line of code loads data into the 'dBDataSet.Villes' table. You can move, or remove it, as needed.
            this.villesTableAdapter.Fill(this.dBDataSet.Villes);
            // TODO: This line of code loads data into the 'dBDataSet.Villes' table. You can move, or remove it, as needed.
            this.villesTableAdapter.Fill(this.dBDataSet.Villes);




        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tb1.Checked == false)
            {
                lblTimeNow.Text = DateTime.Now.ToString("HH:mm:ss");
                //Affichage de l'heure de l'ordinateur si la case n'est pas cochée
            }
            else
            {

                //compensation avec le fuseau horaire choisi
            }
            
        }


        private void cbxVille1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblTimeNow_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DBPage dbPage = new DBPage();
            // creation de la page pour la BD
            //this.Hide(); -- test 
            dbPage.ShowDialog();
            // affichage de la page pour la BD
        }



        private void cbxVille1_Click(object sender, EventArgs e)
        {
            //lblTime1.Text = cbxVille1.SelectedIndex.ToString(); -- test
            //lblTime1.Text = villesBS1.Position.ToString(); -- test

        }

        private void tb1_CheckedChanged(object sender, EventArgs e)
        {
            if (tb1.Checked == true)
            {
                cbxVille3.Enabled = true;
                //activation de la liste en cochant
            }
            else
            {
                cbxVille3.Enabled = false;
                //même cas en cas de désactivation
            }
        }

        private void TSMI2_Click(object sender, EventArgs e)
        {
            this.Close();
            //fermeture du programme
        }

        private void Calculer(int utc) 
        {
            DateTime var1;
            DateTime var2;
            //déclaration des variables privée pour faire les calculs
            var1 = dtp1.Value;
            var2 = dtp1.Value;
            //assignation de la valeur choisie par l'utilisateur dans la variable privée
            var1 = var1.AddHours(utc);
            //ajout ou soustraction en focntion du fuseau horaire
            lblConverti.Text = var1.ToString("HH:mm:ss");
            //conversion puis affichage de l'heure convertie

            //if (Convert.ToInt32(var1.ToString("dd")) < Convert.ToInt32(var2.ToString("dd"))
           // {

           //}
            

        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            Calculer(-10);
            //Indique le fuseau horaire en parenthese et calcule
        }
    }
}
