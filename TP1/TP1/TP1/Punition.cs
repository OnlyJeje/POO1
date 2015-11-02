using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Punition : IComparable
    {
        public string no;      // Numéro du joueur
        public int temps;   // Temps restant à la punition en secondes
        public bool enCours; // La punition a-t-elle commencé?
        public Punition(string no, int t)
        {
            this.no = no; temps = t; enCours = false;
        }
        public void Start()
        {
            enCours = true;
        }
        public void Dec()
        {
            if (!enCours) return;
            if (temps > 0) temps--;
            else enCours = false;
        }

        /// <summary>
        /// Cette méthode fait partie de l'interface IComparable.
        /// Elle sert à trier des objets Punition dans une Collection.
        /// </summary>
        public int CompareTo(Object o)
        {
            Punition p = o as Punition;
            if (p.temps > temps) return -1;
            if (p.temps < temps) return 1;
            return 0;
        }
    }
}
