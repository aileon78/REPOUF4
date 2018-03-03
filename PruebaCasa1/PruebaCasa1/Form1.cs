using PruebaCasa1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaCasa1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BSuma_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            operaciones op1 = new operaciones();



            if (TBnum1.Text == "" && MessageBox.Show("Introduzca un numero en el cuadro numero 1", "OPERACION",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
     == DialogResult.Yes)
            {




            }
            else if(TBnum2.Text == "" && MessageBox.Show("Introduzca un numero en el cuadro numero 2", "OPERACION",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
     == DialogResult.Yes)
            {

                


            }
            else
            {
                num1 = Convert.ToInt32(TBnum1.Text);

                num2 = Convert.ToInt32(TBnum2.Text);
                resultado = op1.Suma(num1, num2);
                Lresult.Text = Convert.ToString(resultado);
                TBnum1.Text = "";
                TBnum2.Text = "";


            }







        }

        private void BResta_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            operaciones op1 = new operaciones();


            if (TBnum1.Text == "" && MessageBox.Show("Introduzca un numero en el cuadro numero 1", "OPERACION",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
   == DialogResult.Yes)
            {




            }
            else if (TBnum2.Text == "" && MessageBox.Show("Introduzca un numero en el cuadro numero 2", "OPERACION",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
   == DialogResult.Yes)
            {




            }
            else
            {


                num1 = Convert.ToInt32(TBnum1.Text);

                num2 = Convert.ToInt32(TBnum2.Text);


                resultado = op1.Resta(num1, num2);

                Lresult.Text = Convert.ToString(resultado);

                TBnum1.Text = "";
                TBnum2.Text = "";
            }
        }
    }
}
