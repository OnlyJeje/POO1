using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_POO {
    public partial class Form1 : Form {

        string cmd = "";
        double solde = 0.00d;
        enum mode {
            user,
            technician
        };

        mode test;

        /* Vérifie si le solde ne depasse pas 10 et est supérieur à 0*/
        private bool CheckSolde(double solde) {
            if (solde > 10)
                return false;
            else if (solde < 0)
                return false;
            else
                return true;
                    
        }

        public void BuyProduct(string cmd) {

        }

        /* Ajoute le montant à solde */
        public void AddMoney(string cmd) {
            switch (cmd[1]) {
                case 'A':
                    if (CheckSolde(solde + 2.00))
                    {
                        solde = solde + 2.00;
                        Display("SOLDE", solde.ToString());
                    }
                        
                    else {
                        Display("Pièce", "rejeté");
                        timer1.Start();
                    }
                    break;
                case 'B':
                    if (CheckSolde(solde + 1.00)) {
                        solde = solde + 1.00;
                        Display("SOLDE", solde.ToString());
                    }

                    else {
                        Display("Pièce", "rejeté");
                        timer1.Start();
                    }
                    break;
                case 'C':
                    if (CheckSolde(solde + 0.25)) {
                        solde = solde + 0.25;
                        Display("SOLDE", solde.ToString());
                    }

                    else {
                        Display("Pièce", "rejeté");
                        timer1.Start();
                    }
                    break;
                case 'D':
                    if (CheckSolde(solde + 0.10)) {
                        solde = solde + 0.10;
                        Display("SOLDE", solde.ToString());
                    }

                    else {
                        Display("Pièce", "rejeté"); 
                        timer1.Start();
                    }
                    break;
            }
        }

        public void AddItem(string cmd) {

        }

        public void GiveMoney(string cmd) {
            if (cmd[1] == 'C') { 
                solde = 0.0;
                Display("SOLDE", solde.ToString());
            }
                
        }

        /* Vérifie le premier caractère de la commande et lance le bon mode */
        public void ParseCmd(string cmd) {
            switch (cmd[0]) {
                case '*':
                    BuyProduct(cmd);
                    break;
                case '#':
                    AddMoney(cmd);
                    break;
                case 'A':
                    if (test == mode.technician)
                        AddItem(cmd);
                    break;
                case 'C':
                    GiveMoney(cmd);
                    break;
                case 'D':
                    if (cmd[1] == 'D' && test == mode.user)
                    {
                        test = mode.technician;
                        Display("Mode", "technicien");
                        timer1.Start();
                    }

                    else if (cmd[1] == 'D' && test == mode.technician) 
                    { 
                        test = mode.user;
                        Display("Mode", "utilisateur");
                        timer1.Start();
                    }
                        break;

            }
        }

            /*Récupère la valeur du bouton*/
        public void GetButtonValue(object sender, EventArgs e) {         
            cmd = cmd + ((Button)sender).Text;
            if (cmd.Length == 2) 
            {
                ParseCmd(cmd);
                cmd = "";
            }
                
        }


        /* Affiche sur les labels */
        public void Display(string str1, string str2) {
            label1.Text = str1;
            label2.Text = str2;
        }

        public Form1() {
            InitializeComponent();
            label1.Text = "SOLDE";
            label2.Text = solde.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            Display("SOLDE", solde.ToString());
            timer1.Stop();
        }
    }
}
