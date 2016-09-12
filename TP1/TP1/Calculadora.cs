using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP1
{
    public class Calculadora
    {
        /// <summary>
        /// Resolver la operacion acorde a los numeros y la operacion informada.
        /// </summary>
        /// <param name="numero1">recibe primer numero como objeto de clase Numero</param>
        /// <param name="numero2">recibe segundo numero como objeto de clase Numero</param>
        /// <param name="operador">retorna el resultado de la operacion</param>
        /// <returns></returns>
        public double operar(Numero numero1, Numero numero2, string operador)
        {
            string opcion = validarOperador(operador);
            double res;
                switch (opcion)
                {
                    case "+":
                        res=  numero1.getNumero() + numero2.getNumero();
                        return res;
                        
                    case "-":
                        res= numero1.getNumero() - numero2.getNumero();
                        return res;
                    case "*":
                        res= numero1.getNumero() * numero2.getNumero();
                        return res;
                    case "/":
                        if (numero2.getNumero() == 0)
                            res= 0;
                        else
                            res= numero1.getNumero() / numero2.getNumero();
                        return res;

                }
                return 0;
            

        }


        /// <summary>
        /// Obtener y validar el tipo de operacion (+,-,*,/) a procesar en el metodo operar. 
        /// Si se ingresa otro simbolo devolvera x defecto +
        /// </summary>
        /// <param name="operador">recibe un parametro tipo string.</param>
        /// <returns>devuelve un string con el simbolo de la operacion validada</returns>
        public string validarOperador(string operador)
        {
            switch (operador)
            {
                case  "+":
                    return "+";
                case "-":
                    return "-";
                case "*":
                    return "*";
                case "/":
                    return "/";
                default:
                    return "+";
            }
        }
    }
}
