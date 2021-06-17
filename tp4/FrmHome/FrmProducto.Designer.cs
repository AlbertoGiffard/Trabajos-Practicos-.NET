
namespace FrmProductos
{
    partial class FrmProducto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.radioBtnSable = new System.Windows.Forms.RadioButton();
            this.radioBtnTunica = new System.Windows.Forms.RadioButton();
            this.radiobtnDroide = new System.Windows.Forms.RadioButton();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.numericModelo = new System.Windows.Forms.NumericUpDown();
            this.lblTipoDroide = new System.Windows.Forms.Label();
            this.cmbBoxTipoDroide = new System.Windows.Forms.ComboBox();
            this.lblTamanio = new System.Windows.Forms.Label();
            this.cmbBoxTamanioTunica = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cmbBoxColorTunica = new System.Windows.Forms.ComboBox();
            this.lblCristalSable = new System.Windows.Forms.Label();
            this.cmbBoxCristalSable = new System.Windows.Forms.ComboBox();
            this.lblHojasSable = new System.Windows.Forms.Label();
            this.numericHojasSable = new System.Windows.Forms.NumericUpDown();
            this.rchTxtBoxProductos = new System.Windows.Forms.RichTextBox();
            this.btnFabricar = new System.Windows.Forms.Button();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.descargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoTextotxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoBinariodatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoXMLxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirListadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textotxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binariodatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblComparar = new System.Windows.Forms.Label();
            this.rchTxtBoxComparar = new System.Windows.Forms.RichTextBox();
            this.grpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHojasSable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.BackColor = System.Drawing.Color.Yellow;
            this.lblPresentacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.ForeColor = System.Drawing.Color.Black;
            this.lblPresentacion.Location = new System.Drawing.Point(-66, 33);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(545, 38);
            this.lblPresentacion.TabIndex = 0;
            this.lblPresentacion.Text = "             Cuéntanos que quieres comprar";
            // 
            // grpProducto
            // 
            this.grpProducto.Controls.Add(this.radioBtnSable);
            this.grpProducto.Controls.Add(this.radioBtnTunica);
            this.grpProducto.Controls.Add(this.radiobtnDroide);
            this.grpProducto.ForeColor = System.Drawing.Color.Yellow;
            this.grpProducto.Location = new System.Drawing.Point(13, 104);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(578, 97);
            this.grpProducto.TabIndex = 1;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Qué producto quiere";
            // 
            // radioBtnSable
            // 
            this.radioBtnSable.AutoSize = true;
            this.radioBtnSable.Location = new System.Drawing.Point(415, 47);
            this.radioBtnSable.Name = "radioBtnSable";
            this.radioBtnSable.Size = new System.Drawing.Size(114, 24);
            this.radioBtnSable.TabIndex = 2;
            this.radioBtnSable.TabStop = true;
            this.radioBtnSable.Text = "Sable de luz";
            this.radioBtnSable.UseVisualStyleBackColor = true;
            this.radioBtnSable.CheckedChanged += new System.EventHandler(this.radioBtnSable_CheckedChanged);
            // 
            // radioBtnTunica
            // 
            this.radioBtnTunica.AutoSize = true;
            this.radioBtnTunica.Location = new System.Drawing.Point(233, 47);
            this.radioBtnTunica.Name = "radioBtnTunica";
            this.radioBtnTunica.Size = new System.Drawing.Size(74, 24);
            this.radioBtnTunica.TabIndex = 1;
            this.radioBtnTunica.TabStop = true;
            this.radioBtnTunica.Text = "Túnica";
            this.radioBtnTunica.UseVisualStyleBackColor = true;
            this.radioBtnTunica.CheckedChanged += new System.EventHandler(this.radioBtnTunica_CheckedChanged);
            // 
            // radiobtnDroide
            // 
            this.radiobtnDroide.AutoSize = true;
            this.radiobtnDroide.Location = new System.Drawing.Point(55, 47);
            this.radiobtnDroide.Name = "radiobtnDroide";
            this.radiobtnDroide.Size = new System.Drawing.Size(74, 24);
            this.radiobtnDroide.TabIndex = 0;
            this.radiobtnDroide.TabStop = true;
            this.radiobtnDroide.Text = "Droide";
            this.radiobtnDroide.UseVisualStyleBackColor = true;
            this.radiobtnDroide.CheckedChanged += new System.EventHandler(this.radiobtnDroide_CheckedChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.Yellow;
            this.lblProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.Black;
            this.lblProducto.Location = new System.Drawing.Point(615, 37);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(251, 31);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Productos comprados\r\n";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.Yellow;
            this.lblModelo.Location = new System.Drawing.Point(-87, 230);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(245, 29);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "                         Modelo";
            this.lblModelo.Visible = false;
            // 
            // numericModelo
            // 
            this.numericModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericModelo.Location = new System.Drawing.Point(187, 230);
            this.numericModelo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericModelo.Name = "numericModelo";
            this.numericModelo.Size = new System.Drawing.Size(120, 28);
            this.numericModelo.TabIndex = 5;
            this.numericModelo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericModelo.Visible = false;
            // 
            // lblTipoDroide
            // 
            this.lblTipoDroide.AutoSize = true;
            this.lblTipoDroide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDroide.ForeColor = System.Drawing.Color.Yellow;
            this.lblTipoDroide.Location = new System.Drawing.Point(-56, 300);
            this.lblTipoDroide.Name = "lblTipoDroide";
            this.lblTipoDroide.Size = new System.Drawing.Size(213, 29);
            this.lblTipoDroide.TabIndex = 6;
            this.lblTipoDroide.Text = "                         Tipo";
            this.lblTipoDroide.Visible = false;
            // 
            // cmbBoxTipoDroide
            // 
            this.cmbBoxTipoDroide.FormattingEnabled = true;
            this.cmbBoxTipoDroide.Location = new System.Drawing.Point(187, 300);
            this.cmbBoxTipoDroide.Name = "cmbBoxTipoDroide";
            this.cmbBoxTipoDroide.Size = new System.Drawing.Size(156, 28);
            this.cmbBoxTipoDroide.TabIndex = 7;
            this.cmbBoxTipoDroide.Visible = false;
            // 
            // lblTamanio
            // 
            this.lblTamanio.AutoSize = true;
            this.lblTamanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanio.ForeColor = System.Drawing.Color.Yellow;
            this.lblTamanio.Location = new System.Drawing.Point(241, 227);
            this.lblTamanio.Name = "lblTamanio";
            this.lblTamanio.Size = new System.Drawing.Size(102, 29);
            this.lblTamanio.TabIndex = 8;
            this.lblTamanio.Text = "Tamaño";
            this.lblTamanio.Visible = false;
            // 
            // cmbBoxTamanioTunica
            // 
            this.cmbBoxTamanioTunica.FormattingEnabled = true;
            this.cmbBoxTamanioTunica.Location = new System.Drawing.Point(231, 266);
            this.cmbBoxTamanioTunica.Name = "cmbBoxTamanioTunica";
            this.cmbBoxTamanioTunica.Size = new System.Drawing.Size(121, 28);
            this.cmbBoxTamanioTunica.TabIndex = 9;
            this.cmbBoxTamanioTunica.Visible = false;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.Yellow;
            this.lblColor.Location = new System.Drawing.Point(258, 311);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(72, 29);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color";
            this.lblColor.Visible = false;
            // 
            // cmbBoxColorTunica
            // 
            this.cmbBoxColorTunica.FormattingEnabled = true;
            this.cmbBoxColorTunica.Location = new System.Drawing.Point(231, 352);
            this.cmbBoxColorTunica.Name = "cmbBoxColorTunica";
            this.cmbBoxColorTunica.Size = new System.Drawing.Size(121, 28);
            this.cmbBoxColorTunica.TabIndex = 11;
            this.cmbBoxColorTunica.Visible = false;
            // 
            // lblCristalSable
            // 
            this.lblCristalSable.AutoSize = true;
            this.lblCristalSable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCristalSable.ForeColor = System.Drawing.Color.Yellow;
            this.lblCristalSable.Location = new System.Drawing.Point(423, 230);
            this.lblCristalSable.Name = "lblCristalSable";
            this.lblCristalSable.Size = new System.Drawing.Size(349, 29);
            this.lblCristalSable.TabIndex = 12;
            this.lblCristalSable.Text = "Color del cristal                            ";
            this.lblCristalSable.Visible = false;
            // 
            // cmbBoxCristalSable
            // 
            this.cmbBoxCristalSable.FormattingEnabled = true;
            this.cmbBoxCristalSable.Location = new System.Drawing.Point(421, 266);
            this.cmbBoxCristalSable.Name = "cmbBoxCristalSable";
            this.cmbBoxCristalSable.Size = new System.Drawing.Size(121, 28);
            this.cmbBoxCristalSable.TabIndex = 13;
            this.cmbBoxCristalSable.Visible = false;
            // 
            // lblHojasSable
            // 
            this.lblHojasSable.AutoSize = true;
            this.lblHojasSable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHojasSable.ForeColor = System.Drawing.Color.Yellow;
            this.lblHojasSable.Location = new System.Drawing.Point(423, 331);
            this.lblHojasSable.Name = "lblHojasSable";
            this.lblHojasSable.Size = new System.Drawing.Size(288, 29);
            this.lblHojasSable.TabIndex = 14;
            this.lblHojasSable.Text = "Cuantas Hojas                    ";
            this.lblHojasSable.Visible = false;
            // 
            // numericHojasSable
            // 
            this.numericHojasSable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericHojasSable.Location = new System.Drawing.Point(421, 363);
            this.numericHojasSable.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHojasSable.Name = "numericHojasSable";
            this.numericHojasSable.Size = new System.Drawing.Size(120, 28);
            this.numericHojasSable.TabIndex = 15;
            this.numericHojasSable.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHojasSable.Visible = false;
            // 
            // rchTxtBoxProductos
            // 
            this.rchTxtBoxProductos.Location = new System.Drawing.Point(615, 78);
            this.rchTxtBoxProductos.Name = "rchTxtBoxProductos";
            this.rchTxtBoxProductos.Size = new System.Drawing.Size(251, 347);
            this.rchTxtBoxProductos.TabIndex = 16;
            this.rchTxtBoxProductos.Text = "";
            // 
            // btnFabricar
            // 
            this.btnFabricar.BackColor = System.Drawing.Color.Yellow;
            this.btnFabricar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFabricar.Location = new System.Drawing.Point(187, 428);
            this.btnFabricar.Name = "btnFabricar";
            this.btnFabricar.Size = new System.Drawing.Size(232, 36);
            this.btnFabricar.TabIndex = 17;
            this.btnFabricar.Text = "Fabricar";
            this.btnFabricar.UseVisualStyleBackColor = false;
            this.btnFabricar.Click += new System.EventHandler(this.btnFabricar_Click);
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.ForeColor = System.Drawing.Color.Yellow;
            this.lblPresupuesto.Location = new System.Drawing.Point(-99, 396);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(269, 29);
            this.lblPresupuesto.TabIndex = 18;
            this.lblPresupuesto.Text = "                   Presupuesto:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(1, 438);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 19;
            this.txtTotal.Text = "$0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descargarToolStripMenuItem,
            this.abrirListadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1157, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // descargarToolStripMenuItem
            // 
            this.descargarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comoTextotxtToolStripMenuItem,
            this.comoBinariodatToolStripMenuItem,
            this.comoXMLxmlToolStripMenuItem});
            this.descargarToolStripMenuItem.Name = "descargarToolStripMenuItem";
            this.descargarToolStripMenuItem.Size = new System.Drawing.Size(172, 20);
            this.descargarToolStripMenuItem.Text = "Guardar listado de productos";
            // 
            // comoTextotxtToolStripMenuItem
            // 
            this.comoTextotxtToolStripMenuItem.Name = "comoTextotxtToolStripMenuItem";
            this.comoTextotxtToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.comoTextotxtToolStripMenuItem.Text = "Como texto (.txt)";
            this.comoTextotxtToolStripMenuItem.Click += new System.EventHandler(this.comoTextotxtToolStripMenuItem_Click);
            // 
            // comoBinariodatToolStripMenuItem
            // 
            this.comoBinariodatToolStripMenuItem.Name = "comoBinariodatToolStripMenuItem";
            this.comoBinariodatToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.comoBinariodatToolStripMenuItem.Text = "Como binario (.dat)";
            this.comoBinariodatToolStripMenuItem.Click += new System.EventHandler(this.comoBinariodatToolStripMenuItem_Click);
            // 
            // comoXMLxmlToolStripMenuItem
            // 
            this.comoXMLxmlToolStripMenuItem.Name = "comoXMLxmlToolStripMenuItem";
            this.comoXMLxmlToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.comoXMLxmlToolStripMenuItem.Text = "Como XML (.xml)";
            this.comoXMLxmlToolStripMenuItem.Click += new System.EventHandler(this.comoXMLxmlToolStripMenuItem_Click);
            // 
            // abrirListadoToolStripMenuItem
            // 
            this.abrirListadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textotxtToolStripMenuItem,
            this.binariodatToolStripMenuItem,
            this.xmlxmlToolStripMenuItem});
            this.abrirListadoToolStripMenuItem.Name = "abrirListadoToolStripMenuItem";
            this.abrirListadoToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.abrirListadoToolStripMenuItem.Text = "Cargar lista a comparar";
            // 
            // textotxtToolStripMenuItem
            // 
            this.textotxtToolStripMenuItem.Name = "textotxtToolStripMenuItem";
            this.textotxtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.textotxtToolStripMenuItem.Text = "Texto (.txt)";
            this.textotxtToolStripMenuItem.Click += new System.EventHandler(this.textotxtToolStripMenuItem_Click);
            // 
            // binariodatToolStripMenuItem
            // 
            this.binariodatToolStripMenuItem.Name = "binariodatToolStripMenuItem";
            this.binariodatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.binariodatToolStripMenuItem.Text = "Binario (.dat)";
            this.binariodatToolStripMenuItem.Click += new System.EventHandler(this.binariodatToolStripMenuItem_Click);
            // 
            // xmlxmlToolStripMenuItem
            // 
            this.xmlxmlToolStripMenuItem.Name = "xmlxmlToolStripMenuItem";
            this.xmlxmlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xmlxmlToolStripMenuItem.Text = "Xml (.xml)";
            this.xmlxmlToolStripMenuItem.Click += new System.EventHandler(this.xmlxmlToolStripMenuItem_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(1024, 433);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 36);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblComparar
            // 
            this.lblComparar.AutoSize = true;
            this.lblComparar.BackColor = System.Drawing.Color.Yellow;
            this.lblComparar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComparar.ForeColor = System.Drawing.Color.Black;
            this.lblComparar.Location = new System.Drawing.Point(928, 37);
            this.lblComparar.Name = "lblComparar";
            this.lblComparar.Size = new System.Drawing.Size(312, 31);
            this.lblComparar.TabIndex = 22;
            this.lblComparar.Text = "Lista a comparar                    \r\n";
            // 
            // rchTxtBoxComparar
            // 
            this.rchTxtBoxComparar.Location = new System.Drawing.Point(894, 78);
            this.rchTxtBoxComparar.Name = "rchTxtBoxComparar";
            this.rchTxtBoxComparar.Size = new System.Drawing.Size(251, 347);
            this.rchTxtBoxComparar.TabIndex = 23;
            this.rchTxtBoxComparar.Text = "Sin nada con que comparar...";
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 476);
            this.Controls.Add(this.rchTxtBoxComparar);
            this.Controls.Add(this.lblComparar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblPresupuesto);
            this.Controls.Add(this.btnFabricar);
            this.Controls.Add(this.rchTxtBoxProductos);
            this.Controls.Add(this.numericHojasSable);
            this.Controls.Add(this.lblHojasSable);
            this.Controls.Add(this.cmbBoxCristalSable);
            this.Controls.Add(this.lblCristalSable);
            this.Controls.Add(this.cmbBoxColorTunica);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cmbBoxTamanioTunica);
            this.Controls.Add(this.lblTamanio);
            this.Controls.Add(this.cmbBoxTipoDroide);
            this.Controls.Add(this.lblTipoDroide);
            this.Controls.Add(this.numericModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.grpProducto);
            this.Controls.Add(this.lblPresentacion);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Que vas a querer?";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHojasSable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.RadioButton radioBtnSable;
        private System.Windows.Forms.RadioButton radioBtnTunica;
        private System.Windows.Forms.RadioButton radiobtnDroide;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.NumericUpDown numericModelo;
        private System.Windows.Forms.Label lblTipoDroide;
        private System.Windows.Forms.ComboBox cmbBoxTipoDroide;
        private System.Windows.Forms.Label lblTamanio;
        private System.Windows.Forms.ComboBox cmbBoxTamanioTunica;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cmbBoxColorTunica;
        private System.Windows.Forms.Label lblCristalSable;
        private System.Windows.Forms.ComboBox cmbBoxCristalSable;
        private System.Windows.Forms.Label lblHojasSable;
        private System.Windows.Forms.NumericUpDown numericHojasSable;
        private System.Windows.Forms.RichTextBox rchTxtBoxProductos;
        private System.Windows.Forms.Button btnFabricar;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem descargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoTextotxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoBinariodatToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem comoXMLxmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirListadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textotxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binariodatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlxmlToolStripMenuItem;
        private System.Windows.Forms.Label lblComparar;
        private System.Windows.Forms.RichTextBox rchTxtBoxComparar;
    }
}

