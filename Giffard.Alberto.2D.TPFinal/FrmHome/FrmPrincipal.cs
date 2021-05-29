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
namespace FrmHome
{
    public partial class FrmHome : Form
    {
        private BaseDeCompradores basePrincipal;
        private int stockDroide;
        private int stockTunica;
        private int stockSable;
        public FrmHome()
        {
            InitializeComponent();
            basePrincipal = new BaseDeCompradores("Base Principal");
            this.stockDroide = 3;
            this.stockTunica = 10;
            this.stockSable = 1;
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            Cliente c1 = new Cliente(1, "Anakin", false);
            Cliente c2 = new Cliente(2, "Leia", true);
            Cliente c3 = new Cliente(3, "Palpatine", false);
            Cliente c4 = new Cliente(4, "Kylo", false);
            //Productos
            Productos p1 = new Droide(Droide.TipoDroide.Astromecanico, 2, 6, 1999, true);
            //el d1 al no tener un tipo definido, se le agrega por default de tipo de trabajo
            Droide d1 = new Droide(5, 344, 9999, false);
            Sable s1 = new Sable(Sable.Cristales.Azul, 7, 799, false);
            Sable s2 = new Sable(Sable.Cristales.Rojo, 9, 1, 900, false);
            Tunica t1 = new Tunica(Tunica.Corte.Larga, Tunica.Color.Oscura, 145, 199, true);
            Tunica t2 = new Tunica(Tunica.Corte.Personalizada, Tunica.Color.Oscura, 1, 199, true);

            try
            {
                this.basePrincipal += c1;
                this.basePrincipal += c2;
                this.basePrincipal += c3;
                this.basePrincipal += c4;

                c1 += p1;
                c1 += d1;
                c2 += s1;
                c3 += s2;
                c3 += t1;
                c3 += t2;
            }
            catch (ClienteExisteException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            rchTxtBoxClientes.Text = this.basePrincipal.MostrarClientes();
        }

        public void ActualizarClientes()
        {
            rchTxtBoxClientes.Text = this.basePrincipal.MostrarClientes();
        }
        private void btnSi_Click(object sender, EventArgs e)
        {
            lblId.Visible = true;
            txtBoxId.Visible = true;
            btnConfirmarId.Visible = true;
        }

        private void btnConfirmarId_Click(object sender, EventArgs e)
        {
            int valueId = -1;
            if (int.TryParse(txtBoxId.Text, out valueId))
            {
                Cliente cliente = BaseDeCompradores.TraerCliente(this.basePrincipal, valueId);
                if(cliente is null)
                {
                    MessageBox.Show("No se encuentra el ID, mira en el listado a la derecha para verificar que hayas comprado con nosotros", "Error");
                    txtBoxId.Text = String.Empty;
                }
                else
                {
                    FrmProductos.FrmProducto frmProducto1 = new FrmProductos.FrmProducto(cliente, this.stockDroide, this.stockTunica, this.stockSable);

                    frmProducto1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Ese valor no es posible, solo numeros enteros");
                txtBoxId.Text = String.Empty;
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            lblId.Visible = false;
            txtBoxId.Visible = false;
            btnConfirmarId.Visible = false;

            FrmClientes.FrmCliente formCliente1 = new FrmClientes.FrmCliente(this.basePrincipal, this.stockDroide, this.stockTunica, this.stockSable);

            formCliente1.ShowDialog();

            this.ActualizarClientes();
        }
    }
}
