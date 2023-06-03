using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_ORM
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void créeUneFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crée_famille creerf = new Crée_famille();
            creerf.Show();

        }

        private void créeProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crée_produit creerp = new Crée_produit();
            creerp.Show();
        }




    }
}
