namespace Presentacion
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.cmdguardar_S = new System.Windows.Forms.Button();
            this.txtsegurocod = new System.Windows.Forms.TextBox();
            this.txtsegurotip = new System.Windows.Forms.TextBox();
            this.txtseguroval = new System.Windows.Forms.TextBox();
            this.txtseguropor = new System.Windows.Forms.TextBox();
            this.txtseguroval_b = new System.Windows.Forms.TextBox();
            this.cboseguros = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtIDcliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cmdBuscarSeg = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblValorBeneficio = new System.Windows.Forms.Label();
            this.lblSeguro_V = new System.Windows.Forms.Label();
            this.cmdVenta = new System.Windows.Forms.Button();
            this.lblNumeroBene = new System.Windows.Forms.Label();
            this.txtNumeroBe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstVentas = new System.Windows.Forms.ListBox();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblvalori = new System.Windows.Forms.Label();
            this.lblFvali = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdguardar_S
            // 
            this.cmdguardar_S.BackColor = System.Drawing.Color.Transparent;
            this.cmdguardar_S.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdguardar_S.ForeColor = System.Drawing.Color.Green;
            this.cmdguardar_S.Location = new System.Drawing.Point(641, 293);
            this.cmdguardar_S.Name = "cmdguardar_S";
            this.cmdguardar_S.Size = new System.Drawing.Size(100, 35);
            this.cmdguardar_S.TabIndex = 0;
            this.cmdguardar_S.Text = "Guardar seguro";
            this.cmdguardar_S.UseVisualStyleBackColor = false;
            this.cmdguardar_S.Click += new System.EventHandler(this.cmdguardar_Click);
            // 
            // txtsegurocod
            // 
            this.txtsegurocod.Location = new System.Drawing.Point(330, 98);
            this.txtsegurocod.Name = "txtsegurocod";
            this.txtsegurocod.Size = new System.Drawing.Size(100, 20);
            this.txtsegurocod.TabIndex = 1;
            // 
            // txtsegurotip
            // 
            this.txtsegurotip.Location = new System.Drawing.Point(330, 136);
            this.txtsegurotip.Name = "txtsegurotip";
            this.txtsegurotip.Size = new System.Drawing.Size(100, 20);
            this.txtsegurotip.TabIndex = 2;
            // 
            // txtseguroval
            // 
            this.txtseguroval.Location = new System.Drawing.Point(330, 182);
            this.txtseguroval.Name = "txtseguroval";
            this.txtseguroval.Size = new System.Drawing.Size(100, 20);
            this.txtseguroval.TabIndex = 3;
            // 
            // txtseguropor
            // 
            this.txtseguropor.Location = new System.Drawing.Point(330, 225);
            this.txtseguropor.Name = "txtseguropor";
            this.txtseguropor.Size = new System.Drawing.Size(100, 20);
            this.txtseguropor.TabIndex = 4;
            // 
            // txtseguroval_b
            // 
            this.txtseguroval_b.Location = new System.Drawing.Point(330, 269);
            this.txtseguroval_b.Name = "txtseguroval_b";
            this.txtseguroval_b.Size = new System.Drawing.Size(100, 20);
            this.txtseguroval_b.TabIndex = 5;
            // 
            // cboseguros
            // 
            this.cboseguros.BackColor = System.Drawing.SystemColors.Window;
            this.cboseguros.FormattingEnabled = true;
            this.cboseguros.Location = new System.Drawing.Point(102, 272);
            this.cboseguros.Name = "cboseguros";
            this.cboseguros.Size = new System.Drawing.Size(100, 21);
            this.cboseguros.TabIndex = 6;
            this.cboseguros.SelectedIndexChanged += new System.EventHandler(this.cboseguros_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(159, 33);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "El Porvenir S.A.S";
            // 
            // txtIDcliente
            // 
            this.txtIDcliente.Location = new System.Drawing.Point(102, 139);
            this.txtIDcliente.Name = "txtIDcliente";
            this.txtIDcliente.Size = new System.Drawing.Size(100, 20);
            this.txtIDcliente.TabIndex = 8;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(102, 99);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 9;
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.Location = new System.Drawing.Point(102, 182);
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCliente.TabIndex = 10;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.ForeColor = System.Drawing.Color.Red;
            this.cmdSalir.Location = new System.Drawing.Point(641, 335);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(100, 35);
            this.cmdSalir.TabIndex = 11;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(31, 98);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(68, 21);
            this.lblnombre.TabIndex = 12;
            this.lblnombre.Text = "Nombre";
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCliente.Location = new System.Drawing.Point(96, 59);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(112, 21);
            this.lblDatosCliente.TabIndex = 13;
            this.lblDatosCliente.Text = "Datos Cliente";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(74, 139);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 21);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(31, 182);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(68, 21);
            this.lblNumero.TabIndex = 15;
            this.lblNumero.Text = "Numero";
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro.Location = new System.Drawing.Point(326, 59);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(64, 21);
            this.lblSeguro.TabIndex = 16;
            this.lblSeguro.Text = "Seguro";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(284, 135);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 21);
            this.lblTipo.TabIndex = 17;
            this.lblTipo.Text = "Tipo";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(264, 95);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 21);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Codigo";
            // 
            // cmdBuscarSeg
            // 
            this.cmdBuscarSeg.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscarSeg.Location = new System.Drawing.Point(641, 211);
            this.cmdBuscarSeg.Name = "cmdBuscarSeg";
            this.cmdBuscarSeg.Size = new System.Drawing.Size(100, 35);
            this.cmdBuscarSeg.TabIndex = 19;
            this.cmdBuscarSeg.Text = "Buscar";
            this.cmdBuscarSeg.UseVisualStyleBackColor = true;
            this.cmdBuscarSeg.Click += new System.EventHandler(this.cmdBuscarSeg_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(278, 177);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 21);
            this.lblValor.TabIndex = 20;
            this.lblValor.Text = "Valor";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.Location = new System.Drawing.Point(242, 222);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(82, 21);
            this.lblPorcentaje.TabIndex = 21;
            this.lblPorcentaje.Text = "Porcentaje";
            // 
            // lblValorBeneficio
            // 
            this.lblValorBeneficio.AutoSize = true;
            this.lblValorBeneficio.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBeneficio.Location = new System.Drawing.Point(251, 266);
            this.lblValorBeneficio.Name = "lblValorBeneficio";
            this.lblValorBeneficio.Size = new System.Drawing.Size(73, 21);
            this.lblValorBeneficio.TabIndex = 22;
            this.lblValorBeneficio.Text = "Beneficio";
            // 
            // lblSeguro_V
            // 
            this.lblSeguro_V.AutoSize = true;
            this.lblSeguro_V.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro_V.Location = new System.Drawing.Point(39, 269);
            this.lblSeguro_V.Name = "lblSeguro_V";
            this.lblSeguro_V.Size = new System.Drawing.Size(60, 21);
            this.lblSeguro_V.TabIndex = 23;
            this.lblSeguro_V.Text = "Seguro";
            // 
            // cmdVenta
            // 
            this.cmdVenta.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVenta.Location = new System.Drawing.Point(641, 252);
            this.cmdVenta.Name = "cmdVenta";
            this.cmdVenta.Size = new System.Drawing.Size(100, 35);
            this.cmdVenta.TabIndex = 24;
            this.cmdVenta.Text = "Guardar Venta";
            this.cmdVenta.UseVisualStyleBackColor = true;
            this.cmdVenta.Click += new System.EventHandler(this.cmdVenta_Click);
            // 
            // lblNumeroBene
            // 
            this.lblNumeroBene.AutoSize = true;
            this.lblNumeroBene.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroBene.Location = new System.Drawing.Point(7, 226);
            this.lblNumeroBene.Name = "lblNumeroBene";
            this.lblNumeroBene.Size = new System.Drawing.Size(92, 21);
            this.lblNumeroBene.TabIndex = 25;
            this.lblNumeroBene.Text = "Num Benefi";
            // 
            // txtNumeroBe
            // 
            this.txtNumeroBe.Location = new System.Drawing.Point(102, 226);
            this.txtNumeroBe.Name = "txtNumeroBe";
            this.txtNumeroBe.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroBe.TabIndex = 26;
            this.txtNumeroBe.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Total";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(152, 341);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(19, 21);
            this.lbltotal.TabIndex = 28;
            this.lbltotal.Text = "0";
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalcular.Location = new System.Drawing.Point(102, 377);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(100, 35);
            this.cmdCalcular.TabIndex = 29;
            this.cmdCalcular.Text = "Calcular";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(472, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 149);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // lstVentas
            // 
            this.lstVentas.FormattingEnabled = true;
            this.lstVentas.Location = new System.Drawing.Point(766, 33);
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(421, 342);
            this.lstVentas.TabIndex = 31;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.Location = new System.Drawing.Point(762, 7);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(123, 21);
            this.lblVentas.TabIndex = 32;
            this.lblVentas.Text = "Lista de Ventas";
            // 
            // lblvalori
            // 
            this.lblvalori.AutoSize = true;
            this.lblvalori.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalori.Location = new System.Drawing.Point(152, 307);
            this.lblvalori.Name = "lblvalori";
            this.lblvalori.Size = new System.Drawing.Size(19, 21);
            this.lblvalori.TabIndex = 34;
            this.lblvalori.Text = "0";
            // 
            // lblFvali
            // 
            this.lblFvali.AutoSize = true;
            this.lblFvali.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFvali.Location = new System.Drawing.Point(7, 307);
            this.lblFvali.Name = "lblFvali";
            this.lblFvali.Size = new System.Drawing.Size(129, 21);
            this.lblFvali.TabIndex = 33;
            this.lblFvali.Text = "Valor incremento";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1230, 463);
            this.Controls.Add(this.lblvalori);
            this.Controls.Add(this.lblFvali);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.lstVentas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdCalcular);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroBe);
            this.Controls.Add(this.lblNumeroBene);
            this.Controls.Add(this.cmdVenta);
            this.Controls.Add(this.lblSeguro_V);
            this.Controls.Add(this.lblValorBeneficio);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.cmdBuscarSeg);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblSeguro);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblDatosCliente);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.txtNumeroCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtIDcliente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cboseguros);
            this.Controls.Add(this.txtseguroval_b);
            this.Controls.Add(this.txtseguropor);
            this.Controls.Add(this.txtseguroval);
            this.Controls.Add(this.txtsegurotip);
            this.Controls.Add(this.txtsegurocod);
            this.Controls.Add(this.cmdguardar_S);
            this.Name = "Principal";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdguardar_S;
        private System.Windows.Forms.TextBox txtsegurocod;
        private System.Windows.Forms.TextBox txtsegurotip;
        private System.Windows.Forms.TextBox txtseguroval;
        private System.Windows.Forms.TextBox txtseguropor;
        private System.Windows.Forms.TextBox txtseguroval_b;
        private System.Windows.Forms.ComboBox cboseguros;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtIDcliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button cmdBuscarSeg;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblValorBeneficio;
        private System.Windows.Forms.Label lblSeguro_V;
        private System.Windows.Forms.Button cmdVenta;
        private System.Windows.Forms.Label lblNumeroBene;
        private System.Windows.Forms.TextBox txtNumeroBe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstVentas;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblvalori;
        private System.Windows.Forms.Label lblFvali;
    }
}

