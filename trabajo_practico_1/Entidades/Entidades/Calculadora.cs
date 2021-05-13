using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Validará y realizará la operacion pedida entre ambos números
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>operacion entre los primeros dos parametros validando el operador como tercer parametro</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double result = double.MinValue;
            char[] charOperador = operador.ToCharArray();
            string operadorValidado = ValidarOperador(charOperador[0]);

            switch (operadorValidado)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    result = num1 / num2;
                    break;

                default:
                    break;
            }

            return result;
        }
        /// <summary>
        /// Validará que el operador recibido sea +,-,* ó /, caso contrario RETORNARA +
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>un operador valido</returns>
        private static string ValidarOperador(char operador)
        {
            string result = "+";

            //en el caso que no se cumpla ninguno de los tres casos retorno '+'
            switch (operador)
            {
                case '-':
                    result = "-";
                    break;

                case '*':
                    result = "*";
                    break;

                case '/':
                    result = "/";
                    break;

                default:
                    break;
            }

            return result;
        }
    }
}
