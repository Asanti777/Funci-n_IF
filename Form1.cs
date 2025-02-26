using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Función_IF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            // obligar al usuario a que imgrese una edad válida
            if (int.TryParse(Botónparaedad.Text, out int edad))
            {
                MessageBox.Show("su edad es " + Botónparaedad.Text + " años");
            }
            else
            {
                MessageBox.Show("Por favor ingresa una edad válida.");
            }
        }
    }
}
