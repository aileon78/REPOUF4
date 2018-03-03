using System;

namespace AlumnoArray.Clases
{
    class Alumno
    {
        /// <summary>
        /// variables privadas
        /// </summary>
        private String nom;
        private String pcognom;
        private String scognom;
        private int edad;
        private int nota;

        //Constructores
        public Alumno()
        {

        }
        public Alumno(String nom, String pcognom, String scognom, int edad, int nota)
        {
            this.Nom = nom;
            this.Pcognom = pcognom;
            this.Scognom = scognom;
            this.Edad = edad;
            this.Nota = nota;

        }

        public string Nom { get => nom; set => nom = value; }
        public string Pcognom { get => pcognom; set => pcognom = value; }
        public string Scognom { get => scognom; set => scognom = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Nota { get => nota; set => nota = value; }
    }
}
