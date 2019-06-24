namespace GestionHostalElZorzal.Presentacion
{
    partial class FrmBoleta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.GpbContenedor = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtCargoEnc = new System.Windows.Forms.TextBox();
            this.TxtNombreEnc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtDniCli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TxtSerie = new System.Windows.Forms.TextBox();
            this.Serie = new System.Windows.Forms.Label();
            this.DgvHabitacion = new System.Windows.Forms.DataGridView();
            this.LblRuc = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNroHabitacion = new System.Windows.Forms.TextBox();
            this.TxtHoraEntrada = new System.Windows.Forms.TextBox();
            this.TxtHoraSalida = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.TxtTotalCostoProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GpbContenedor.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHabitacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(229, 58);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(32, 41);
            this.BtnNuevo.TabIndex = 82;
            this.BtnNuevo.Text = "N";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // GpbContenedor
            // 
            this.GpbContenedor.Controls.Add(this.groupBox4);
            this.GpbContenedor.Controls.Add(this.groupBox1);
            this.GpbContenedor.Controls.Add(this.button1);
            this.GpbContenedor.Controls.Add(this.groupBox3);
            this.GpbContenedor.Controls.Add(this.groupBox2);
            this.GpbContenedor.Location = new System.Drawing.Point(16, 101);
            this.GpbContenedor.Name = "GpbContenedor";
            this.GpbContenedor.Size = new System.Drawing.Size(661, 505);
            this.GpbContenedor.TabIndex = 81;
            this.GpbContenedor.TabStop = false;
            this.GpbContenedor.Enter += new System.EventHandler(this.GpbContenedor_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 65;
            this.button1.Text = "Cobrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtCargoEnc);
            this.groupBox3.Controls.Add(this.TxtNombreEnc);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(7, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(639, 44);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Encargado";
            // 
            // TxtCargoEnc
            // 
            this.TxtCargoEnc.Enabled = false;
            this.TxtCargoEnc.Location = new System.Drawing.Point(498, 12);
            this.TxtCargoEnc.Name = "TxtCargoEnc";
            this.TxtCargoEnc.Size = new System.Drawing.Size(128, 20);
            this.TxtCargoEnc.TabIndex = 15;
            // 
            // TxtNombreEnc
            // 
            this.TxtNombreEnc.Enabled = false;
            this.TxtNombreEnc.Location = new System.Drawing.Point(62, 16);
            this.TxtNombreEnc.Name = "TxtNombreEnc";
            this.TxtNombreEnc.Size = new System.Drawing.Size(274, 20);
            this.TxtNombreEnc.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(454, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Cargo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtApellidos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtNombre);
            this.groupBox2.Controls.Add(this.BtnBuscar);
            this.groupBox2.Controls.Add(this.TxtDniCli);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(639, 66);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Apellidos:";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Enabled = false;
            this.TxtApellidos.Location = new System.Drawing.Point(504, 37);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(122, 20);
            this.TxtApellidos.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre de Cliente:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Location = new System.Drawing.Point(261, 37);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(122, 20);
            this.TxtNombre.TabIndex = 10;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(112, 36);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(55, 23);
            this.BtnBuscar.TabIndex = 9;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtDniCli
            // 
            this.TxtDniCli.Location = new System.Drawing.Point(6, 36);
            this.TxtDniCli.Name = "TxtDniCli";
            this.TxtDniCli.Size = new System.Drawing.Size(100, 20);
            this.TxtDniCli.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DNI";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Uighur", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(319, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 38);
            this.label17.TabIndex = 80;
            this.label17.Text = "Factura";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Uighur", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(486, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(191, 38);
            this.label16.TabIndex = 79;
            this.label16.Text = "Hostal  - El Zorzal";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TxtNumero);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.TxtSerie);
            this.groupBox5.Controls.Add(this.Serie);
            this.groupBox5.Location = new System.Drawing.Point(23, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 86);
            this.groupBox5.TabIndex = 78;
            this.groupBox5.TabStop = false;
            // 
            // TxtSerie
            // 
            this.TxtSerie.Location = new System.Drawing.Point(87, 13);
            this.TxtSerie.Name = "TxtSerie";
            this.TxtSerie.Size = new System.Drawing.Size(100, 20);
            this.TxtSerie.TabIndex = 11;
            this.TxtSerie.Text = "001";
            // 
            // Serie
            // 
            this.Serie.AutoSize = true;
            this.Serie.Location = new System.Drawing.Point(47, 16);
            this.Serie.Name = "Serie";
            this.Serie.Size = new System.Drawing.Size(34, 13);
            this.Serie.TabIndex = 8;
            this.Serie.Text = "Serie:";
            // 
            // DgvHabitacion
            // 
            this.DgvHabitacion.AllowUserToAddRows = false;
            this.DgvHabitacion.AllowUserToDeleteRows = false;
            this.DgvHabitacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvHabitacion.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvHabitacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvHabitacion.ColumnHeadersHeight = 30;
            this.DgvHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvHabitacion.EnableHeadersVisualStyles = false;
            this.DgvHabitacion.GridColor = System.Drawing.Color.DimGray;
            this.DgvHabitacion.Location = new System.Drawing.Point(575, 9);
            this.DgvHabitacion.Name = "DgvHabitacion";
            this.DgvHabitacion.ReadOnly = true;
            this.DgvHabitacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvHabitacion.Size = new System.Drawing.Size(35, 32);
            this.DgvHabitacion.TabIndex = 77;
            this.DgvHabitacion.Visible = false;
            // 
            // LblRuc
            // 
            this.LblRuc.AutoSize = true;
            this.LblRuc.Font = new System.Drawing.Font("Microsoft Uighur", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRuc.Location = new System.Drawing.Point(528, 31);
            this.LblRuc.Name = "LblRuc";
            this.LblRuc.Size = new System.Drawing.Size(149, 38);
            this.LblRuc.TabIndex = 83;
            this.LblRuc.Text = "10005065416";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Uighur", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(487, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 31);
            this.label21.TabIndex = 84;
            this.label21.Text = "RUC:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtTotal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtHoraSalida);
            this.groupBox1.Controls.Add(this.TxtHoraEntrada);
            this.groupBox1.Controls.Add(this.TxtNroHabitacion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(7, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 78);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de Habitacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Entrada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Numero de Habitacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Salida";
            // 
            // TxtNroHabitacion
            // 
            this.TxtNroHabitacion.Location = new System.Drawing.Point(131, 20);
            this.TxtNroHabitacion.Name = "TxtNroHabitacion";
            this.TxtNroHabitacion.Size = new System.Drawing.Size(100, 20);
            this.TxtNroHabitacion.TabIndex = 15;
            // 
            // TxtHoraEntrada
            // 
            this.TxtHoraEntrada.Location = new System.Drawing.Point(328, 18);
            this.TxtHoraEntrada.Name = "TxtHoraEntrada";
            this.TxtHoraEntrada.Size = new System.Drawing.Size(134, 20);
            this.TxtHoraEntrada.TabIndex = 16;
            // 
            // TxtHoraSalida
            // 
            this.TxtHoraSalida.Location = new System.Drawing.Point(505, 14);
            this.TxtHoraSalida.Name = "TxtHoraSalida";
            this.TxtHoraSalida.Size = new System.Drawing.Size(128, 20);
            this.TxtHoraSalida.TabIndex = 17;
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.SystemColors.Info;
            this.TxtTotal.Location = new System.Drawing.Point(505, 52);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(128, 20);
            this.TxtTotal.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtTotalCostoProducto);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.DgvProductos);
            this.groupBox4.Location = new System.Drawing.Point(7, 221);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(639, 215);
            this.groupBox4.TabIndex = 67;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalles de Productos";
            // 
            // DgvProductos
            // 
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Location = new System.Drawing.Point(15, 19);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.Size = new System.Drawing.Size(611, 150);
            this.DgvProductos.TabIndex = 0;
            // 
            // TxtTotalCostoProducto
            // 
            this.TxtTotalCostoProducto.BackColor = System.Drawing.SystemColors.Info;
            this.TxtTotalCostoProducto.Location = new System.Drawing.Point(504, 175);
            this.TxtTotalCostoProducto.Name = "TxtTotalCostoProducto";
            this.TxtTotalCostoProducto.Size = new System.Drawing.Size(128, 20);
            this.TxtTotalCostoProducto.TabIndex = 21;
            this.TxtTotalCostoProducto.TextChanged += new System.EventHandler(this.TxtTotalCostoProducto_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Total";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(87, 40);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(100, 20);
            this.TxtNumero.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Numero";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Enabled = false;
            this.TxtFecha.Location = new System.Drawing.Point(521, 79);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(128, 20);
            this.TxtFecha.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(477, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 85;
            this.label10.Text = "Fecha:";
            // 
            // FrmBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 578);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.LblRuc);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.GpbContenedor);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.DgvHabitacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBoleta";
            this.Text = "FrmBoleta";
            this.Load += new System.EventHandler(this.FrmBoleta_Load);
            this.GpbContenedor.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHabitacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.GroupBox GpbContenedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtCargoEnc;
        private System.Windows.Forms.TextBox TxtNombreEnc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtDniCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TxtSerie;
        private System.Windows.Forms.Label Serie;
        private System.Windows.Forms.DataGridView DgvHabitacion;
        private System.Windows.Forms.Label LblRuc;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtHoraSalida;
        private System.Windows.Forms.TextBox TxtHoraEntrada;
        private System.Windows.Forms.TextBox TxtNroHabitacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.TextBox TxtTotalCostoProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label label10;
    }
}