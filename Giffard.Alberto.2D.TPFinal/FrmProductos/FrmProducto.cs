using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmProductos
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
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
        }
    }
}
