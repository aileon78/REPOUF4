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
    public partial class FRGastosdiarios : Form
    {
        public FRGastosdiarios()
        {
            InitializeComponent();
        }

        private void BTingresar_Click(object sender, EventArgs e)
        {
            //variables
            double[] vGastos;
            double gasto, totalGasto, diaMAyor, gastoMayor;
            int cantDias;
            //inicializar variables
            totalGasto = 0; //empezamos con gasto de 0
            diaMAyor = 1; // el dia de mayor gaasto es el primero
            gastoMayor = 0;

            //empezamos a leer los gastos
            cantDias = Convert.ToInt32(TXTcantidaddias.Text);
            vGastos = new double[cantDias];

            for (int dia = 1; dia <= cantDias; dia=dia+1)
            {
                gasto = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el gasto del dia "+ dia,"Gastos"));
                vGastos[dia - 1] = gasto;


            }

            for (int i = 0; i < cantDias; i++)
            {
                //evaluamos el gasto mayor
                if (vGastos[i] > gastoMayor)
                {
                    gastoMayor = vGastos[i];
                    diaMAyor = i + 1;
                }
                //calculamos el total de gasto
                totalGasto = totalGasto + vGastos[i];

                //mostramos los astos en el combobox
                CBXgastos.Items.Add("dia" + (i + 1)+" Total : "+vGastos[i]);
            }
            //mostramos la informacion 
            TXTgastomayos.Text = Convert.ToString(gastoMayor);
            TXTdiamayor.Text = Convert.ToString(diaMAyor);
            TXTtotalgastos.Text = Convert.ToString(totalGasto);

        }

        private void BTnuevo_Click(object sender, EventArgs e)
        {
            TXTcantidaddias.Clear();
            TXTdiamayor.Clear();
            TXTgastomayos.Clear();
            TXTtotalgastos.Clear();
            CBXgastos.Items.Clear();

        }

        private void BTsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
