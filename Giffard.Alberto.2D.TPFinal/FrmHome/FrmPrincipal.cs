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
        public FrmHome()
        {
            InitializeComponent();
            basePrincipal = new BaseDeCompradores("Base Principal");
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            Cliente c1 = new Cliente(1, "Anakin", false);
            Cliente c2 = new Cliente(2, "Leia", true);
            Cliente c3 = new Cliente(3, "Palpatine", false);
            Cliente c4 = new Cliente(4, "Kylo", false);

            try
            {
                this.basePrincipal += c1;
                this.basePrincipal += c2;
                this.basePrincipal += c3;
                this.basePrincipal += c4;
            }
            catch (ClienteExisteException ex)
            {
                MessageBox.Show(ex.Message);
            }

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
                if(this.basePrincipal == valueId)
                {
                    //logica
                }
                else
                {
                    MessageBox.Show("No se encuentra el ID, mira en el listado a la derecha para verificar que hayas comprado con nosotros");
                    txtBoxId.Text = String.Empty;
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
        }
    }
}
