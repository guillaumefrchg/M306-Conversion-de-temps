using System;
using System.Drawing;
using System.Windows.Forms;

namespace M306_Conversion_de_temps
{
    public partial class Home : Form
    {

        int WIDTH = 112, HEIGHT = 112, secHAND = 56, minHAND = 43, hrHAND = 30;
        //dimensions de la bmp

        //center
        int cx, cy;

        Bitmap bmp;
        Graphics g;

        public Home()
        {
            InitializeComponent();

            lblUTC1.DataBindings.Add("Text", villesBS1, "UTC");
            lblUTC2.DataBindings.Add("Text", villesBS2, "UTC");
            lblUTC3.DataBindings.Add("Text", villesBS3, "UTC");
            //Insere les données (villes) dans les listes déroulantes
       


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Villes' table. You can move, or remove it, as needed.
            this.villesTableAdapter.Fill(this.dBDataSet.Villes);
            // TODO: This line of code loads data into the 'dBDataSet.Villes' table. You can move, or remove it, as needed.
            this.villesTableAdapter.Fill(this.dBDataSet.Villes);
            // TODO: This line of code loads data into the 'dBDataSet.Villes' table. You can move, or remove it, as needed.
            this.villesTableAdapter.Fill(this.dBDataSet.Villes);

            
           
                     
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);
            //bmp pour l'horloge analogique
            
            cx = WIDTH / 2;
            cy = HEIGHT / 2;

            this.BackColor = Color.White;

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
            if (lblTimeNow.Visible == false)
            {
                //create graphics
                g = Graphics.FromImage(bmp);

                int ss = 0;
                int mm = 0;
                int hh = 0;

                if (tb1.Checked == false)
                {
                    ss = DateTime.Now.Second;
                    mm = DateTime.Now.Minute;
                    hh = DateTime.Now.Hour;

                }
                else
                {
                     ss = Afficher(lblUTC3.Text).Second;
                     mm = Afficher(lblUTC3.Text).Minute;
                     hh = Afficher(lblUTC3.Text).Hour;
                }

                int[] handCoord = new int[2];

                //clear
                g.Clear(Color.White);

                //draw circle
                g.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, WIDTH, HEIGHT);

                //draw figure
                g.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
                g.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
                g.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(142, 282));
                g.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));

                //second hand
                handCoord = msCoord(ss, secHAND);
                g.DrawLine(new Pen(Color.Red, 1f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

                //minute hand
                handCoord = msCoord(mm, minHAND);
                g.DrawLine(new Pen(Color.Black, 2f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

                //hour hand
                handCoord = hrCoord(hh % 12, mm, hrHAND);
                g.DrawLine(new Pen(Color.Gray, 3f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

                //load bmp in picturebox1
                pbx1.Image = bmp;

 
                //dispose
                g.Dispose();
            }
            lblConverti.Text = (Calculer(Convert.ToInt32(lblUTC1.Text), Convert.ToInt32(lblUTC2.Text)));
            //Indique le fuseau horaire en parenthese et calcule


        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DBPage dbPage = new DBPage();
            // creation de la page pour la BD
            
            dbPage.ShowDialog();
            // affichage de la page pour la BD

            //this.Hide(); -- test 
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

        private void heuresAnalogiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTimeNow.Visible = false;
            pbx1.Visible = true;

        }

        private void heuresDigitalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTimeNow.Visible = true;
            pbx1.Visible = false;
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


        private int[] msCoord(int val, int hlen)
        {
            int[] coord = new int[2];
            val *= 6;   //each minute and second make 6 degree

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        
        private int[] hrCoord(int hval, int mval, int hlen)
        //Coordonnées pour l'aiguille de des heures
        {
            int[] coord = new int[2];

            //chaque heure fait 30 dégres
            //chaque minute fait 0.5 deg
            int val = (int)((hval * 30) + (mval * 0.5));

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }
    }
}
