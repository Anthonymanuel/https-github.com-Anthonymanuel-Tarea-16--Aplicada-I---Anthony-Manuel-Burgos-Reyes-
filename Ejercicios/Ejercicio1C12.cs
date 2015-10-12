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
    public partial class Ejercicio1C12 : Form
    {
        public Ejercicio1C12()
        {
            InitializeComponent();
        }
       
        private void FactorialButton_Click(object sender, EventArgs e)
        {


            int numero = Convert.ToInt32(NumeroTextBox.Text);
            for (int i = numero-1; i >=1; i--)
        
            MostrarRichTextBox.Text +=" "+  (numero *=i ).ToString();
        }
    }
}
