namespace GestionHostalElZorzal.Presentacion
{
    partial class FrmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GestionHostalElZorzal.Properties.Resources.Login;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.btnmin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TxtPassword);
            this.panel1.Controls.Add(this.TxtUsuario);
            this.panel1.Location = new System.Drawing.Point(150, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 280);
            this.panel1.TabIndex = 11;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblHora.Location = new System.Drawing.Point(376, 32);
            this.lblHora.Name = "lblHora";
            this.lblHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHora.Size = new System.Drawing.Size(48, 20);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btncerrar
            // 
            this.btncerrar.BackgroundImage = global::GestionHostalElZorzal.Properties.Resources.btn_cerrar;
            this.btncerrar.Location = new System.Drawing.Point(72, 226);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(35, 30);
            this.btncerrar.TabIndex = 7;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblFecha.Location = new System.Drawing.Point(232, 230);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFecha.Size = new System.Drawing.Size(59, 20);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnmin
            // 
            this.btnmin.BackgroundImage = global::GestionHostalElZorzal.Properties.Resources.btn_min;
            this.btnmin.Location = new System.Drawing.Point(31, 226);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(35, 30);
            this.btnmin.TabIndex = 6;
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::GestionHostalElZorzal.Properties.Resources.btn_ingresar;
            this.pictureBox1.Location = new System.Drawing.Point(380, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(176)))), ((int)(((byte)(136)))));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.SaddleBrown;
            this.TxtPassword.Location = new System.Drawing.Point(116, 154);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(231, 22);
            this.TxtPassword.TabIndex = 4;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(176)))), ((int)(((byte)(136)))));
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.SaddleBrown;
            this.TxtUsuario.Location = new System.Drawing.Point(116, 102);
            this.TxtUsuario.MaxLength = 55;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(231, 23);
            this.TxtUsuario.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionHostalElZorzal.Properties.Resources.Fondo_Login2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}