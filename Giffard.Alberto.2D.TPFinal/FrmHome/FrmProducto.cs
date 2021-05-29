using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Biblioteca;
namespace FrmProductos
{
    public partial class FrmProducto : Form
    {
        //Los precios para que no vayan a ser modficados los declaro como constantes
        private const int precioDroide = 1500;
        private const int precioTunica = 499;
        private const int precioSable = 7800;
        private int stockDroide;
        private int stockTunica;
        private int stockSable;
        private Cliente cliente;
        /// <summary>
        /// inicializo los campos con los enumerados posibles por cada producto
        /// </summary>
        public FrmProducto()
        {
            InitializeComponent();
            cmbBoxTipoDroide.DataSource = Enum.GetValues(typeof(Droide.TipoDroide));
            cmbBoxTamanioTunica.DataSource = Enum.GetValues(typeof(Tunica.Corte));
            cmbBoxColorTunica.DataSource = Enum.GetValues(typeof(Tunica.Color));
            cmbBoxCristalSable.DataSource = Enum.GetValues(typeof(Sable.Cristales));
        }

        public FrmProducto(Cliente cliente, int stockDroide, int stockTunica, int stockSable) : this()
        {
            this.cliente = cliente;
            this.stockDroide = stockDroide;
            this.stockTunica = stockTunica;
            this.stockSable = stockSable;
        }

        private void radiobtnDroide_CheckedChanged(object sender, EventArgs e)
        {
            lblModelo.Visible = true;
            numericModelo.Visible = true;
            lblTipoDroide.Visible = true;
            cmbBoxTipoDroide.Visible = true;

            lblTamanio.Visible = false;
            cmbBoxTamanioTunica.Visible = false;
            lblColor.Visible = false;
            cmbBoxColorTunica.Visible = false;
            lblCristalSable.Visible = false;
            cmbBoxCristalSable.Visible = false;
            lblHojasSable.Visible = false;
            numericHojasSable.Visible = false;

            txtTotal.Text = $"${precioDroide}";
        }

        private void radioBtnTunica_CheckedChanged(object sender, EventArgs e)
        {
            lblTamanio.Visible = true;
            cmbBoxTamanioTunica.Visible = true;
            lblColor.Visible = true;
            cmbBoxColorTunica.Visible = true;

            lblModelo.Visible = false;
            numericModelo.Visible = false;
            lblTipoDroide.Visible = false;
            cmbBoxTipoDroide.Visible = false;
            lblCristalSable.Visible = false;
            cmbBoxCristalSable.Visible = false;
            lblHojasSable.Visible = false;
            numericHojasSable.Visible = false;

            txtTotal.Text = $"${precioTunica}";
        }

