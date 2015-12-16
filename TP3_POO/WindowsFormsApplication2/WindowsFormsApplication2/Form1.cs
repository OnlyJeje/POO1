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
using ZedGraph;

namespace WindowsFormsApplication2 {
    public partial class Form1 : Form {
        ZedGraphControl graph;
        GraphPane pane;

        List<double> coordX = new List<double>();
        List<double> coordY = new List<double>();
        double[] x = null;
        double[] y = null;
        double[] ymodif = null;

        double sumX;
        double sumY;
        
        double sumSquareX;
        double sumXY;

        double A;
        double B;
        double R;

        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {

            /*Le code qui suit est repris de l'exemple pour l'initialisation du graph*/
            graph = new ZedGraphControl();     
            graph.Parent = panel;               

            // Ajuster la taille de la composante en fonction de la fiche
            graph.Width = panel.Width - 4;
            graph.Height = panel.Height - 4;

            //Afficher la grille, nommer les axes et nommer provisoirement le graphique
            pane = graph.GraphPane;               
            pane.XAxis.MajorGrid.IsVisible = true;  
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.XAxis.Title.Text = "Volume (V) en cm3 ";
            pane.YAxis.Title.Text = "Pression P (Kg/cm2)";
            pane.Title.Text = "Le titre du graphique";

            pane.Chart.Fill = new Fill(Color.White, Color.LightBlue, 45.0f);
        }

        private void do_work() {
            // On insère les valeurs sur notre graphique ==> créer une "courbe".
            ymodif = coordY.ToArray();

            for (int i = 0; i < ymodif.Length; i++) {
                ymodif[i] = A * x[i] + B;
            }

            LineItem courbe = pane.AddCurve("Sinus", x, ymodif, Color.Red);
                courbe.Symbol.Fill = new Fill(Color.Red);

            // On ajuste les axes en fonctions des étendues de X et Y
            pane.XAxis.Scale.Min = coordX.Min();
            pane.XAxis.Scale.Max = coordX.Max();
            pane.YAxis.Scale.Min = 0;
            pane.YAxis.Scale.Max = 60;

            //Attribution du bon titre pour le graphique           
            pane.Title.Text = "Graphique de la fonction Y = " + A.ToString() + ".X + " + B.ToString() + "\nCoefficient R = " + R.ToString();

            // On finalise le graphique
            pane.Legend.IsVisible = false;
            graph.AxisChange();           
            graph.Invalidate();           
        }

        //Ici l'utilisateur choisit le fichier qu'il souhaite charger, ce fichier est ouvert, son contenu est disposer dans deux tableaux
        //Ensuite les opérations sont effectuer pour calculer la courbe
        private void LoadFile_Click(object sender, EventArgs e) {


            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "TP3File (.TP3) | *.TP3";
            openFileDialog.FilterIndex = 1;
            openFileDialog.ShowDialog();

            coordX.Clear();
            coordY.Clear();
            using (BinaryReader b = new BinaryReader(File.Open(openFileDialog.FileName, FileMode.Open))) {
                int pos = 0;
                int length = (int)b.BaseStream.Length;
                while (pos < length) {
                    
                    double v = b.ReadDouble();
                    if (coordX.Count() != coordY.Count())
                        coordY.Add(v);
                    else
                        coordX.Add(v);
                    pos = pos + sizeof(double);
                }

            }
            x = coordX.ToArray();
            y = coordY.ToArray();
            A = calcA(x, y);
            B = calcB(x, y);
            R = coeffCorrel(x, y);
            do_work();
        }
        //Pour les fonctions calcB et calcA ce sont toutes les opérations pour calculer les coordonnées
        double calcB(double[] tabX, double[] tabY) {
            double res = 0; ;
            res = ((sumY * sumSquareX) - (sumX * sumXY)) / ((tabX.Length * sumSquareX) - (Math.Pow(sumX,2)));
            return res;

        }
        double calcA (double[] tabX, double[] tabY)
            {               
            sumX = tabX.Sum();                
            sumY = tabY.Sum();                
            sumSquareX = 0;      
            sumXY = 0;               
                double res = 0;

                foreach (double elem in tabX) {
                    sumSquareX = sumSquareX + elem * elem;
                }

                for (int i = 0; i < tabX.Length; i++) {
                    sumXY = sumXY + tabX[i] * tabY[i];
                }

                res = ((tabX.Length * sumXY) - (sumX * sumY)) / ((tabX.Length * sumSquareX) - (Math.Pow(sumX,2)));
            return res;

            }
        //Calcul du coefficient de correlation afin de lisser la courbe
        double coeffCorrel(double[] tabX, double[] tabY) {
            double res = 0;
            double calc1 = 0;
            double calc2 = 0;
            double sumSquareY = 0;

            foreach (double elem in tabY) {
                    sumSquareY = sumSquareY + elem * elem;
                }


            calc1 = tabX.Length * sumSquareX - Math.Pow(sumX, 2);
            calc2 = tabX.Length * sumSquareY - Math.Pow(sumY, 2);

            res = ((tabX.Length * sumXY) - (sumX * sumY)) / (Math.Sqrt(calc1 * calc2));

            return res;
        }
    }



}
