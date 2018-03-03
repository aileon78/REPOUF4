using Libros2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libros2
{
    public partial class Form1 : Form
    {


        Libro2 lglobal = new Libro2();

        public Form1()
        {
            InitializeComponent();
            BTMostrar.Enabled = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void BorrarDatos()
        {
            TBTitulo.Text = "";
            TBAutor.Text = "";
            TBContenido.Text = "";
            TBColorportada.Text = "";
            TBDimensiones.Text = "";
            TBAny.Text = "";
            TBNumpaginas.Text = "";


        }

        private void BTGuardar_Click(object sender, EventArgs e)
        {
            


            String titulo, autor, contenido, colorPortada, dimensiones;
            int any, numPaginas;
            titulo=TBTitulo.Text;
            autor = TBAutor.Text;
            contenido = TBContenido.Text;
            colorPortada = TBColorportada.Text;
            dimensiones = TBDimensiones.Text;
            any = Convert.ToInt32(TBAny.Text);
            numPaginas = Convert.ToInt32(TBNumpaginas.Text);

            Libro2 lib = new Libro2(titulo, autor, contenido, colorPortada, dimensiones, any, numPaginas);

            //guardamos el contenido de "lib" en una variable global para pasar los datos alboton mostrar
            lglobal = lib;
            BTMostrar.Enabled = true;

            BorrarDatos();



        }

        private void BTMostrar_Click(object sender, EventArgs e)
        {

            LBTitulo.Text = lglobal.Titulo;
            LBAutor.Text = lglobal.Autor;
            LBContenido.Text = lglobal.Contenido;
            LBColorportada.Text = lglobal.ColorPortada;
            LBDimensones.Text = lglobal.Dimensiones;
            LBAny.Text = Convert.ToString(lglobal.Any);
            LBNumeroPaginas.Text = Convert.ToString(lglobal.NumPaginas);



        }
    }
}
