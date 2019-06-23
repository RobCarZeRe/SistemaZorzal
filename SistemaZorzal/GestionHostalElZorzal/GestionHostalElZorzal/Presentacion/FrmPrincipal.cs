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
        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmClientes());

       
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmEmpleado());

       
        }

       

       

       

     
        

      

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }

     

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmProveedor());

     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmProducto());

         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmHabitaciones());

        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmRegistroHabCliente());

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmVentaProducto());

         
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmBoleta());

           
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
