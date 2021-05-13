using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;
        /// <summary>
        /// Se encarga de setear el valor string, realizando su respectiva validacion para guardarlo como el nuevo valor de double
        /// </summary>
        public string SetNumero
        {
            set
            {
                double doubleNumero = ValidarNumero(value);

                this.numero = doubleNumero;
            }
        }
        /// <summary>
        /// Asigna el valor 0 por defecto
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Constructor que recibe por parametro un valor de tipo double
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Constructor que recibe por parametro un valor de tipo string
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }
        /// <summary>
        /// trabajará con enteros positivos, validará que se trate de un binario y luego  convertirá ese número binario a decimal, en caso de ser posible. Caso contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>valor decimal</returns>
        public string BinarioDecimal(string binario)
        {
            int numeroPositivo;
            int charactersNumbers = binario.Length;
            char[] array;
            string result = "Valor inválido";
            double valorAux = 0;
            bool esBin = EsBinario(binario);

            if (esBin)
            {
                int.TryParse(binario, out numeroPositivo);
                if (numeroPositivo > 0)
                {
                    array = binario.ToCharArray();
                    // Invertido pues los valores van incrementandose de derecha a izquierda: 16-8-4-2-1
                    Array.Reverse(array);
                    foreach (char character in binario)
                    {
                        charactersNumbers--;
                        if (character == '1')
                        {
                            // Usamos la potencia de 2, según la posición
                            valorAux += (int)Math.Pow(2, charactersNumbers);
                        }
                    }
                    result = valorAux.ToString();
                }
            }

            return result;
        }
        /// <summary>
        /// convertirá un número decimal a binario, en caso de ser posible.Caso contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>valor binario</returns>
        public string DecimalBinario(double numero)
        {
            string result = string.Empty;
            double resultDiv = numero;
            int restoDiv;
            //Generamos dos variables una para verificar si el resultado de la division es igual a 0 y otra para verificar el resto
            if ((int)numero <= 0)
            {
                result = "Valor inválido";
            }
            else
            {
                while ((int)numero > 0)
                {
                    restoDiv = (int)(resultDiv % 2);
                    resultDiv /= 2;
                    result = restoDiv.ToString() + result;
                    numero /= 2;
                }
            }

            return result;
        }
        /// <summary>
        /// convertirá un número decimal a binario, en caso de ser posible.Caso contrario retornará "Valor inválido".
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>valor binario</returns>
        public string DecimalBinario(string numero)
        {
            string result = "Valor inválido";
            Numero doubleNumero = new Numero();

            doubleNumero.SetNumero = numero;
            result = DecimalBinario(doubleNumero.numero);

            return result;
        }
        /// <summary>
        /// validará que la cadena de caracteres esté compuesta SOLAMENTE por caracteres '0' o '1'.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>si el parametro es binario o no</returns>
        private bool EsBinario(string binario)
        {
            bool result = false;
            bool esNumero = false;
            int numeroAux;

            esNumero = int.TryParse(binario, out numeroAux);
            if (esNumero)
            {
                result = true;
                foreach (char c in binario)
                {
                    if (c != '0' && c != '1')
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }
        /// <summary>
        /// comprobará que el valor recibido sea numérico, y lo retornará en formato double. Caso contrario, retornará 0.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>valor numerico</returns>
        private double ValidarNumero(string strNumero)
        {
            double result = 0;
            bool esNumero = double.TryParse(strNumero, out result);
            //corrobora que si el resultado fue false, retorne 0
            if (!esNumero)
            {
                result = 0;
            }

            return result;
        }
        /// <summary>
        /// Realiza la operacion de la suma entre dos numeros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>suma de los parametros</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            double result = n1.numero + n2.numero;

            return result;
        }
        /// <summary>
        /// Realiza la operacion de la resta entre dos numeros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>resta de los parametros</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            double result = n1.numero - n2.numero;

            return result;
        }
        /// <summary>
        /// Realiza la operacion de la multiplicacion entre dos numeros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>multiplicacion de los parametros</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            double result = n1.numero * n2.numero;

            return result;
        }
        /// <summary>
        /// Realiza la operacion de la division entre dos numeros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>division de los parametros</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double result = double.MinValue;

            if (n2.numero != 0)
            {
                result = n1.numero / n2.numero;
            }

            return result;
        }

    }
}
