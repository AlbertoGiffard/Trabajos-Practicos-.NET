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
namespace FrmClientes
{
    public partial class FrmCliente : Form
    {
        private BaseDeCompradores basePrincipal;
        private int stockDroide;
        private int stockTunica;
        private int stockSable;
        public FrmCliente()
        {
            InitializeComponent();
        }
        /// <summary>
        /// inicializa los atributos
        /// </summary>
        /// <param name="baseDeCompradores"></param>
        /// <param name="stockDroide"></param>
        /// <param name="stockTunica"></param>
        /// <param name="stockSable"></param>
        public FrmCliente(BaseDeCompradores baseDeCompradores, int stockDroide, int stockTunica, int stockSable) : this()
        {
            this.basePrincipal = baseDeCompradores;
            this.stockDroide = stockDroide;
            this.stockTunica = stockTunica;
            this.stockSable = stockSable;
        }
        public int StockDroide
        {
            get
            {
                return this.stockDroide;
            }
        }
        public int StockTunica
        {
            get
            {
                return this.stockTunica;
            }
        }
        public int StockSable
        {
            get
            {
                return this.stockSable;
            }
        }
        /// <summary>
        /// Si todos los campos están correctos guarda el nuevo cliente en el listado y en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = BaseDeCompradores.IdMasAlto(this.basePrincipal);
                //Le sumamos uno al ID
                id++;
                bool esRebelde = radioBtnSiRebelde.Checked;

                if (txtNombre.Text != String.Empty)
                {
                    Cliente nuevoCliente = new Cliente(id, txtNombre.Text, esRebelde);
                    try
                    {
                        this.basePrincipal += nuevoCliente;

                        Conexion.GuardarCliente(nuevoCliente);

                        MessageBox.Show("Cargado Correctamente!\nYa puedes empezar a comprar", "Excelente");

                        FrmProductos.FrmProducto frmProducto1 = new FrmProductos.FrmProducto(nuevoCliente, this.stockDroide, this.stockTunica, this.stockSable);
                        frmProducto1.ShowDialog();

                        this.stockDroide = frmProducto1.StockDroide;
                        this.stockTunica = frmProducto1.StockTunica;
                        this.stockSable = frmProducto1.StockSable;

                        this.Close();
                    }
                    catch (ClienteExisteException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Te falta un nombre galáctico", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
