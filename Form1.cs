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
            if (int.TryParse(cajadetexto1.Text, out int dato)& (int.TryParse(cajadetexto2.Text, out int dato2)))
            {
                if (dato > dato2)
                {
                    MessageBox.Show(dato + " es mayor que " + dato2);
                }
                if (dato < dato2)
                {
                    MessageBox.Show(dato + " es menor que " + dato2);
                }
                if (dato == dato2)
                {
                    MessageBox.Show(dato + " es igual que " + dato2);
                }

            }
            else
            {
                MessageBox.Show("por favor ingresa un dato válido");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
