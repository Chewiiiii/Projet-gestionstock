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
    public partial class Crée_famille : Form
    {
        public Crée_famille()
        {
            InitializeComponent();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            Famille création = new Famille(textBox1.Text , textBox2.Text , textBox3.Text );
            création.createFamille();
            this.Close();
        }
    }
}
