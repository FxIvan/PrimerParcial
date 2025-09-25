namespace PrimerParcial
{
    partial class Form1
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
            this.dgrGrilla1 = new System.Windows.Forms.DataGridView();
            this.NroDeSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrGrilla2 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeOtorgamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgrResumen = new System.Windows.Forms.DataGridView();
            this.NroDeSocioResumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreResumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoResumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNIResumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuotaResumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteDeDescuentoResumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteDeDescuentoPorTipoDeClienteResumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembresiaResumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetoAAbonarResumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroDeSocio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTipoDeCliente = new System.Windows.Forms.ComboBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigoDeLaMembresia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtImporteDescuento = new System.Windows.Forms.TextBox();
            this.dtpFechaOtorgamiento = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAsignarMembresia = new System.Windows.Forms.Button();
            this.btnQuitarMembresia = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefrescarDatos = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrGrilla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrGrilla2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrResumen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrGrilla1
            // 
            this.dgrGrilla1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrGrilla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrGrilla1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroDeSocio,
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.Cuota});
            this.dgrGrilla1.Location = new System.Drawing.Point(12, 31);
            this.dgrGrilla1.Name = "dgrGrilla1";
            this.dgrGrilla1.Size = new System.Drawing.Size(557, 183);
            this.dgrGrilla1.TabIndex = 0;
            this.dgrGrilla1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrGrilla1_CellClick);
            // 
            // NroDeSocio
            // 
            this.NroDeSocio.HeaderText = "Nro de socio";
            this.NroDeSocio.Name = "NroDeSocio";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Cuota
            // 
            this.Cuota.HeaderText = "Cuota";
            this.Cuota.Name = "Cuota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grilla 1";
            // 
            // dgrGrilla2
            // 
            this.dgrGrilla2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrGrilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrGrilla2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.FechaDeOtorgamiento,
            this.Importe});
            this.dgrGrilla2.Location = new System.Drawing.Point(582, 31);
            this.dgrGrilla2.Name = "dgrGrilla2";
            this.dgrGrilla2.Size = new System.Drawing.Size(557, 183);
            this.dgrGrilla2.TabIndex = 2;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // FechaDeOtorgamiento
            // 
            this.FechaDeOtorgamiento.HeaderText = "Fecha de otorgamiento";
            this.FechaDeOtorgamiento.Name = "FechaDeOtorgamiento";
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grilla 2";
            // 
            // dgrResumen
            // 
            this.dgrResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrResumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroDeSocioResumen,
            this.NombreResumen,
            this.ApellidoResumen,
            this.DNIResumen,
            this.CuotaResumen,
            this.ImporteDeDescuentoResumen,
            this.ImporteDeDescuentoPorTipoDeClienteResumen,
            this.MembresiaResumen,
            this.NetoAAbonarResumen});
            this.dgrResumen.Location = new System.Drawing.Point(12, 249);
            this.dgrResumen.Name = "dgrResumen";
            this.dgrResumen.Size = new System.Drawing.Size(1127, 183);
            this.dgrResumen.TabIndex = 4;
            // 
            // NroDeSocioResumen
            // 
            this.NroDeSocioResumen.HeaderText = "Nro de socio";
            this.NroDeSocioResumen.Name = "NroDeSocioResumen";
            // 
            // NombreResumen
            // 
            this.NombreResumen.HeaderText = "Nombre";
            this.NombreResumen.Name = "NombreResumen";
            // 
            // ApellidoResumen
            // 
            this.ApellidoResumen.HeaderText = "Apellido";
            this.ApellidoResumen.Name = "ApellidoResumen";
            // 
            // DNIResumen
            // 
            this.DNIResumen.HeaderText = "DNI";
            this.DNIResumen.Name = "DNIResumen";
            // 
            // CuotaResumen
            // 
            this.CuotaResumen.HeaderText = "Cuota";
            this.CuotaResumen.Name = "CuotaResumen";
            // 
            // ImporteDeDescuentoResumen
            // 
            this.ImporteDeDescuentoResumen.HeaderText = "Importe de descuento";
            this.ImporteDeDescuentoResumen.Name = "ImporteDeDescuentoResumen";
            // 
            // ImporteDeDescuentoPorTipoDeClienteResumen
            // 
            this.ImporteDeDescuentoPorTipoDeClienteResumen.HeaderText = "Importe de descuento por tipo de cliente *";
            this.ImporteDeDescuentoPorTipoDeClienteResumen.Name = "ImporteDeDescuentoPorTipoDeClienteResumen";
            // 
            // MembresiaResumen
            // 
            this.MembresiaResumen.HeaderText = "Membresia **";
            this.MembresiaResumen.Name = "MembresiaResumen";
            // 
            // NetoAAbonarResumen
            // 
            this.NetoAAbonarResumen.HeaderText = "Neto a abonar ***";
            this.NetoAAbonarResumen.Name = "NetoAAbonarResumen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grilla 3";
            // 
            // txtNumeroDeSocio
            // 
            this.txtNumeroDeSocio.Location = new System.Drawing.Point(21, 32);
            this.txtNumeroDeSocio.Name = "txtNumeroDeSocio";
            this.txtNumeroDeSocio.Size = new System.Drawing.Size(167, 20);
            this.txtNumeroDeSocio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "N° De socio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(21, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(21, 153);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(167, 20);
            this.txtDNI.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(21, 113);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(167, 20);
            this.txtApellido.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cuota";
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(21, 191);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(167, 20);
            this.txtCuota.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tipo de cliente";
            // 
            // cmbTipoDeCliente
            // 
            this.cmbTipoDeCliente.FormattingEnabled = true;
            this.cmbTipoDeCliente.Items.AddRange(new object[] {
            "Principiante",
            "Intermedio",
            "Avanzado"});
            this.cmbTipoDeCliente.Location = new System.Drawing.Point(21, 232);
            this.cmbTipoDeCliente.Name = "cmbTipoDeCliente";
            this.cmbTipoDeCliente.Size = new System.Drawing.Size(167, 21);
            this.cmbTipoDeCliente.TabIndex = 18;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(21, 270);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(167, 29);
            this.btnAgregarCliente.TabIndex = 19;
            this.btnAgregarCliente.Text = "Agregar cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(21, 305);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(167, 29);
            this.btnModificarCliente.TabIndex = 20;
            this.btnModificarCliente.Text = "Modificar cliente";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click_1);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(21, 340);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(167, 29);
            this.btnEliminarCliente.TabIndex = 21;
            this.btnEliminarCliente.Text = "Eliminar cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarCliente);
            this.groupBox1.Controls.Add(this.btnModificarCliente);
            this.groupBox1.Controls.Add(this.btnAgregarCliente);
            this.groupBox1.Controls.Add(this.cmbTipoDeCliente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCuota);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNumeroDeSocio);
            this.groupBox1.Location = new System.Drawing.Point(15, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 384);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion de clientes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Codigo de la membresia";
            // 
            // txtCodigoDeLaMembresia
            // 
            this.txtCodigoDeLaMembresia.Location = new System.Drawing.Point(9, 33);
            this.txtCodigoDeLaMembresia.Name = "txtCodigoDeLaMembresia";
            this.txtCodigoDeLaMembresia.Size = new System.Drawing.Size(167, 20);
            this.txtCodigoDeLaMembresia.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Importe de descuento";
            // 
            // txtImporteDescuento
            // 
            this.txtImporteDescuento.Location = new System.Drawing.Point(9, 73);
            this.txtImporteDescuento.Name = "txtImporteDescuento";
            this.txtImporteDescuento.Size = new System.Drawing.Size(167, 20);
            this.txtImporteDescuento.TabIndex = 24;
            // 
            // dtpFechaOtorgamiento
            // 
            this.dtpFechaOtorgamiento.Location = new System.Drawing.Point(9, 114);
            this.dtpFechaOtorgamiento.Name = "dtpFechaOtorgamiento";
            this.dtpFechaOtorgamiento.Size = new System.Drawing.Size(167, 20);
            this.dtpFechaOtorgamiento.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Fecha de otorgacion";
            // 
            // btnAsignarMembresia
            // 
            this.btnAsignarMembresia.Location = new System.Drawing.Point(9, 148);
            this.btnAsignarMembresia.Name = "btnAsignarMembresia";
            this.btnAsignarMembresia.Size = new System.Drawing.Size(167, 26);
            this.btnAsignarMembresia.TabIndex = 28;
            this.btnAsignarMembresia.Text = "Asignar membresia";
            this.btnAsignarMembresia.UseVisualStyleBackColor = true;
            this.btnAsignarMembresia.Click += new System.EventHandler(this.btnAsignarMembresia_Click);
            // 
            // btnQuitarMembresia
            // 
            this.btnQuitarMembresia.Location = new System.Drawing.Point(9, 180);
            this.btnQuitarMembresia.Name = "btnQuitarMembresia";
            this.btnQuitarMembresia.Size = new System.Drawing.Size(167, 26);
            this.btnQuitarMembresia.TabIndex = 29;
            this.btnQuitarMembresia.Text = "Quitar membresia";
            this.btnQuitarMembresia.UseVisualStyleBackColor = true;
            this.btnQuitarMembresia.Click += new System.EventHandler(this.btnQuitarMembresia_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQuitarMembresia);
            this.groupBox2.Controls.Add(this.btnAsignarMembresia);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dtpFechaOtorgamiento);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtImporteDescuento);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtCodigoDeLaMembresia);
            this.groupBox2.Location = new System.Drawing.Point(261, 473);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 229);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestion de membresia";
            // 
            // btnRefrescarDatos
            // 
            this.btnRefrescarDatos.Location = new System.Drawing.Point(481, 473);
            this.btnRefrescarDatos.Name = "btnRefrescarDatos";
            this.btnRefrescarDatos.Size = new System.Drawing.Size(137, 22);
            this.btnRefrescarDatos.TabIndex = 31;
            this.btnRefrescarDatos.Text = "Refrescar datos";
            this.btnRefrescarDatos.UseVisualStyleBackColor = true;
            this.btnRefrescarDatos.Click += new System.EventHandler(this.btnRefrescarDatos_Click);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(481, 501);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(137, 22);
            this.btnMostrarTodo.TabIndex = 32;
            this.btnMostrarTodo.Text = "Mostrar todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 864);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.btnRefrescarDatos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgrResumen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgrGrilla2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrGrilla1);
            this.Name = "Form1";
            this.Text = "Primer parcial";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrGrilla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrGrilla2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrResumen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrGrilla1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDeSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrGrilla2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeOtorgamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgrResumen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDeSocioResumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreResumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoResumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNIResumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuotaResumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteDeDescuentoResumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteDeDescuentoPorTipoDeClienteResumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembresiaResumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetoAAbonarResumen;
        private System.Windows.Forms.TextBox txtNumeroDeSocio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTipoDeCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigoDeLaMembresia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtImporteDescuento;
        private System.Windows.Forms.DateTimePicker dtpFechaOtorgamiento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAsignarMembresia;
        private System.Windows.Forms.Button btnQuitarMembresia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefrescarDatos;
        private System.Windows.Forms.Button btnMostrarTodo;
    }
}

