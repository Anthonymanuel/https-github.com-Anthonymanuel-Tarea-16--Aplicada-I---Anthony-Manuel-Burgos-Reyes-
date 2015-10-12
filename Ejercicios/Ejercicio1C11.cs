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
    public partial class Ejercicio1C11 : Form
    {
        public Ejercicio1C11()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            int cont = CadenaTextBox.Text.Length;
            byte[] leer = new byte[cont];
            MemoryStream memory = new MemoryStream(100);
           
            memory.Write(ASCIIEncoding.ASCII.GetBytes(CadenaTextBox.Text),0,cont);
            memory.Seek(0, SeekOrigin.Begin);
            memory.Read(leer, 0,cont);
            MostrarRichTextBox.Text = ASCIIEncoding.ASCII.GetString(leer);
        }
    }
}
