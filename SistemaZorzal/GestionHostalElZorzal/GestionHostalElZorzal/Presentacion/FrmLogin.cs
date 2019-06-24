using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionHostalElZorzal.Entidad;
using GestionHostalElZorzal.Negocio;

namespace GestionHostalElZorzal.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public static string cod, nom, car, ape;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClsEEmpleado objEemp = new ClsEEmpleado();
            ClsNEmpleado objNemp = new ClsNEmpleado();
            objEemp.empCodigo = TxtUsuario.Text;
            objEemp.empClave = TxtPassword.Text;
            objEemp.empEstado = "True";
            DataTable dtEmp = new DataTable();
            dtEmp = objNemp.MtdValidarLogin(objEemp);

            if (dtEmp.Rows.Count > 0)
            {
                DataRow Fila = dtEmp.Rows[0];

                cod = Fila["Codigo"].ToString();
                nom = Fila["Nombre"].ToString();
                car = Fila["Cargo"].ToString();
                ape = Fila["Apellido"].ToString();

                FrmPrincipal.nombre = nom;
                FrmRegistroHabCliente.nombre = nom;
                FrmVentaProducto.nombre = nom;
                FrmBoleta.nombre = nom;
                FrmPrincipal.cargo = car;
                FrmBoleta.cargo = car;
                FrmRegistroHabCliente.cargo = car;
                FrmVentaProducto.cargo = car;
                FrmVentaProducto.cargo = car;
                FrmPrincipal.dniemp = cod;
                FrmPrincipal.apemp = ape;
                FrmBoleta.dniemp = cod;
                FrmBoleta.apemp = ape;

                FrmRegistroHabCliente.apemp = ape;
                FrmVentaProducto.apemp = ape;
                MessageBox.Show("Ingresaste " + nom + " " + ape + " con cargo de " + car);

                FrmPrincipal frm = new FrmPrincipal();
                frm.Show();
                this.Hide();
            }

        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(100, 92);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Size = new Size(90, 85);
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        public static string c;
        private void Button1_Click(object sender, EventArgs e)
        {
            //string usuario, contraseña;
            //usuario = txtUsuario.Text;
            //contraseña = txtContraseña.Text;
            //if (usuario == "Administrador" && contraseña == "12345")
            //{
            //    FrmPrincipal frm = new FrmPrincipal();
            //    frm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Acceso denegado");
            //}

           
        }
    }
}
