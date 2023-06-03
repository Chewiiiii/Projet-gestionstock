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
    public partial class Crée_produit : Form
    {
        public Crée_produit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Famille fam = new Famille();
            fam.findOneFamille(textBox4.Text);
            Produit création = new Produit(textBox1.Text, textBox2.Text, float.Parse(textBox3.Text), fam);
            création.createProduit();
            this.Close();
        }
    }
}
