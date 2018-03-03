using PruebasVectores.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebasVectores
{
    
    public partial class Form1 : Form
    {
       

        


        public Form1()
        {
            InitializeComponent();
        }


            int v;


        private void BTCargar_Click(object sender, EventArgs e)
        {
            

            v = Convert.ToInt16( TBTamanyo.Text);

           
            Libro [] vlib = new Libro[v];


            


        }

        private void button1_Click(object sender, EventArgs e)
        {

            String titulo, autor;
            int numPag;
            int i;
            Libro[] vlib = new Libro[v];
            for (i=0; i < vlib.Length; i++)
            {
            titulo = TBTitulo.Text;
            autor = TBAutor.Text;
            numPag = Convert.ToInt16(TBNumeropaginas.Text);
            Libro l1 = new Libro(titulo,autor,numPag);
                vlib[i] = l1;
             
                CBXMostrar.Text =l1.Titulo1+ l1.Autor+l1.NumPaginas;
            }


            TBTitulo.Text = "";
            TBAutor.Text = "";
            TBNumeropaginas.Text = "";

          

        }
   
        private void CBXMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //for (int i = 0; i < length; i++)
            //{

            //}
        }
    }
}
