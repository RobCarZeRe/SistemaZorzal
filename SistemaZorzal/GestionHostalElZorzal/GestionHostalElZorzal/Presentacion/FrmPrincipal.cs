using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHostalElZorzal.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            cargardatos();
        }
        public static string dniemp;
        public static string nombre;
        public static string cargo;
        public static string apemp;
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        public void cargardatos()
        {
            LblNombre.Text = nombre+" "+apemp;
            LblTipo.Text = cargo;
            if(cargo.Equals("1"))
            {
                LblTipo.Text = "ADMINISTRADOR";
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FrmEmpleado frm = new FrmEmpleado();
            frm.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto();
            frm.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FrmProveedor frm = new FrmProveedor();
            frm.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            FrmHabitaciones frm = new FrmHabitaciones();
            frm.Show();
            this.Hide();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            FrmRegistroHabCliente frm = new FrmRegistroHabCliente();
            frm.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            FrmVentaProducto frm = new FrmVentaProducto();
            frm.Show();
           
        }
    }
}
