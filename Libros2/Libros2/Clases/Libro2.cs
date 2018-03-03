using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros2.Clases
{
    class Libro2
    {

        /// <summary>
        /// VARIABLES 
        /// </summary>
        private String titulo;
        private String autor;
        private String contenido;
        private String colorPortada;
        private String dimensiones;
        private int any;
        private int numPaginas;
        //FIN VARIABLES


        //CONSTRUCTORES

        public Libro2()
        {

        }
        public Libro2(String titulo, String autor, String contenido, String colorPortada, String dimensiones, int any, int numPaginaS)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.ColorPortada = colorPortada;
            this.Contenido = contenido;
            this.Dimensiones = dimensiones;
            this.Any = any;
            this.NumPaginas = numPaginaS;
        }

        //FIN CONSTRUCTORES

        ///METODOS
        ///
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Contenido { get => contenido; set => contenido = value; }
        public string ColorPortada { get => colorPortada; set => colorPortada = value; }
        public string Dimensiones { get => dimensiones; set => dimensiones = value; }
        public int Any { get => any; set => any = value; }
        public int NumPaginas { get => numPaginas; set => numPaginas = value; }

        //FIN METODOS
    }
}
