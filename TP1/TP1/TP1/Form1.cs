using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form1 : Form
    {
        Label[] lPunTimeLocal;      // Les punitions à l'équipe locale
        Label[] lPunTimeVisiteur;   // Les punitions à l'équipe visiteuse
        List<Punition> punitionsLocal;
        List<Punition> punitionVisiteur;

        int compteur = 1200;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cette méthode retourne une chaine MM:SS à partir d'un temps exprimé en secondes
        /// </summary>
        public static string TempsFormate(int temps)
        {
            string min = Convert.ToString(temps / 60);
            string sec = Convert.ToString(temps % 60);
            if (min.Length < 2) min = "0" + min;
            if (sec.Length < 2) sec = "0" + sec;
            return min + ":" + sec;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Allouer et initialiser les tableaux de punitions
            lPunTimeLocal = new Label[3] { label2, label3, label4 };
            lPunTimeVisiteur = new Label[3] { label7, label6, label5 };
            lPeriode.Text = "1";
            lHorloge.Text = "20:00";
            punitionsLocal = new List<Punition>();
            punitionVisiteur = new List<Punition>();
        }

        private void handlePunition()
        {
            int i;
            Punition elem;

            i = 0;
            while (i < punitionsLocal.Count() && i < 3)
            {
                elem = punitionsLocal.ElementAt(i);
                if (elem.enCours == true)
                {
                    if (elem.temps == 0)
                    {
                        lPunTimeLocal[i].Text = "00 00:00";
                        punitionsLocal.RemoveAt(i);
                        startPunition();
                    }
                    else
                        lPunTimeLocal[i].Text = elem.no + ' ' + TempsFormate(elem.temps--);
                }
                i++;
            }
            i = 0;
            while (i < punitionVisiteur.Count() && i < 3)
            {
                elem = punitionVisiteur.ElementAt(i);
                if (elem.enCours == true)
                {
                    if (elem.temps == 0)
                    {
                        lPunTimeVisiteur[i].Text = "00 00:00";
                        punitionVisiteur.RemoveAt(i);
                        startPunition();
                    }
                    else
                        lPunTimeVisiteur[i].Text = elem.no + ' ' + TempsFormate(elem.temps--);
                }
                i++;
            }

        }

        /// <summary>
        /// Cette méthode est appelée par le TIMER à chaque seconde
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (compteur <= 0)
                timer.Stop();
            if (punitionsLocal.Count() > 0 || punitionVisiteur.Count() > 0)
            {
                Console.WriteLine("pun local/visit exist");
                handlePunition();
            }
            lHorloge.Text = TempsFormate(compteur--);
            
                
        }

        /// <summary>
        /// Cette méthode est appelée lorsque le score change (pour une des deux équipes)
        /// </summary>
        private void nudValueChanged(object sender, EventArgs e)
        {
            // nud fait référence au pavé numérique qui a changé de valeur
            NumericUpDown nud = sender as NumericUpDown;
            if (nud == nudLocal)
                lScoreLocal.Text = nudLocal.Value.ToString();
            else if (nud == nudVisiteur)
                lScoreVisiteur.Text = nudVisiteur.Value.ToString();
                timer.Stop();
        }

        /// <summary>
        /// Cette méthode est appelée lorsqu'un bouton est cliqué pour éditer les 
        /// punitions. 
        /// </summary>
        private void bPun_Click(object sender, EventArgs e)
        {
            Button b = sender as Button; // b référencie le bouton cliqué
            timer.Stop();

            fEditPun f = new fEditPun();
            if (b == bPunLocal)
            {
                f.Text = @"Punitions de l'équipe locale";
                f.punitions = punitionsLocal;
            }
            else
            {
                f.Text = @"Punitions de l'équipe visiteuse";
                f.punitions = punitionVisiteur;
            }

            f.ShowDialog();

            // Au retour, afficher les punitions ==> à faire

        }

        public void startPunition()
        {
            int i;
            Punition elem;

            i = 0;
            while (i < punitionsLocal.Count() && i < 3)
            {
                Console.WriteLine("While du start punition: local");
                elem = punitionsLocal.ElementAt(i);
                elem.Start();
                i++;
            }
            i = 0;
            while (i < punitionVisiteur.Count() && i < 3)
            {
                Console.WriteLine("While du start puniton: visiteurs");
                elem = punitionVisiteur.ElementAt(i);
                elem.Start();
                i++;
            }
        }

        /// <summary>
        /// Méthode associée au bouton START
        /// </summary>
        private void bStart_Click(object sender, EventArgs e)
        {
            //if (compteur <= 0)
            //    compteur = 1200;
            timer.Start();
            if (punitionsLocal.Count() > 0 || punitionVisiteur.Count() > 0)
            {
                Console.WriteLine("Start punition");
                startPunition();
            }
        }

        /// <summary>
        /// Méthode associée au bouton STOP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        /// <summary>
        /// Méthode associée au bouton AJUSTER.
        /// tbNewTime devrait contenir le nouveau temps en format MM:SS
        /// </summary>
        private void bSetTime_Click(object sender, EventArgs e)
        {
            int min;
            int sec;

            if (tbNewTime.Text.Length >= 4) {
                string minute = new string(tbNewTime.Text.Take(2).ToArray());
                string seconde = tbNewTime.Text.Substring(tbNewTime.TextLength - 2);


                min = Convert.ToInt32(minute) * 60;
                sec = Convert.ToInt32(seconde);

                compteur = min + sec;
                if (compteur > 1200)
                    compteur = 1200;
                lHorloge.Text = TempsFormate(compteur);
            }
            else
                tbNewTime.Text = "";
        }

        /// <summary>
        /// Appelé lorsqu'on change la période
        /// </summary>
        private void nudPeriode_ValueChanged(object sender, EventArgs e)
        {
            if (compteur == 0) {               
                timer.Stop();
                compteur = 1200;
                lPeriode.Text = nudPeriode.Value.ToString();
            }
                
        }

        private void lPeriode_Click(object sender, EventArgs e) {

        }

        private void lScoreVisiteur_Click(object sender, EventArgs e) {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
