using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1DDDR
{
    class Cuenta
    {

        //atributos
        private String titular;
        private double cantidad;

        //constructores
        //public Cuenta(String titular)
        //{
        //    this(titular, 0);

        //}
        public Cuenta(String titular, double cantidad)
        {
            this.titular = titular;
            //Si la cantidad es menor que cero, lo ponemos a cero
            if (cantidad < 0)
            {
                this.cantidad = 0;
            }
            else
            {
                this.cantidad = cantidad;
            }


        }
        //Metodos
        public String getTitular()
        {
            return titular;
        }

        public void setTitular(String titular)
        {
            this.titular = titular;
        }

        public double getCantidad()
        {
            return cantidad;
        }

        public void setCantidad(double cantidad)
        {
            this.cantidad = cantidad;
        }

        //ingresar dinero solo si es positivo
        public void ingresar(double cantidad) {
            if (cantidad > 0)
            {

                this.cantidad = cantidad + cantidad;
            }

        }
        //retirar dinero 
        public void retirar(double cantidad)
        {
            if(this.cantidad - cantidad < 0)
            {
                this.cantidad = 0;
            }
            else
            {
                this.cantidad = cantidad - cantidad;
            }


        }
        public String toString()
        {

            return "El titular " + titular + " tiene " + cantidad + " euros en su cuanta.";
        }

    }
}
