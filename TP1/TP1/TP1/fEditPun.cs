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
    public partial class fEditPun : Form
    {
        public List<Punition> punitions;

        public fEditPun()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Méthode appelée au chargement du formulaire
        /// </summary>
        private void fEditPun_Load(object sender, EventArgs e)
        {
            //  Charger dans le ListView les punitions 
            AffichePunitions();
        }

        void AffichePunitions()
        {
            lvPun.Items.Clear();
            foreach (Punition p in punitions)
            {
                ListViewItem lvi = new ListViewItem(p.no.ToString());
                lvi.SubItems.Add(Form1.TempsFormate(p.temps));
                lvi.Tag = p;
                lvPun.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Méthode appelée pour ajouter une punition
        /// </summary>
        private void bAdd_Click(object sender, EventArgs e)
        {
            // Récupérer les informations sur la punition
            int t = Convert.ToInt32(cbTemps.Text);
            t *= 60; // mettre le temps en secondes
            // Récupérer le numéro de joueur
            string no = tbJoueur.Text;
            if (no.Length < 2) no = "0" + no;
            // générer u objet punition
            Punition p = new Punition(no, t);
            // Ajouter la punition dans la liste
            punitions.Add(p);
            // Réafficher la liste
            AffichePunitions();
        }

        /// <summary>
        /// Méthode appelée lorsque les changements sont terminés.
        /// </summary>
        private void bOK_Click(object sender, EventArgs e)
        {
            // Mettre à jour la liste de punitions
            // 1 - vider l'ancienne liste
            punitions.Clear();
            // 2 - repeupler la liste avec le contenu du ListView
            foreach (ListViewItem lvi in lvPun.Items)
                punitions.Add(lvi.Tag as Punition);
            // 3 - Trier la liste
            punitions.Sort();
            // Fermer le formulaire
            Close();
        }

        /// <summary>
        /// Méthode appelée pour supprimer une punition.
        /// Le numéro de la punition est donné par index.
        /// </summary>
        private void menuAnnuler_Click(object sender, EventArgs e)
        {
            if (lvPun.SelectedItems.Count == 0) return;
            // Déterminer l'indice de l'item sélectionné
            int index = lvPun.SelectedIndices[0];
            // Identifier la punition à retirer de la liste
            Punition p = lvPun.Items[index].Tag as Punition;
            // Retirer la punition de la liste
            punitions.Remove(p);
            // Réafficher les punitions
            AffichePunitions();
        }

 
    }
}
