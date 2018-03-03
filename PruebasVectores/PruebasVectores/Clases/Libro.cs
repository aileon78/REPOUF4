using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasVectores.Clases
{
    class Libro
    {
        //variables

        String Titulo;
        String autor;
        int numPaginas;

        //constructores
        public Libro() { }

        public Libro(String Titulo, String autor, int numPaginas) {
            this.Titulo = Titulo;
            this.autor = autor;
            this.numPaginas = numPaginas;
        }

        public string Titulo1 { get => Titulo; set => Titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public int NumPaginas { get => numPaginas; set => numPaginas = value; }


    }
}
