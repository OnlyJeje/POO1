using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        ZedGraphControl graph;
        GraphPane pane;
        //Rajout malprpore de panel afin d'andiguer une erreur.
        private System.Windows.Forms.Panel panel;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
/*Une sensation de déjà vu? C'est ton code pour load les exe mais pour chopper un bin là*/
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "BinFile (.bin) | *.bin";
            openFileDialog.FilterIndex = 1;
            openFileDialog.ShowDialog();
            /*Pour l'instant on ne fait rien du fichier choisi*/

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
            do_work();
        }

        private void do_work()
        {
            /*Ici devrait être une fonction créant une liste à partir du fichier */

            // On insère les valeurs sur notre graphique ==> créer une "courbe".
            //      La courbe est rouge avec un cercle à la position de chacune des valeurs.
            /*Le truc à retenir c'est le AddCurve qui est intéressant mais non fonctionnel ici,
             * Il faudra simplement le réutiliser avec nos points (ceux résultant de la médiation
             entre les coordonnées, la ligne du millieu sur le schèma) et ps: les couleurs ne sont pas
             * bonnes entre le commentaire et le code ;)*/
/*            LineItem courbe = pane.AddCurve("Sinus", point, Color.Green, SymbolType.Triangle);
            courbe.Symbol.Fill = new Fill(Color.Red);*/

            // On ajuste les axes en fonctions des étendues de X et Y
            /*Mettre notre échelle*/
            pane.XAxis.Scale.Min = -10;
            pane.XAxis.Scale.Max = 370;
            pane.YAxis.Scale.Min = -0.1;
            pane.YAxis.Scale.Max = 1.1;

            // On donne des titres aux axes et au graphique
            /*Mettre nos noms*/
            pane.XAxis.Title.Text = "Angle (degrés)";
            pane.YAxis.Title.Text = "Sinus";
            pane.Title.Text = "Graphique de la fonction Y = SIN(X)";

            // On finalise le graphique
            /*Ouais ok, cool story*/
            pane.Legend.IsVisible = false;  // Pas besoin de légende
            graph.AxisChange();             // Pour forcer un réétalonnage des axes
            graph.Invalidate();             // Pour redessiner le graphique
        }

        private void MagicTools()
        {
            /*Ici je mets les bouts de code utiles avec le pourquoi*/

            /*Ton readBinaryFile du TP2 afin de lire les données du fichier*/

            /*Public void ReadBinaryFile(string filename, double[] data) {
            using (BinaryReader b = new BinaryReader(File.Open(filename, FileMode.OpenOrCreate)))
            {
                int pos = 0;
                int i = 0;
                int length = (int)b.BaseStream.Length;
                while (pos < length)
                {
                    double v = b.ReadDouble();
                    data[i++] = v;
                    pos = pos + sizeof(double);
                }
            }*/

        }
    }
}
