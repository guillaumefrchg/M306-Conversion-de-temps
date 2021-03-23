using System;
using System.Windows.Forms;

namespace M306_Conversion_de_temps
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            lblUTC1.DataBindings.Add("Text", villesBS1, "UTC");
            lblUTC2.DataBindings.Add("Text", villesBS2, "UTC");
            lblUTC3.DataBindings.Add("Text", villesBS3, "UTC");




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
                lblTimeNow.Text = (Afficher(lblUTC3.Text)).ToString("HH:mm:ss");
                //appelle la méthode d'affichage et affiche

            }
            
        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DBPage dbPage = new DBPage();
            // creation de la page pour la BD
            
            dbPage.ShowDialog();
            // affichage de la page pour la BD

            //this.Hide(); -- test 
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
                //même situation en cas de désactivation


            }
        }

        private void TSMI2_Click(object sender, EventArgs e)
        {
            this.Close();
            //fermeture du programme
        }

        private string Calculer(int time, int time2) 
        {
            DateTime var1; //variable de calcul
            DateTime var2; //variable de référance
            //déclaration des variables privées pour faire les calculs

            var1 = dtp1.Value;
            var2 = dtp1.Value;
            //assignation de la valeur choisie par l'utilisateur dans la variable privée


            time = time * -1;
            //si positif rend négatif, si négatif rend positif
            var1 = var1.AddHours(time);
            //converti l'heure en temps utc

            var1 = var1.AddHours(time2);
            //converti le temps utc en fuseau-horaire voulu


            
            

            if ((Convert.ToInt32(var1.ToString("dd"))) > (Convert.ToInt32(var2.ToString("dd"))))
            //si conversion est donne un temps avec un jour de plus affiche +1
            {
                lblDay.Text = "+1";
            }
            else if ((Convert.ToInt32(var1.ToString("dd"))) == (Convert.ToInt32(var2.ToString("dd"))))
            //si conversion reste le même jour affiche +0
            {
                lblDay.Text = "+0";
            }
            else
            //si conversion est donne un temps avec un jour de moins affiche -1
            {
                lblDay.Text = "-1";
            }

            return var1.ToString("HH:mm:ss");
            //affichage de l'heure convertie

        }

        private DateTime Afficher(string input)
        {
            DateTime timeNow;
            //création d'une variable locale

            timeNow = DateTime.UtcNow;
            //récuperation du temps en UTC
            timeNow = timeNow.AddHours(Convert.ToInt32(input));
            //converti et ajoute le fuseau horaire séléctionné
           
            
            return timeNow;
            //retourne le temps
            
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {

            lblConverti.Text = (Calculer(Convert.ToInt32(lblUTC1.Text), Convert.ToInt32(lblUTC2.Text)));
            //Indique le fuseau horaire en parenthese et calcule
        }

    }
}
