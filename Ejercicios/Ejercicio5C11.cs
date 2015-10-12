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
    public partial class Ejercicio5C11 : Form
    {
        public Ejercicio5C11()
        {
            InitializeComponent();
        }

        private void CambiarButton_Click(object sender, EventArgs e)
        {
            string nombre = NombreTextBox.Text;
            string nuevoNombre = NuevoNombreTextBox.Text;
            string ruta = @"" + RutaTextBox.Text;
            if (File.Exists(ruta + "/" + nombre + ".txt"))
            {
                File.Move(ruta + "/" + nombre + ".txt", ruta + "/" + nuevoNombre + ".txt");
                MessageBox.Show("Se ha cambiado el nombre del archivo con exito");
                NombreTextBox.Clear();
                RutaTextBox.Clear();
                NuevoNombreTextBox.Clear();

            }
            else
            {
                MessageBox.Show("El archivo no existe");
            }
        }
    }
}
