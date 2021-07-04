
namespace Deber2BJAC
{
    partial class FrmProductoBJAC
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
            this.label1 = new System.Windows.Forms.Label();
            this.P = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnPMC = new System.Windows.Forms.Button();
            this.btnCaduccion = new System.Windows.Forms.Button();
            this.dtcFechaE = new System.Windows.Forms.DateTimePicker();
            this.dtcFechaV = new System.Windows.Forms.DateTimePicker();
            this.cmbCV = new System.Windows.Forms.ComboBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecioU = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Location = new System.Drawing.Point(37, 127);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(69, 20);
            this.P.TabIndex = 1;
            this.P.Text = "PrecioU:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Código:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha E:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha V:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tipo:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(41, 317);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 49);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(236, 317);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(123, 53);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnPMC
            // 
            this.btnPMC.Location = new System.Drawing.Point(493, 317);
            this.btnPMC.Name = "btnPMC";
            this.btnPMC.Size = new System.Drawing.Size(174, 38);
            this.btnPMC.TabIndex = 10;
            this.btnPMC.Text = "Ordenar por mas caro";
            this.btnPMC.UseVisualStyleBackColor = true;
            this.btnPMC.Click += new System.EventHandler(this.btnPMC_Click);
            // 
            // btnCaduccion
            // 
            this.btnCaduccion.Location = new System.Drawing.Point(465, 384);
            this.btnCaduccion.Name = "btnCaduccion";
            this.btnCaduccion.Size = new System.Drawing.Size(243, 36);
            this.btnCaduccion.TabIndex = 11;
            this.btnCaduccion.Text = "Ordenar por caduccion";
            this.btnCaduccion.UseVisualStyleBackColor = true;
            this.btnCaduccion.Click += new System.EventHandler(this.btnCaduccion_Click);
            // 
            // dtcFechaE
            // 
            this.dtcFechaE.Location = new System.Drawing.Point(527, 26);
            this.dtcFechaE.Name = "dtcFechaE";
            this.dtcFechaE.Size = new System.Drawing.Size(200, 26);
            this.dtcFechaE.TabIndex = 12;
            // 
            // dtcFechaV
            // 
            this.dtcFechaV.Location = new System.Drawing.Point(527, 76);
            this.dtcFechaV.Name = "dtcFechaV";
            this.dtcFechaV.Size = new System.Drawing.Size(200, 26);
            this.dtcFechaV.TabIndex = 13;
            // 
            // cmbCV
            // 
            this.cmbCV.FormattingEnabled = true;
            this.cmbCV.Items.AddRange(new object[] {
            "Compra",
            "Venta"});
            this.cmbCV.Location = new System.Drawing.Point(115, 33);
            this.cmbCV.Name = "cmbCV";
            this.cmbCV.Size = new System.Drawing.Size(121, 28);
            this.cmbCV.TabIndex = 14;
            this.cmbCV.SelectionChangeCommitted += new System.EventHandler(this.cmbCV_SelectionChangeCommitted);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(136, 76);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 26);
            this.txtProducto.TabIndex = 15;
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProducto_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(136, 260);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 16;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(136, 214);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 26);
            this.nudCantidad.TabIndex = 17;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(136, 165);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 26);
            this.txtStock.TabIndex = 18;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // txtPrecioU
            // 
            this.txtPrecioU.Location = new System.Drawing.Point(136, 127);
            this.txtPrecioU.Name = "txtPrecioU";
            this.txtPrecioU.Size = new System.Drawing.Size(100, 26);
            this.txtPrecioU.TabIndex = 19;
            this.txtPrecioU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioU_KeyPress);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(438, 120);
            this.txtArea.Multiline = true;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(310, 166);
            this.txtArea.TabIndex = 20;
            // 
            // FrmProductoBJAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPrecioU);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.cmbCV);
            this.Controls.Add(this.dtcFechaV);
            this.Controls.Add(this.dtcFechaE);
            this.Controls.Add(this.btnCaduccion);
            this.Controls.Add(this.btnPMC);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.P);
            this.Controls.Add(this.label1);
            this.Name = "FrmProductoBJAC";
            this.Text = "Alvear Billy";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnPMC;
        private System.Windows.Forms.Button btnCaduccion;
        private System.Windows.Forms.DateTimePicker dtcFechaE;
        private System.Windows.Forms.DateTimePicker dtcFechaV;
        private System.Windows.Forms.ComboBox cmbCV;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecioU;
        private System.Windows.Forms.TextBox txtArea;
    }
}

