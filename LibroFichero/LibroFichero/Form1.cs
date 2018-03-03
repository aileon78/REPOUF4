using LibroFichero.Clases;
using System;
using System.Windows.Forms;

namespace LibroFichero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void limpiarcampos()
        {
            TBTitulo.Text = "";
            TBAny.Text = "";
            TBAutor.Text = "";
            TBContenido.Text = "";
            TBPaginas.Text = "";
            CBDimensiones.Text = "";
            TBPaginas.Text = "";
            TBColor.Text = "";


        }

        private void BTGuardar_Click(object sender, EventArgs e)
        {


            String titulo, autor, color, contenido, dimensiones;
            int any, paginas;

            //int max = 10;

            titulo = TBTitulo.Text;
            autor = TBAutor.Text;
            color = TBColor.Text;
            contenido = TBContenido.Text;
            dimensiones = CBDimensiones.Text;
            any = Convert.ToInt32(TBAny.Text);
            paginas = Convert.ToInt32(TBPaginas.Text);


            Libro objLibro = new Libro(titulo, any, autor, color, contenido, dimensiones, paginas);

            objLibro.escriuObjecteTextFitxer(objLibro);

            limpiarcampos();


        }


        private int contarVector(Object[] obj)
        {
            int i = 0;
            do
            {
                if (obj[i] != null)
                {
                    i++;
                }
                else
                {
                    return i;
                }


            } while (i < obj.Length);



            return i;
        }

        private void mostrarDatos(Libro[] lli)
        {


            RTB1.Text = "";

            int numLibros = contarVector(lli);
            int i;
            for (i = 0; i < numLibros; i++)
            {
                RTB1.Text = RTB1.Text + "Titulo : " + lli[i].Titulo + "\n" +
                    "Autor : " + lli[i].Autor + "\n" +
                    "Año : " + lli[i].Any + "\n" +
                    "Color : " + lli[i].Color + "\n" +
                    "Contenido : " + lli[i].Contenido + "\n" +
                    "Dimensines : " + lli[i].Dimensiones + "\n" +
                    "Páginas : " + lli[i].NumPag + "\n\n";
            }


        }

        private void BTMostrar_Click(object sender, EventArgs e)
        {


            Libro[] lvec = new Libro[100];


            Libro l = new Libro();

            lvec = l.llegeixTextFitxer();

            mostrarDatos(lvec);



        }


    }
}
