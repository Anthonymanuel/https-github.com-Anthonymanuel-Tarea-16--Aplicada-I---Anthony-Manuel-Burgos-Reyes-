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
    public partial class Ejercicio2C11 : Form
    {
        FileStream archivo;
        public Ejercicio2C11()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            string nombre, ruta;
           
            byte[] informacion = new byte[200];
            nombre = NombreTextBox.Text;
            ruta =  @""+RutaTextBox.Text; 
            
            if (File.Exists(ruta + "/" + nombre + ".txt"))
            {
                archivo = new FileStream(ruta + "/" + nombre + ".txt", FileMode.Open);
                archivo.Read(informacion, 0, (int)archivo.Length);
                MostrarRichTextBox.Text += ASCIIEncoding.ASCII.GetString(informacion);
                archivo.Close();
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
