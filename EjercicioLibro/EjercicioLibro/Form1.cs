using EjercicioLibro.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioLibro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void BTizqu_Click(object sender, EventArgs e)
        {

            libro l1 = new libro("El gran libro",0,"Cela",null,"60x60",null);

            mostrarDatos(l1);



        }


        private void mostrarDatos(libro l)
        {
            TBtitol.Text = l.getTitulo();
            TBnumpag.Text = Convert.ToString(l.getNumPaginas());
            TBautor.Text = l.getAutor();
            TBcolorPort.Text = l.getColorPortada();
            TBdim.Text = l.getDimensiones();
            TBcont.Text = l.getContenido();


        }

        private void BTdere_Click(object sender, EventArgs e)
        {
            libro l1 = new libro("El Libro de la selva", 300, "Antonio Carm", "Roja", "80x60", "fantasia");

            mostrarDatos(l1);
        }
    }
}
