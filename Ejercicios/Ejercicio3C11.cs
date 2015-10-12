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
    public partial class Ejercicio3C11 : Form
    {
        
        public Ejercicio3C11()
        {
            InitializeComponent();
        }

        private void CopiarButton_Click(object sender, EventArgs e)
        {
            string nombre = NombreTextBox.Text;
            string rutaActual = @""+RutaActualTextBox.Text;
            string rutaNueva = @""+NuevaRutaTextBox.Text;
            if (File.Exists(rutaActual + "/" + nombre + ".txt"))
            {
                File.Copy(rutaActual + "/" + nombre + ".txt", rutaNueva + "/" + nombre + ".txt", true);
                MessageBox.Show("El archivo fue copiado ");
                RutaActualTextBox.Clear();
                NombreTextBox.Clear();
                NuevaRutaTextBox.Clear();
            }
                
            else
                MessageBox.Show("El archivo no existe");
        
    }
    }
}
