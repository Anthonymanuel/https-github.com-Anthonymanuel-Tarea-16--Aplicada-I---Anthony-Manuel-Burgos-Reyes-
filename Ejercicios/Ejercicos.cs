using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Ejercicos : Form
    {
        public Ejercicos()
        {
            InitializeComponent();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio1C11 ejercicio = new Ejercicio1C11();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Ejercicio2C11 ejercicio = new Ejercicio2C11();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio3C11 ejercicio = new Ejercicio3C11();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Ejercicio4C11 ejercicio = new Ejercicio4C11();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio5C11 ejercicio = new Ejercicio5C11();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }

        private void ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             Ejercicio1C12 ejercicio = new Ejercicio1C12();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }

      

       
    }
}
