using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP1
{
    public class Numero
    {
        /// <summary>
        /// unico atributo. elemento con el que opera la calculadora. 
        /// </summary>
        private double _numero;

        /// <summary>
        /// Constructor x defecto que inicializa la clase Numero en 0.
        /// </summary>
        public Numero()
        { _numero = 0; }

        /// <summary>
        /// Constructor con sobrecarga double
        /// </summary>
        /// <param name="numero">recibe parametro segun atributo</param>
        public Numero(double numero)
        { _numero = numero; }

        /// <summary>
        /// constructor sobrecargado parametroc cadena de caracteres
        /// </summary>
        /// <param name="numero">inicializa el string pasado por parametro</param>
        public Numero(string numero)
        { setNumero(numero); }

        /// <summary>
        /// Metodo de lectura del atributo numero.
        /// </summary>
        /// <returns>retorna un double que es el numero</returns>
        public double getNumero()
        { return _numero; }

        /// <summary>
        /// asigna la cadena de caracteres validada y convertida a double.
        /// </summary>
        /// <param name="numero">recibe un string a convertir o parsear a double</param>
        private void setNumero(string numero)
        { _numero = validarNumero(numero); }


        /// <summary>
        /// conversor de una cadena de caracteres a double para poder operar. 
        /// En caso de no recibir una cadena de caracteres correcta (no double) retorna cero.
        /// </summary>
        /// <param name="numeroString">recibe el string informado en el textBox</param>
        /// <returns>retorna un double de la conversion de texto a double </returns>
        private static double validarNumero(string numeroString)
        {
            double aux;
            bool flag=double.TryParse(numeroString,out aux);
            if (!flag)
                return 0;
            else
                return aux;
        }
    }
}
