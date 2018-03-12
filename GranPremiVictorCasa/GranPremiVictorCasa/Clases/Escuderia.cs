using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranPremiVictorCasa.Clases
{
    [Serializable]
    public class Escuderia
    {
        //variables privadas
        private String nomEsc;
        private String paisEsc;
        private int anyEsc;
        private String motorEsc;

        //Constructores
        public Escuderia()
        {
        }

        public Escuderia(string nomEsc, string paisEsc, int anyEsc, String motorEsc)
        {
            this.nomEsc = nomEsc;
            this.paisEsc = paisEsc;
            this.anyEsc = anyEsc;
            this.motorEsc = motorEsc;
        }

        //GETTERS Y SETTERS
        public string NomEsc { get => nomEsc; set => nomEsc = value; }
        public string PaisEsc { get => paisEsc; set => paisEsc = value; }
        public int AnyEsc { get => anyEsc; set => anyEsc = value; }
        public string MotorEsc { get => motorEsc; set => motorEsc = value; }


        //RESTA DE Mètodes

        private FileMode modeFitxer(Boolean afegir)
        {
            if (!afegir)
                return FileMode.Create;
            else
                return FileMode.Append;
        }


        /// <summary>
        /// PARA AÑADIR ESCUDERIAS
        /// </summary>
        /// <param name="fitxer"></param>
        /// <param name="afegir"></param>
        public void afegeixFitxerEscuderia( bool afegir = true,String fitxer = "fitxer/escuderia.dat")
        {

            // Per poder utilitzar el paràmetre boolea afegir
            //FileMode apertura = new FileMode();

            //if (afegir)
            //    apertura = FileMode.Append;
            //else
            //    apertura = FileMode.Create;
            FileMode mode = modeFitxer(afegir);

            //Stream str = File.Open(fitxer, FileMode.Append);
            //Stream str = File.Open(fitxer, apertura);


            Stream str = File.Open(fitxer, mode);

            var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            formatter.Serialize(str, this);
            str.Close();

        }
        /// <summary>
        /// PARA LEER LAS ESCUDERIAS
        /// </summary>
        /// <param name="arxiu"></param>
        /// <returns></returns>
        public Escuderia[] llegeixFitxerEscuderia(String arxiu = "fitxer/escuderia.dat")
        {
            // //////////////////////// //
            // LLEGIR OBJECTE EN FITXER //
            // //////////////////////// //
            Stream str = File.Open(arxiu, FileMode.Open);
            var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            int q = 0;
            Escuderia[] esc = new Escuderia[100];

            do
            {
                try
                {
                    esc[q] = (Escuderia)formatter.Deserialize(str);
                }
                catch
                {
                    //MessageBox.Show("Error al llegir el fitxer d'Objectes", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                q++;
            } while (esc[q - 1] != null);

            str.Close();
            return esc;
        }


        //CONTAREMOS LAS ESCUDERIAS DE DENTRO DEL FICHERO
        public int contaEscuderies()
        {
            int total = 0;

            Escuderia[] esc = new Escuderia[100];

            // llegim totes les escuderies
            esc = llegeixFitxerEscuderia();

            // busquem la escuderia
            while (esc[total] != null)
            {
                total++;
            }
            return total;
        }


        //MODIFICAREMOS LAS ESCUDERIAS
        public void modificarEscuderia()
        {

            // llegim totes les escuderies
            Escuderia[] esc = llegeixFitxerEscuderia();

            int i = 0;

            // busquem la escuderia
            do
            {
                // quant trobem la que volem borrar no la reescrivim
                if (esc[i].NomEsc.Equals(this.NomEsc))
                {
                    // La eliminem
                    eliminaEscuderia(esc[i].NomEsc);
                    // Afegim la nova escuderia
                    this.afegeixFitxerEscuderia();
                }
                i++;
            } while (esc[i] != null);


        }



        /// <summary>
        /// PARA BUSCAR LA ESCUDERIA Y RETORNARLA
        /// </summary>
        /// <param name="nomAutor"></param>
        /// <param name="fitxer"></param>
        /// <returns></returns>
        public Escuderia cercarEscuderia(String nomEsc, String fitxer = "fitxer/escuderia.dat")
        {
            // retorna un objecte autor si el troba
            // en cas que no trobe res torna un null

            Escuderia[] esc = new Escuderia[100];

            // leemos todas las escuderias
            esc = llegeixFitxerEscuderia();

            int i = 0;
            //buscamos la escuderia
            do
            {
                if (esc[i].NomEsc.Equals(nomEsc))
                    return esc[i];
                i++;
            } while (esc[i] != null);
            return null;



        }

        public void eliminaEscuderia(String nom_esc)
        {
            Escuderia[] esc = new Escuderia[100];

            // llegim totes les escuderies
            esc = llegeixFitxerEscuderia();

            int i = 0;
            // per comprovar la primera escriptura
            Boolean primer = true;

            // busquem la escuderia
            do
            {
                // quant trobem la que volem borrar no la reescrivim
                if (!esc[i].NomEsc.Equals(nom_esc))
                {
                    if (primer)
                    {
                        // generem fitxer nou
                        esc[i].afegeixFitxerEscuderia(false);
                        primer = false;
                    }
                    else
                    {
                        // afegim al fitxer
                        esc[i].afegeixFitxerEscuderia(true);
                    }
                }
                i++;
            } while (esc[i] != null);
        }


        public void eliminaEscuderia()
        {
            Escuderia[] esc = new Escuderia[100];

            // llegim totes les escuderies
            esc = llegeixFitxerEscuderia();

            int i = 0;
            Boolean primer = true;      // per comprovar la primera escriptura

            // busquem la escuderia
            do
            {
                // quant trobem la que volem borrar no la reescrivim
                if (this.Equals(esc[i]))
                {
                    if (primer)
                    {
                        // generem fitxer nou
                        esc[i].afegeixFitxerEscuderia(false);
                        primer = false;
                    }
                    else
                    {
                        // afegim al fitxer
                        esc[i].afegeixFitxerEscuderia(true);
                    }
                }
                i++;
            } while (esc[i] != null);
        }


    }
}
