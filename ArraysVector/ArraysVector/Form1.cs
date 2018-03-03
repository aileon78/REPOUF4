using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysVector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTcargarvector_Click(object sender, EventArgs e)
        {
            //variables

            int[] notas = new int[5];

            //especifica notas
            notas[0] = 15;
            notas[1] = 13;
            notas[2] = 11;
            notas[3] = 16;
            notas[4] = 18;

            int suma = 0;
            double promedio;


            //PRoceso
            CBXnotas.Items.Clear();

            //recorreemos vector con un bucle for
            for (int i = 0; i < 4; i++)
            {
                //mostramos notas en combobox
                CBXnotas.Items.Add(notas[i]);
                suma = suma + notas[i];
            }
            promedio = suma / 5;

            //salida de informacion
            TXTpromedio.Text = Convert.ToString(promedio);

        }

        private void BTnuevo_Click(object sender, EventArgs e)
        {
            TXTpromedio.Clear();
            CBXnotas.Items.Clear();
        }

        private void BTsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
