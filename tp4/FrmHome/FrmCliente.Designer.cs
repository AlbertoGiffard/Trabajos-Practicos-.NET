
namespace FrmClientes
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.lblNuevoCliente = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpBoxRebelde = new System.Windows.Forms.GroupBox();
            this.radioBtnNoRebelde = new System.Windows.Forms.RadioButton();
            this.radioBtnSiRebelde = new System.Windows.Forms.RadioButton();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.grpBoxRebelde.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNuevoCliente
            // 
            this.lblNuevoCliente.AutoSize = true;
            this.lblNuevoCliente.BackColor = System.Drawing.Color.Yellow;
            this.lblNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoCliente.Location = new System.Drawing.Point(-32, 24);
            this.lblNuevoCliente.Name = "lblNuevoCliente";
            this.lblNuevoCliente.Size = new System.Drawing.Size(731, 37);
            this.lblNuevoCliente.TabIndex = 0;
            this.lblNuevoCliente.Text = "                         Alta Nuevo Cliente                         ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Yellow;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(179, 99);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 24);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(308, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 29);
            this.txtNombre.TabIndex = 2;
            // 
            // grpBoxRebelde
            // 
            this.grpBoxRebelde.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxRebelde.Controls.Add(this.radioBtnNoRebelde);
            this.grpBoxRebelde.Controls.Add(this.radioBtnSiRebelde);
            this.grpBoxRebelde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxRebelde.ForeColor = System.Drawing.Color.Yellow;
            this.grpBoxRebelde.Location = new System.Drawing.Point(195, 166);
            this.grpBoxRebelde.Name = "grpBoxRebelde";
            this.grpBoxRebelde.Size = new System.Drawing.Size(274, 96);
            this.grpBoxRebelde.TabIndex = 3;
            this.grpBoxRebelde.TabStop = false;
            this.grpBoxRebelde.Text = "Eres Rebelde?";
            // 
            // radioBtnNoRebelde
            // 
            this.radioBtnNoRebelde.AutoSize = true;
            this.radioBtnNoRebelde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnNoRebelde.Location = new System.Drawing.Point(166, 45);
            this.radioBtnNoRebelde.Name = "radioBtnNoRebelde";
            this.radioBtnNoRebelde.Size = new System.Drawing.Size(52, 24);
            this.radioBtnNoRebelde.TabIndex = 1;
            this.radioBtnNoRebelde.Text = "NO";
            this.radioBtnNoRebelde.UseVisualStyleBackColor = true;
            // 
            // radioBtnSiRebelde
            // 
            this.radioBtnSiRebelde.AutoSize = true;
            this.radioBtnSiRebelde.Checked = true;
            this.radioBtnSiRebelde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnSiRebelde.Location = new System.Drawing.Point(58, 45);
            this.radioBtnSiRebelde.Name = "radioBtnSiRebelde";
            this.radioBtnSiRebelde.Size = new System.Drawing.Size(45, 24);
            this.radioBtnSiRebelde.TabIndex = 0;
            this.radioBtnSiRebelde.TabStop = true;
            this.radioBtnSiRebelde.Text = "SI";
            this.radioBtnSiRebelde.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Yellow;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(240, 306);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(151, 43);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 361);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grpBoxRebelde);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNuevoCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "¡Bienvenido!";
            this.grpBoxRebelde.ResumeLayout(false);
            this.grpBoxRebelde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevoCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grpBoxRebelde;
        private System.Windows.Forms.RadioButton radioBtnNoRebelde;
        private System.Windows.Forms.RadioButton radioBtnSiRebelde;
        private System.Windows.Forms.Button btnConfirmar;
    }
}

