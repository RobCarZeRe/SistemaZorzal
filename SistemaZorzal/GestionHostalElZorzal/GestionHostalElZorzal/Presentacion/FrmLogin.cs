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

        private void FrmLogin_Load(object sender, EventArgs e)
        {

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
                FrmPrincipal.cargo = car;
                FrmRegistroHabCliente.cargo = car;
                FrmVentaProducto.cargo = car;
                FrmPrincipal.dniemp = cod;
                FrmPrincipal.apemp = ape;

                FrmRegistroHabCliente.apemp = ape;
                FrmVentaProducto.apemp = ape;
                MessageBox.Show("Ingresaste " + nom + " " + ape + " con cargo de " + car);

                FrmPrincipal frm = new FrmPrincipal();
                frm.Show();
                this.Hide();
            }
        }
    }
}
