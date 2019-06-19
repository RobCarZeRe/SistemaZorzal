using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionHostalElZorzal.Negocio;
using GestionHostalElZorzal.Entidad;
namespace GestionHostalElZorzal.Presentacion
{
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
            listar();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void listar()
        {
            ClsNEmpleado objNemp = new ClsNEmpleado();
            DgvEmpleado.DataSource = objNemp.MtdListarTodoEmpleado();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmAddEmpleado frm = new FrmAddEmpleado();
            frm.Show();

        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmAddEmpleado frm = new FrmAddEmpleado();
            frm.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ClsEEmpleado objE = new ClsEEmpleado();
            ClsNEmpleado objN = new ClsNEmpleado();
            objE.empCodigo = TxtBuscar.Text;
            objN.MtdEliminarEmpleado(objE);
            MessageBox.Show("Empleado Eliminado Correctamente...");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ClsEEmpleado objEemp = new ClsEEmpleado();
            ClsNEmpleado objNemp = new ClsNEmpleado();
            objEemp.empCodigo = TxtBuscar.Text;
            DgvEmpleado.DataSource = objNemp.MtdBuscarporCodigo(objEemp);
        }
    }
}
