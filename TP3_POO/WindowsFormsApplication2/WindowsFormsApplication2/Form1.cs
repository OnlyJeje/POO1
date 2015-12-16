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

            /*Le code de base repris du prof pour l'initialisation du tableau*/
            graph = new ZedGraphControl();      // Créer la composante graphique
            graph.Parent = panel;               // Placer la composante sur le panel de la fiche

            // Ajuster la taille de la composante en fonction de la fiche
            graph.Width = panel.Width - 4;
            graph.Height = panel.Height - 4;

            pane = graph.GraphPane;                 // Créer l'objet graphique
            pane.XAxis.MajorGrid.IsVisible = true;  // Demander l'affichage de grilles
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.XAxis.Title.Text = "Abcisse (X)";  // Identifier les axes
            pane.YAxis.Title.Text = "Ordonnée (Y)";
            pane.Title.Text = "Le titre du graphique";

            // Mettre une petite couleur de fond pour faire joli
            pane.Chart.Fill = new Fill(Color.White, Color.LightBlue, 45.0f);
        }

        private void do_work() {
            /*Ici devrait être une fonction créant une liste à partir du fichier */

            // On insère les valeurs sur notre graphique ==> créer une "courbe".
            //      La courbe est rouge avec un cercle à la position de chacune des valeurs.
            /*Le truc à retenir c'est le AddCurve qui est intéressant mais non fonctionnel ici,
             * Il faudra simplement le réutiliser avec nos points (ceux résultant de la médiation
             entre les coordonnées, la ligne du millieu sur le schèma) et ps: les couleurs ne sont pas
             * bonnes entre le commentaire et le code ;)*/
            ymodif = coordY.ToArray();

            for (int i = 0; i < ymodif.Length; i++) {
                ymodif[i] = A * x[i] + B;
            }

            LineItem courbe = pane.AddCurve("Sinus", x, ymodif, Color.Red);
                courbe.Symbol.Fill = new Fill(Color.Red);

            // On ajuste les axes en fonctions des étendues de X et Y
            /*Mettre notre échelle*/
            pane.XAxis.Scale.Min = coordX.Min();
            pane.XAxis.Scale.Max = coordX.Max();
            pane.YAxis.Scale.Min = 0;
            pane.YAxis.Scale.Max = 60;

            // On donne des titres aux axes et au graphique
            /*Mettre nos noms*/
            pane.XAxis.Title.Text = "Volume (V) en cm3 ";
            pane.YAxis.Title.Text = "Pression P (Kg/cm2)";
            pane.Title.Text = "Graphique de la fonction Y = " + A.ToString() + ".X + " + B.ToString() + "\nCoefficient R = " + R.ToString();

            // On finalise le graphique
            /*Ouais ok, cool story*/
            pane.Legend.IsVisible = false;  // Pas besoin de légende
            graph.AxisChange();             // Pour forcer un réétalonnage des axes
            graph.Invalidate();             // Pour redessiner le graphique
        }

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