        private void radioBtnSable_CheckedChanged(object sender, EventArgs e)
        {
            lblCristalSable.Visible = true;
            cmbBoxCristalSable.Visible = true;
            lblHojasSable.Visible = true;
            numericHojasSable.Visible = true;

            lblModelo.Visible = false;
            numericModelo.Visible = false;
            lblTipoDroide.Visible = false;
            cmbBoxTipoDroide.Visible = false;
            lblTamanio.Visible = false;
            cmbBoxTamanioTunica.Visible = false;
            lblColor.Visible = false;
            cmbBoxColorTunica.Visible = false;

            txtTotal.Text = $"${precioSable}";
        }
        /// <summary>
        /// Lista los productos comprados por el cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmProducto_Load(object sender, EventArgs e)
        {
            if (this.cliente is null)
            {
                rchTxtBoxProductos.Text = "ERROR\nNo hay productos cargados";
                MessageBox.Show("ERROR, no hay cliente cargado", "Error");
                this.Close();
            }
            else
            {
                rchTxtBoxProductos.Text = this.cliente.ListarProductos();
            }
        }
        /// <summary>
        /// Dependiendo de la compra y si todos los campos están correctos  suma el nuevo producto al listado de productos del cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFabricar_Click(object sender, EventArgs e)
        {
            bool modeloRebelde = false;
            if (this.cliente.EsRebelde == "Si")
            {
                modeloRebelde = true;
            }
            if (radiobtnDroide.Checked)
            {
                if (numericModelo.Value > 0 && numericModelo.Value <= 100)
                {
                    if (cmbBoxTipoDroide.SelectedItem is null)
                    {
                        MessageBox.Show("Error: No es un valor válido el tipo", "Error");
                        cmbBoxTipoDroide.SelectedIndex = 0;
                    }
                    else
                    {
                        try
                        {
                            Droide nuevoDroide = new Droide((Droide.TipoDroide)cmbBoxTipoDroide.SelectedItem, (int)numericModelo.Value, this.stockDroide, precioDroide, modeloRebelde);
                            if (nuevoDroide.Ensamblar(nuevoDroide))
                            {
                                this.cliente += nuevoDroide;
                                MessageBox.Show($"Ensamblando las partes del modelo {numericModelo.Value}", "Ensamblando");
                                MessageBox.Show($"Paciencia, hay que esperar el secado de la pintura", "Pintando Droide");
                                MessageBox.Show("Está listo, te llegará en 3 días a tu nave directamente\nGracias por comprarnos!", nuevoDroide.Entregar(nuevoDroide));
                                this.stockDroide--;
                            }
                            else
                            {
                                MessageBox.Show("Error: Fallaron las piezas y no se logro ensamblar el droide", "Error");
                            }
                        }
                        catch (SinStockException ex)
                        {
                            MessageBox.Show("Error: El imperio nos compró todos los droides, vuelva mañana.", ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: Debe ser un modelo entre 1 y 100", "Error");
                    numericModelo.Value = 1;
                }
            }
            else if (radioBtnTunica.Checked)
            {
                if (cmbBoxTamanioTunica.SelectedItem is null)
                {
                    MessageBox.Show("Error: No es un valor válido el tamaño", "Error");
                    cmbBoxTamanioTunica.SelectedIndex = 0;
                }
                else
                {
                    if (cmbBoxColorTunica.SelectedItem is null)
                    {
                        MessageBox.Show("Error: No es un valor válido el color", "Error");
                        cmbBoxColorTunica.SelectedIndex = 0;
                    }
                    else
                    {

                        try
                        {
                            Tunica nuevaTunica = new Tunica((Tunica.Corte)cmbBoxTamanioTunica.SelectedItem, (Tunica.Color)cmbBoxColorTunica.SelectedItem, this.stockTunica, precioTunica, modeloRebelde);
                            if (nuevaTunica.Ensamblar(nuevaTunica))
                            {
                                this.cliente += nuevaTunica;
                                MessageBox.Show($"Buscando tela {cmbBoxColorTunica.SelectedItem.ToString()}", "Creando Arreglo");
                                MessageBox.Show($"El droide que realiza el arreglo es algo lento...", "Confecionando Túnica");
                                MessageBox.Show("Está listo, te llegará en 3 días a tu nave directamente\nGracias por comprarnos!", nuevaTunica.Entregar(nuevaTunica));
                                this.stockTunica--;
                            }
                            else
                            {
                                MessageBox.Show("Error: El droide que realiza los arreglos dejo de funcionar", "Error");
                            }
                        }
                        catch (SinStockException ex)
                        {
                            MessageBox.Show("Los Jedi y Sith siempre tiran sus túnicas y las olvidan, por lo que hemos tenido mucha demanda.\nVuelva mañana por favor.", ex.Message);
                        }
                    }
                }
            }
            else
            {
                if (cmbBoxCristalSable.SelectedItem is null)
                {
                    MessageBox.Show("Error: No es un valor válido el color del cristal", "Error");
                    cmbBoxCristalSable.SelectedIndex = 0;
                }
                else
                {
                    if(numericHojasSable.Value > 0 && numericHojasSable.Value < 5)
                    {
                        try
                        {
                            Sable nuevoSable = new Sable((Sable.Cristales)cmbBoxCristalSable.SelectedItem, this.stockSable, precioSable, modeloRebelde);
                            if (nuevoSable.Ensamblar(nuevoSable))
                            {
                                this.cliente += nuevoSable;
                                MessageBox.Show($"El cristal es único por lo que lo andamos ensamblando con mucho cuidado.", "Ensamblando");
                                MessageBox.Show($"Recordando al gran Tío Ben, ahora posees un gran poder.", "Agregando las Hojas");
                                MessageBox.Show("Está listo, te llegará en 3 días a tu nave directamente.\nGracias por comprarnos!", nuevoSable.Entregar(nuevoSable));
                                this.stockSable--;
                            }
                            else
                            {
                                MessageBox.Show("Error: El cristal no te escogió.", "Error");
                            }
                        }
                        catch (SinStockException ex)
                        {
                            MessageBox.Show("Es muy caro crear un sable en estos días.\nVuelve dentro de un tiempo.", ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El sable debe ser menor a 5 hojas, te puedes hacer daño amigo.", "Error");
                        numericHojasSable.Value = 1;
                    }
                }
            }

            rchTxtBoxProductos.Text = this.cliente.ListarProductos();
        }
        /// <summary>
        /// Guarda el listado de productos como texto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comoTextotxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            string path = String.Empty;
            save.DefaultExt = ".txt";
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK && save.FileName != String.Empty)
            {
                //Obtiene la ruta
                path = save.FileName;

                try
                {
                    PuntoTxt.Guardar(rchTxtBoxProductos.Text, path);
                    MessageBox.Show("Guardados los productos correctamente!", "Ok");
                }
                catch (Exception exeception)
                {
                    MessageBox.Show("Error: " + exeception.Message);
                }
            }
        }
        /// <summary>
        /// Guarda el listado de productos como archivo binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comoBinariodatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            string path = String.Empty;
            save.DefaultExt = ".dat";
            save.Filter = "dat files (*.dat)|*.dat|All files (*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK && save.FileName != String.Empty)
            {
                //Obtiene la ruta
                path = save.FileName;

                try
                {
                    PuntoDat.Guardar(rchTxtBoxProductos.Text, path);
                    MessageBox.Show("Guardados los productos correctamente!", "Ok");
                }
                catch (Exception exeception)
                {
                    MessageBox.Show("Error: " + exeception.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
