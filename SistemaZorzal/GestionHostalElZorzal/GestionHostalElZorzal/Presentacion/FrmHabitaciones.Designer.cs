namespace GestionHostalElZorzal.Presentacion
{
    partial class FrmHabitaciones
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
            this.DgvHabitacion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNroHabitacion = new System.Windows.Forms.TextBox();
            this.CmbTipohabitacion = new System.Windows.Forms.ComboBox();
            this.TxtPrecioHab = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHabitacion)).BeginInit();
            this.SuspendLayout();
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
            this.DgvHabitacion.Location = new System.Drawing.Point(738, 62);
            this.DgvHabitacion.Name = "DgvHabitacion";
            this.DgvHabitacion.ReadOnly = true;
            this.DgvHabitacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvHabitacion.Size = new System.Drawing.Size(556, 126);
            this.DgvHabitacion.TabIndex = 55;
            this.DgvHabitacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHabitacion_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Numero de Habitacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tipo de Habitacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Precio de Habitacion";
            // 
            // TxtNroHabitacion
            // 
            this.TxtNroHabitacion.Location = new System.Drawing.Point(425, 62);
            this.TxtNroHabitacion.Name = "TxtNroHabitacion";
            this.TxtNroHabitacion.Size = new System.Drawing.Size(100, 20);
            this.TxtNroHabitacion.TabIndex = 59;
            // 
            // CmbTipohabitacion
            // 
            this.CmbTipohabitacion.FormattingEnabled = true;
            this.CmbTipohabitacion.Items.AddRange(new object[] {
            "Matrimonial",
            "Doble",
            "Personal"});
            this.CmbTipohabitacion.Location = new System.Drawing.Point(425, 108);
            this.CmbTipohabitacion.Name = "CmbTipohabitacion";
            this.CmbTipohabitacion.Size = new System.Drawing.Size(100, 21);
            this.CmbTipohabitacion.TabIndex = 60;
            // 
            // TxtPrecioHab
            // 
            this.TxtPrecioHab.Location = new System.Drawing.Point(425, 149);
            this.TxtPrecioHab.Name = "TxtPrecioHab";
            this.TxtPrecioHab.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecioHab.TabIndex = 61;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FrmHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1378, 1061);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtPrecioHab);
            this.Controls.Add(this.CmbTipohabitacion);
            this.Controls.Add(this.TxtNroHabitacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvHabitacion);
            this.Name = "FrmHabitaciones";
            this.Text = "FrmHabitaciones";
            this.Load += new System.EventHandler(this.FrmHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHabitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvHabitacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNroHabitacion;
        private System.Windows.Forms.ComboBox CmbTipohabitacion;
        private System.Windows.Forms.TextBox TxtPrecioHab;
        private System.Windows.Forms.Button button1;
    }
}