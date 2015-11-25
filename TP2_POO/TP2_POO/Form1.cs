using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_POO {
    public partial class Form1 : Form {

        string cmd = "";
        double solde = 0.00d;
        double[] inventory = new double[14];
        double[] price = new double[14];
        string[] name = new string[14];
        bool display = true;
        int iDisplay = 0;
        /* Mode de l'interface */
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
        /*Converti le code d'objet en entier, vérifie que le solde est suffisant ainsi qu'il y a assez d'unité
         de l'objet désiré. Si toutes les conditions sont validé le solde est diminué du prix et le nombre d'unité est décrémenté.
         Sinon un message d'erreur est affiché puis mets à jour le fichier data*/
        public void BuyProduct(string cmd) {
            string hex = cmd[1].ToString();
            int value = Convert.ToInt32(hex, 16);
            if (this.inventory[value] > 0 && (solde - this.price[value]) <= 0)
            {
                this.inventory[value]--;
                solde -= this.price[value];
            }
            else
            {
                if ((solde - this.price[value]) <= 0)
                {
                    this.Display("Solde", "Insuffisant");
                }
            }
            this.WriteBinaryFile("data.bin", inventory);
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

        /*Cette fonction converti le code du produit en entier puis incrémente le 
          nombre d'objet correspondant à ce code puis mets à jour le fichier data*/
        public void AddItem(string cmd) {
            string hex = cmd[1].ToString();
            int value = Convert.ToInt32(hex, 16);
            this.inventory[value]++;
            this.WriteBinaryFile("data.bin", inventory);
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
            /* RAZ timer pour cohérence affichage */
            timer1.Stop();
            timer1.Start();
        }

        public Form1() {
            InitializeComponent();
            label1.Text = "SOLDE";
            label2.Text = solde.ToString();
            ReadBinaryFile("data.bin", inventory);
            ReadBinaryFile("prix.bin", price);
            ReadFile("nom.txt");
            timer1.Start();
            //MessageBox.Show(name[13]);
            //MessageBox.Show(inventory[5].ToString());
        }

        /* Ecrit dans le fichier filename les données du tableau data */
        public void WriteBinaryFile(string filename, double[] data) {
            using (FileStream fileStream = new FileStream(filename,  FileMode.OpenOrCreate))
            using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
            {
                        for (int i = 0; i < data.Length; i++) {
                            binaryWriter.Write(data[i]);
                        }
            }
        }

        /* Lit les données dans le fichier filename et les stocks dans le tableau data */
        public void ReadBinaryFile(string filename, double[] data) {
            using (BinaryReader b = new BinaryReader(File.Open(filename, FileMode.OpenOrCreate))) {
                int pos = 0;
                int i = 0;
                int length = (int)b.BaseStream.Length;
                while (pos < length) {
                    double v = b.ReadDouble();
                    data[i++] = v;
                    pos = pos + sizeof(double);
                }
            }
        }

        /*Lit le fichier filename et le stock dan le tableau name*/
        public void ReadFile(string filename) {
            if (File.Exists(filename))
                name = File.ReadAllLines(filename);
            else
                MessageBox.Show("Le fichier nom.txt n'existe pas");
            }

        /* Gestion de l'affichage */
        private void timer1_Tick(object sender, EventArgs e) {
            if (iDisplay > 13)
                iDisplay = 0;
            if (display == true) { 
                Display("SOLDE", solde.ToString());
                display = false;
            }
            else if (display == false) {
                if (inventory[iDisplay] != 0)
                    Display("" + name[iDisplay] + " " , "" + inventory[iDisplay] + " " + price[iDisplay] + "");
                display = true;
                iDisplay++;
            }
        }
    }
}
