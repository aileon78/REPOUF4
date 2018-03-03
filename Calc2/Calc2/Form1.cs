using System;
using System.Windows.Forms;

namespace Calc2
{
    public partial class FCalc : Form
    {
        double num1, num2, resultado;
        char operacion;
        public FCalc()
        {
            InitializeComponent();
            
        }




        private void BT1_Click(object sender, EventArgs e)
        {


            TBMostrar.Text = TBMostrar.Text + "1";




        }

        private void BT2_Click(object sender, EventArgs e)
        {


            TBMostrar.Text = TBMostrar.Text + "2";
        }

        private void BT3_Click(object sender, EventArgs e)
        {


            TBMostrar.Text = TBMostrar.Text + "3";
        }

        private void BT4_Click(object sender, EventArgs e)
        {

            TBMostrar.Text = TBMostrar.Text + "4";

        }

        private void BT5_Click(object sender, EventArgs e)
        {

            TBMostrar.Text = TBMostrar.Text + "5";
        }

        private void BT6_Click(object sender, EventArgs e)
        {

            TBMostrar.Text = TBMostrar.Text + "6";
        }

        private void BT7_Click(object sender, EventArgs e)
        {

            TBMostrar.Text = TBMostrar.Text + "7";
        }

        private void BT8_Click(object sender, EventArgs e)
        {

            TBMostrar.Text = TBMostrar.Text + "8";
        }

        private void BT9_Click(object sender, EventArgs e)
        {

            TBMostrar.Text = TBMostrar.Text + "9";
        }



        int max = 20;
        private void BT0_Click(object sender, EventArgs e)
        {
            //TBMostrar.Text = TBMostrar.Text+"0";

                TBMostrar.Text = TBMostrar.Text + "0";
            BTPunto.Enabled = false;
            if (TBMostrar.Text == "0") {

                TBMostrar.Text = "0,";

            }

           



        }

        private void BTIgual_Click(object sender, EventArgs e)
        {


            if (operacion == '+')
            {
                habilita(false);
                num2 = Convert.ToDouble(TBMostrar.Text);
                TBMostrar.Text = "";
                resultado = num1 + num2;
                TBMostrar.Text = Convert.ToString(resultado);

            }

            if (operacion == '-')
            {
                habilita(false);
                num2 = Convert.ToDouble(TBMostrar.Text);
                TBMostrar.Text = "";
                resultado = num1 - num2;
                TBMostrar.Text = Convert.ToString(resultado);

            }
            if (operacion == '*')
            {
                habilita(false);
                num2 = Convert.ToDouble(TBMostrar.Text);
                TBMostrar.Text = "";
                resultado = num1 * num2;
                TBMostrar.Text = Convert.ToString(resultado);

            }
            if (operacion == '/')
            {
                habilita(false);
                num2 = Convert.ToDouble(TBMostrar.Text);
                TBMostrar.Text = "";
                resultado = num1 / num2;
                TBMostrar.Text = Convert.ToString(resultado);

            }




        }

        private void BTC_Click(object sender, EventArgs e)
        {
            BTPunto.Enabled = true;
            TBMostrar.Text = "";
            habilita(true);
        }

        private void TBMostrar_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void BTMultiplica_Click(object sender, EventArgs e)
        {
            BTPunto.Enabled = true;
            num1 = Convert.ToDouble(TBMostrar.Text);
            TBMostrar.Text = "";

            operacion = '*';
        }

        private void BTResta_Click(object sender, EventArgs e)
        {
            BTPunto.Enabled = true;
            num1 = Convert.ToDouble(TBMostrar.Text);
            TBMostrar.Text = "";

            operacion = '-';
        }

        private void BTPotencia_Click(object sender, EventArgs e)
        {
            habilita(false);
           
            num1 = Convert.ToDouble(TBMostrar.Text);
            num1 = Math.Pow(num1, 2);
            TBMostrar.Text = Convert.ToString(num1);
            
        }

        private void BTsqr_Click(object sender, EventArgs e)
        {
            habilita(false);
          
            num1 = Convert.ToDouble(TBMostrar.Text);
            num1 = Math.Sqrt(num1);
            TBMostrar.Text = Convert.ToString(num1);
           

        }


        
        private void BTPunto_Click(object sender, EventArgs e)
        {

            if (TBMostrar.Text == "")
            {

            TBMostrar.Text = "0,";
                BTPunto.Enabled = false;



            }
            else
            {
                TBMostrar.Text = TBMostrar.Text +",";
                BTPunto.Enabled = false;

            }

        
        }

        private void BToff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTSuma_Click(object sender, EventArgs e)
        {
           
            BTPunto.Enabled = true;
            num1 = Convert.ToDouble(TBMostrar.Text);
            TBMostrar.Text = "";

            operacion = '+';

        }

        private void BTDivide_Click(object sender, EventArgs e)
        {
            BTPunto.Enabled = true;
            num1 = Convert.ToDouble(TBMostrar.Text);
            TBMostrar.Text = "";

            operacion = '/';


        }

        private void habilita(Boolean h)
        {

            BT0.Enabled = h;
            BT1.Enabled = h;
            BT2.Enabled = h;

            BT3.Enabled = h;

            BT4.Enabled = h;

            BT5.Enabled = h;

            BT6.Enabled = h;

            BT7.Enabled = h;

            BT8.Enabled = h;

            BT9.Enabled = h;

            BTSuma.Enabled = h;

            BTResta.Enabled = h;

            BTMultiplica.Enabled = h;

            BTDivide.Enabled = h;
            BTPotencia.Enabled = h;
            BTsqr.Enabled = h;
            BTPunto.Enabled = h;

        }


    }
}
