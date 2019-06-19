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
    public partial class FrmProveedor : Form
    {
        public FrmProveedor()
        {
            InitializeComponent();
            listar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ClsEProveedor objE = new ClsEProveedor();
            ClsNProveedor objN = new ClsNProveedor();
            objE.provCodigo = TxtBuscar.Text;
            DgvProveedor.DataSource = objN.MtdBuscarporCodigo(objE);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmAddProveedor frm = new FrmAddProveedor();
            frm.Show();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmAddProveedor frm = new FrmAddProveedor();
            frm.Show();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ClsNProveedor objProd = new ClsNProveedor();
            DgvProveedor.DataSource = objProd.MtdListarTodoProveedor();
        }

        public void listar()
        {
            ClsNProveedor objProd = new ClsNProveedor();
            DgvProveedor.DataSource = objProd.MtdListarTodoProveedor();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ClsEProveedor objE = new ClsEProveedor();
            ClsNProveedor objN = new ClsNProveedor();
            objE.provCodigo = TxtBuscar.Text;
            objN.MtdEliminarProveedor(objE);
            MessageBox.Show("Proveedor Eliminado Correctamente...");
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
