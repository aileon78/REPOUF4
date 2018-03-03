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
        /// <summary>
        /// variablesglobales para poder utilizar los botones izquierda derecha
        /// </summary>
        Libro2[] vectorGlobal = new Libro2[100];
        int cont = 0;  //controlamos la cantidad de veces que damos al boton guardad
        int pos = 0;//controlamos la posicion en la que nos movemos dentro del vector
        int pos2 = 0;

        //Libro2 lglobal = new Libro2();

        public Form1()
        {
            InitializeComponent();
            BTIzquierda.Enabled = false;

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

        ///GUARDAR
        private void BTGuardar_Click(object sender, EventArgs e)
        {



            String titulo, autor, contenido, colorPortada, dimensiones;
            int any, numPaginas;


            titulo = TBTitulo.Text;
            autor = TBAutor.Text;
            contenido = TBContenido.Text;
            colorPortada = TBColorportada.Text;
            dimensiones = TBDimensiones.Text;
            any = Convert.ToInt32(TBAny.Text);
            numPaginas = Convert.ToInt32(TBNumpaginas.Text);

            Libro2 lib = new Libro2(titulo, autor, contenido, colorPortada, dimensiones, any, numPaginas);

            //guardamos el contenido de "lib" en una variable global para pasar los datos alboton mostrar
            //lglobal = lib;
            //BTMostrar.Enabled = true;

            //A continuacion guardaremos el objeto en el vector con un contador para que vaya agregando 
            //automaticamente


            vectorGlobal[cont] = lib;
            cont++;

            BorrarDatos();

            if (pos < 0 || pos > 99 && pos2 < 0 || pos2 > 99)
            {

                BTIzquierda.Enabled = false;
                BTMostrar.Enabled = false;
            }
            else
            {
                BTIzquierda.Enabled = true;
                BTMostrar.Enabled = true;

            }





        }

        private void mostrarDatos(int num)
        {
            //este apartado comentado es para utilizar directamente el objeto
            //LBTitulo.Text = lglobal.Titulo;
            //LBAutor.Text = lglobal.Autor;
            //LBContenido.Text = lglobal.Contenido;
            //LBColorportada.Text = lglobal.ColorPortada;
            //LBDimensones.Text = lglobal.Dimensiones;
            //LBAny.Text = Convert.ToString(lglobal.Any);
            //LBNumeroPaginas.Text = Convert.ToString(lglobal.NumPaginas);


            //aqui utilizamos el vector de objetos pasandole una posicion por parametro
            LBTitulo.Text = vectorGlobal[num].Titulo;
            LBAutor.Text = vectorGlobal[num].Autor;
            LBContenido.Text = vectorGlobal[num].Contenido;
            LBColorportada.Text = vectorGlobal[num].ColorPortada;
            LBDimensones.Text = vectorGlobal[num].Dimensiones;
            LBAny.Text = Convert.ToString(vectorGlobal[num].Any);
            LBNumeroPaginas.Text = Convert.ToString(vectorGlobal[num].NumPaginas);


        }


        //Este es el boton derecha
        private void BTMostrar_Click(object sender, EventArgs e)
        {
            
            mostrarDatos(pos2);
            if (pos2 < cont-1)
            {

                
                pos2++;
            }
            if (pos2 >= cont-1)
            {
                BTMostrar.Enabled = false;
                BTIzquierda.Enabled = true;
            }





        }
        //boton izquierda
        private void BTIzquierda_Click(object sender, EventArgs e)
        {
            pos--;
            mostrarDatos(pos);
            if (pos <= cont)
            {
                BTMostrar.Enabled = true;
            }
            if(pos <= 0)
            {
                BTIzquierda.Enabled = false;
                BTMostrar.Enabled = true;
            }


            



        }
    }
}
