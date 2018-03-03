using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLibro.clases
{
    class libro
    {
        //VARIABLES PRIVADAS

        private String titulo;
        private int numPaginas;
        private String autor;
        private String colorPortada;
        private String dimensiones;
        private String contenido;




        //METODOS Y CONSTRUCTORES

        public libro()
        {

        }

        public libro(String titulo, int numPaginas, String autor, String colorPortada, String dimensiones, String contenido)
        {
            this.Titulo = titulo;
            this.NumPaginas = numPaginas;
            this.Autor = autor;
            this.ColorPortada = colorPortada;
            this.Dimensiones = dimensiones;
            this.Contenido = contenido;


        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int NumPaginas { get => numPaginas; set => numPaginas = value; }
        public string Autor { get => autor; set => autor = value; }
        public string ColorPortada { get => colorPortada; set => colorPortada = value; }
        public string Dimensiones { get => dimensiones; set => dimensiones = value; }
        public string Contenido { get => contenido; set => contenido = value; }

        public String getTitulo() {

            return this.titulo;

        }
        public int getNumPaginas()
        {

            return this.numPaginas;
        }
        public String getAutor()
        {

            return this.autor;
        }
        public String getColorPortada()
        {
            return this.colorPortada;

        }
        public String getDimensiones()
        {

            return this.dimensiones;
        }
        public String getContenido()
        {
            return this.contenido;
        }

    }
}
