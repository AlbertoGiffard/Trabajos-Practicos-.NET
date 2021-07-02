using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Biblioteca;
namespace FrmHome
{
    public delegate void MostrarEstado();
    public partial class FrmPrincipal : Form
    {
        private BaseDeCompradores basePrincipal;
        private int stockDroide;
        private int stockTunica;
        private int stockSable;
        private bool darDeBaja;
        private SoundPlayer audio;
        private Thread status;
        private Posicion posicion;
        /// <summary>
        /// Inicializa el stock de los productos y la base
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();
            basePrincipal = new BaseDeCompradores("Base Principal");
            this.stockDroide = 3;
            this.stockTunica = 10;
            this.stockSable = 1;
            darDeBaja = false;
            posicion = Posicion.SinDefinir;
        }
        /// <summary>
        /// Se crean objetos de pruebas para que cuente con informacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmHome_Load(object sender, EventArgs e)
        {
            audio = new SoundPlayer(FrmHome.Properties.Resources.cantina);
            audio.PlayLooping();

            //VERSION SIN BASE DE DATOS
            //Cliente c1 = new Cliente(1, "Anakin", false);
            //Cliente c2 = new Cliente(2, "Leia", true);
            //Cliente c3 = new Cliente(3, "Palpatine", false);
            //Cliente c4 = new Cliente(4, "Kylo", false);
            ////Productos
            //Producto p1 = new Droide(Droide.TipoDroide.Astromecanico, 2, 6, 1999, true);
            ////el d1 al no tener un tipo definido, se le agrega por default de tipo de trabajo
            //Droide d1 = new Droide(5, 344, 9999, false);
            //Sable s1 = new Sable(Sable.Cristales.Azul, 7, 799, false);
            //Sable s2 = new Sable(Sable.Cristales.Rojo, 9, 1, 900, false);
            //Tunica t1 = new Tunica(Tunica.Corte.Corta, Tunica.Color.Oscura, 145, 199, true);
            //Tunica t2 = new Tunica(Tunica.Corte.Larga, Tunica.Color.Oscura, 1, 199, true);

            //try
            //{
            //    this.basePrincipal += c1;
            //    this.basePrincipal += c2;
            //    this.basePrincipal += c3;
            //    this.basePrincipal += c4;

            //    c1 += p1;
            //    c1 += d1;
            //    c2 += s1;
            //    c3 += s2;
            //    c3 += t1;
            //    c3 += t2;
            //}
            //catch (ClienteExisteException ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}


            //VERSION CON BASE DE DATOS
            this.ActualizarClientes();

            this.status = new Thread(this.CambiosEnElForm);
            status.Start();
        }
        private void CambiosEnElForm()
        {
            while (true)
            {
                this.BuscarPosicion();
            }
        }
        private void BuscarPosicion()
        {
            if (this.InvokeRequired)
            {
                MostrarEstado delegado = new MostrarEstado(this.BuscarPosicion);

                object[] objetoArray = new object[] { };

                this.Invoke(delegado, objetoArray);
            }
            else
            {
                switch (this.posicion)
                {
                    case Posicion.SinDefinir:
                        lblStatusCambiando.Text = "Aún sin definir";
                        break;

                    case Posicion.CreandoUsuario:
                        lblStatusCambiando.Text = "Creando nuevo cliente";
                        break;

                    case Posicion.Usuario:
                        lblStatusCambiando.Text = "Que quieres hacer cliente?";
                        break;

                    case Posicion.UsuarioFabricando:
                        lblStatusCambiando.Text = "Fabricando";
                        break;

                    case Posicion.UsuarioBaja:
                        lblStatusCambiando.Text = "Proceso de baja";
                        break;

                    case Posicion.UsuarioPreFabrica:
                        lblStatusCambiando.Text = "Quieres fabricar";
                        break;

                    case Posicion.Cerrando:
                        lblStatusCambiando.Text = "Cerrando...";
                        break;
                }
            }
        }
        /// <summary>
        /// Actualiza en el richTextBox la información
        /// </summary>
        public void ActualizarClientes()
        {
            List<Cliente> listaAux = Conexion.RetornarInformacionClientes();
            this.basePrincipal.RemoverTodosLosClientes();
            try
            {
                foreach (Cliente cliente in listaAux)
                {
                    this.basePrincipal += cliente;
                }
            }
            catch (ClienteExisteException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            rchTxtBoxClientes.Text = this.basePrincipal.MostrarClientes();
        }
        private void btnSi_Click(object sender, EventArgs e)
        {
            btnFabricar.Visible = true;
            btnDarBaja.Visible = true;
            lblId.Visible = false;
            txtBoxId.Visible = false;
            btnConfirmarId.Visible = false;
            this.posicion = Posicion.Usuario;
        }
        /// <summary>
        /// Abre un formulario de compra/ensamble
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmarId_Click(object sender, EventArgs e)
        {
            int valueId = -1;
            if (int.TryParse(txtBoxId.Text, out valueId))
            {
                Cliente cliente = BaseDeCompradores.TraerCliente(this.basePrincipal, valueId);
                if (cliente is null)
                {
                    MessageBox.Show("No se encuentra el ID, mira en el listado a la derecha para verificar que hayas comprado con nosotros", "Error");
                    txtBoxId.Text = String.Empty;
                }
                else
                {
                    if (this.darDeBaja)
                    {
                        try
                        {
                            this.DarDeBajaCliente(cliente);
                            MessageBox.Show("Eliminado Correctamente", "Ok");
                            this.ActualizarClientes();
                        }
                        catch (System.Data.SqlClient.SqlException)
                        {
                            MessageBox.Show("Este ID aún cuenta con productos, deben eliminarse primero");
                        }
                    }
                    else
                    {
                        this.posicion = Posicion.UsuarioFabricando;
                        this.AbrirFormularioProducto(cliente);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ese valor no es posible, solo numeros enteros", "error");
            }
            txtBoxId.Text = String.Empty;
            lblId.Visible = false;
            txtBoxId.Visible = false;
            btnConfirmarId.Visible = false;
            btnFabricar.Visible = false;
            btnDarBaja.Visible = false;
            this.posicion = Posicion.SinDefinir;
        }
        /// <summary>
        /// Abre el formulario para fabricar
        /// </summary>
        /// <param name="cliente"></param>
        private void AbrirFormularioProducto(Cliente cliente)
        {
            FrmProductos.FrmProducto frmProducto1 = new FrmProductos.FrmProducto(cliente, this.stockDroide, this.stockTunica, this.stockSable);

            frmProducto1.ShowDialog();

            this.stockDroide = frmProducto1.StockDroide;
            this.stockTunica = frmProducto1.StockTunica;
            this.stockSable = frmProducto1.StockSable;
        }
        private void DarDeBajaCliente(Cliente cliente)
        {
            Conexion.EliminarCliente(cliente);
        }
        /// <summary>
        /// abre un formulario de alta de cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_Click(object sender, EventArgs e)
        {
            lblId.Visible = false;
            txtBoxId.Visible = false;
            btnConfirmarId.Visible = false;
            btnFabricar.Visible = false;
            btnDarBaja.Visible = false;
            this.posicion = Posicion.CreandoUsuario;

            FrmClientes.FrmCliente formCliente1 = new FrmClientes.FrmCliente(this.basePrincipal, this.stockDroide, this.stockTunica, this.stockSable);

            formCliente1.ShowDialog();

            this.stockDroide = formCliente1.StockDroide;
            this.stockTunica = formCliente1.StockTunica;
            this.stockSable = formCliente1.StockSable;

            this.ActualizarClientes();
            this.posicion = Posicion.SinDefinir;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            lblId.Visible = true;
            txtBoxId.Visible = true;
            btnConfirmarId.Visible = true;
            this.darDeBaja = false;
            this.posicion = Posicion.UsuarioPreFabrica;
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            lblId.Visible = true;
            txtBoxId.Visible = true;
            btnConfirmarId.Visible = true;
            this.darDeBaja = true;
            this.posicion = Posicion.UsuarioBaja;
        }
        /// <summary>
        /// Nos indicara en que posicion está para mostrar en el form
        /// </summary>
        public enum Posicion
        {
            SinDefinir,
            CreandoUsuario,
            Usuario,
            UsuarioPreFabrica,
            UsuarioFabricando,
            UsuarioBaja,
            Cerrando,
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.posicion = Posicion.Cerrando;
            MessageBox.Show("Hasta la próxima");
            if (this.status.IsAlive)
            {
                this.status.Abort();
            }
        }
    }
}
