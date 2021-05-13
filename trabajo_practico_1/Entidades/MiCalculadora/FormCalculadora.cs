using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Cerrará el formulario
        /// </summary>
        /// <param name="sender">objeto</param>
        /// <param name="e">evento</param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// convertirá el resultado, de existir, a binario.
        /// </summary>
        /// <param name="sender">objeto</param>
        /// <param name="e">evento</param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string lblResult = lblResultado.Text;

            if (lblResult != String.Empty)
            {
                lblResultado.Text = String.Empty;
                Numero numero = new Numero(lblResult);
                lblResultado.Text = numero.DecimalBinario(lblResult);
                btnConvertirABinario.Enabled = false;
                btnConvertirADecimal.Enabled = true;
            }
            else
            {
                lblResultado.Text = "Sin un resultado para convertir";
            }
        }
        /// <summary>
        /// convertirá el resultado, de existir y ser binario, a decimal.
        /// </summary>
        /// <param name="sender">objeto</param>
        /// <param name="e">evento</param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string lblResult = lblResultado.Text;
            string message = String.Empty;

            if (lblResult != String.Empty)
            {
                Numero numero = new Numero(lblResult);
                message = numero.BinarioDecimal(lblResult);
                lblResultado.Text = message;
                if (lblResultado.Text != "Sin un resultado válido para convertir" && lblResultado.Text != "Valor inválido")
                {
                    btnConvertirADecimal.Enabled = false;
                    btnConvertirABinario.Enabled = true;
                }
            }
            else
            {
                lblResultado.Text = "Sin un resultado válido para convertir";
            }
        }
        /// <summary>
        /// Al dar click al btnLimpiar llamará al metodo Limpiar que se encarga de dejar sin texto diferentes controles
        /// </summary>
        /// <param name="sender">objeto</param>
        /// <param name="e">evento</param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Verifica que los campos esten correctos y realiza la operacion
        /// </summary>
        /// <param name="sender">objeto</param>
        /// <param name="e">evento</param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string numero1 = txtNumero1.Text.Replace(',', '.');
            string numero2 = txtNumero2.Text.Replace(',', '.');
            string operador = cmbOperador.Text;
            double numeroValidado1;
            double numeroValidado2;
            bool validar1 = double.TryParse(numero1, out numeroValidado1);
            bool validar2 = double.TryParse(numero2, out numeroValidado2);

            //valido que los campos no esten vacios
            if (numero1 != String.Empty && numero2 != String.Empty && operador != String.Empty)
            {
                //valido que los valores pasados para operar sean correctos
                if (validar1 && validar2)
                {
                    double result = Operar(numero1, numero2, operador);
                    //Ingreso el resultado por pantalla
                    lblResultado.Text = result.ToString();
                }
                else
                {
                    lblResultado.Text = "Valor/es Incorrecto/s para realizar la operación";
                }
            }
            else
            {
                lblResultado.Text = "Faltan campos para realizar la operación";
            }

            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = true;
        }
        /// <summary>
        /// será llamado por el evento click del botón btnLimpiar y borrará los datos de los TextBox, ComboBox y Label de la pantalla.
        /// </summary>
        private void Limpiar()
        {
            //TextBox
            txtNumero1.Text = String.Empty;
            txtNumero2.Text = String.Empty;
            //ComboBox
            cmbOperador.Text = String.Empty;
            //Label
            lblResultado.Text = String.Empty;
            //enabled botones
            //se suman estas dos lineas para volver habilitar los botones
            btnConvertirADecimal.Enabled = true;
            btnConvertirABinario.Enabled = true;
        }
        /// <summary>
        /// llamará al método Operar de Calculadora y retornar el resultado al método de evento del botón btnOperar que reflejará el resultado en el Label txtResultado.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>operacion entre los numeros y el operador</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            //Los strings los convierto a Numero utilizando el constructor de la clase Numero de esta forma puedo pasarlos como parametros al metodo Operar
            Numero aux1 = new Numero(numero1);
            Numero aux2 = new Numero(numero2);

            double result = Calculadora.Operar(aux1, aux2, operador);

            return result;
        }
    }
}
