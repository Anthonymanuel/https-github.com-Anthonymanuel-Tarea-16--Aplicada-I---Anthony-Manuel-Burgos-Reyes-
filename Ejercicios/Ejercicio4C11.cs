using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Ejercicios
{
    public partial class Ejercicio4C11 : Form
    {
        public Ejercicio4C11()
        {
            InitializeComponent();
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            string nombre, ruta;

        
            nombre = NombreTextBox.Text;
            ruta = @"" + RutaTextBox.Text; 
            if(File.Exists(ruta + "/" + nombre + ".txt"))
            {
                if (MessageBox.Show("Esta seguro que quiere borrar el archivo", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    File.Delete(ruta + "/" + nombre + ".txt");
            }
            else
            {
                MessageBox.Show("El archivo no existe");

            }
            NombreTextBox.Clear();
            RutaTextBox.Clear();
        }
    }
}
