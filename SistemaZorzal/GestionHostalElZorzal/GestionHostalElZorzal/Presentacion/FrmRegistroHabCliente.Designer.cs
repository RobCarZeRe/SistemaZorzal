﻿namespace GestionHostalElZorzal.Presentacion
{
    partial class FrmRegistroHabCliente
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CostoT = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtDias = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtHoras = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ChckBoxporhora = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCosto2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbHabitacion = new System.Windows.Forms.ComboBox();
            this.DgvHabitacion = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtDniCli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtCargoEnc = new System.Windows.Forms.TextBox();
            this.TxtNombreEnc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtHora = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TxtRegistro = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHabitacion)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CostoT);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.TxtDias);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtHoras);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ChckBoxporhora);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtCosto2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtCosto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CmbHabitacion);
            this.groupBox1.Location = new System.Drawing.Point(377, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 140);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros de Alquiler";
            // 
            // CostoT
            // 
            this.CostoT.Location = new System.Drawing.Point(241, 48);
            this.CostoT.Name = "CostoT";
            this.CostoT.Size = new System.Drawing.Size(33, 20);
            this.CostoT.TabIndex = 22;
            this.CostoT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostoT_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(174, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Costo Total";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(253, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Dias";
            // 
            // TxtDias
            // 
            this.TxtDias.Location = new System.Drawing.Point(214, 22);
            this.TxtDias.Name = "TxtDias";
            this.TxtDias.Size = new System.Drawing.Size(33, 20);
            this.TxtDias.TabIndex = 19;
            this.TxtDias.TextChanged += new System.EventHandler(this.TxtDias_TextChanged);
            this.TxtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDias_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Hs";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // TxtHoras
            // 
            this.TxtHoras.Enabled = false;
            this.TxtHoras.Location = new System.Drawing.Point(202, 81);
            this.TxtHoras.Name = "TxtHoras";
            this.TxtHoras.Size = new System.Drawing.Size(33, 20);
            this.TxtHoras.TabIndex = 17;
            this.TxtHoras.TextChanged += new System.EventHandler(this.TxtHoras_TextChanged);
            this.TxtHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHoras_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total de Horas:";
            // 
            // ChckBoxporhora
            // 
            this.ChckBoxporhora.AutoSize = true;
            this.ChckBoxporhora.Location = new System.Drawing.Point(20, 84);
            this.ChckBoxporhora.Name = "ChckBoxporhora";
            this.ChckBoxporhora.Size = new System.Drawing.Size(71, 17);
            this.ChckBoxporhora.TabIndex = 15;
            this.ChckBoxporhora.Text = "Por Hora:";
            this.ChckBoxporhora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChckBoxporhora.UseVisualStyleBackColor = true;
            this.ChckBoxporhora.CheckedChanged += new System.EventHandler(this.ChckBoxporhora_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "S/.";
            // 
            // TxtCosto2
            // 
            this.TxtCosto2.Enabled = false;
            this.TxtCosto2.Location = new System.Drawing.Point(130, 114);
            this.TxtCosto2.Name = "TxtCosto2";
            this.TxtCosto2.Size = new System.Drawing.Size(33, 20);
            this.TxtCosto2.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Costo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "S/.";
            // 
            // TxtCosto
            // 
            this.TxtCosto.Enabled = false;
            this.TxtCosto.Location = new System.Drawing.Point(112, 47);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(33, 20);
            this.TxtCosto.TabIndex = 9;
            this.TxtCosto.TextChanged += new System.EventHandler(this.TxtCosto_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Habitacion:";
            // 
            // CmbHabitacion
            // 
            this.CmbHabitacion.FormattingEnabled = true;
            this.CmbHabitacion.Location = new System.Drawing.Point(78, 19);
            this.CmbHabitacion.Name = "CmbHabitacion";
            this.CmbHabitacion.Size = new System.Drawing.Size(121, 21);
            this.CmbHabitacion.TabIndex = 0;
            this.CmbHabitacion.SelectedIndexChanged += new System.EventHandler(this.CmbHabitacion_SelectedIndexChanged);
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
            this.DgvHabitacion.Location = new System.Drawing.Point(641, 9);
            this.DgvHabitacion.Name = "DgvHabitacion";
            this.DgvHabitacion.ReadOnly = true;
            this.DgvHabitacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvHabitacion.Size = new System.Drawing.Size(35, 32);
            this.DgvHabitacion.TabIndex = 56;
            this.DgvHabitacion.Visible = false;
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
            this.groupBox2.Location = new System.Drawing.Point(18, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 108);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Apellidos:";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Enabled = false;
            this.TxtApellidos.Location = new System.Drawing.Point(145, 80);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(122, 20);
            this.TxtApellidos.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre de Cliente:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Location = new System.Drawing.Point(6, 80);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(122, 20);
            this.TxtNombre.TabIndex = 10;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(112, 33);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(55, 23);
            this.BtnBuscar.TabIndex = 9;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtCargoEnc);
            this.groupBox3.Controls.Add(this.TxtNombreEnc);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(18, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(621, 44);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Encargado";
            // 
            // TxtCargoEnc
            // 
            this.TxtCargoEnc.Enabled = false;
            this.TxtCargoEnc.Location = new System.Drawing.Point(489, 12);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtFecha);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.TxtHora);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(24, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(615, 65);
            this.groupBox4.TabIndex = 59;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Entrada";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(400, 23);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(139, 20);
            this.TxtFecha.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(350, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Fecha:";
            // 
            // TxtHora
            // 
            this.TxtHora.Location = new System.Drawing.Point(100, 23);
            this.TxtHora.Name = "TxtHora";
            this.TxtHora.Size = new System.Drawing.Size(100, 20);
            this.TxtHora.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Hora de Entrada:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 60;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TxtRegistro);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(18, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 41);
            this.groupBox5.TabIndex = 61;
            this.groupBox5.TabStop = false;
            // 
            // TxtRegistro
            // 
            this.TxtRegistro.Location = new System.Drawing.Point(87, 13);
            this.TxtRegistro.Name = "TxtRegistro";
            this.TxtRegistro.Size = new System.Drawing.Size(100, 20);
            this.TxtRegistro.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Registro Nro:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Uighur", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(448, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(191, 38);
            this.label16.TabIndex = 62;
            this.label16.Text = "Hostal  - El Zorzal";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Uighur", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(285, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 38);
            this.label17.TabIndex = 63;
            this.label17.Text = "Alquiler";
            // 
            // FrmRegistroHabCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 392);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DgvHabitacion);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistroHabCliente";
            this.Text = "FrmRegistroHabCliente";
            this.Load += new System.EventHandler(this.FrmRegistroHabCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHabitacion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbHabitacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DgvHabitacion;
        private System.Windows.Forms.CheckBox ChckBoxporhora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCosto2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtHoras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtDniCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtCargoEnc;
        private System.Windows.Forms.TextBox TxtNombreEnc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtHora;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TxtRegistro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtDias;
        private System.Windows.Forms.TextBox CostoT;
        private System.Windows.Forms.Label label19;
    }
}