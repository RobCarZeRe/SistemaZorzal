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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ClsEProducto objE = new ClsEProducto();
            ClsNProducto objN = new ClsNProducto();
            objE.proCodigo = TxtBuscar.Text;
            DgvProducto.DataSource = objN.MtdBuscarporCodigo(objE);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmAddProducto frm = new FrmAddProducto();
            frm.Show();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmAddProducto frm = new FrmAddProducto();
            frm.Show();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ClsNProducto objProd = new ClsNProducto();
            DgvProducto.DataSource = objProd.MtdListarTodoProducto();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ClsEProducto objE = new ClsEProducto();
            ClsNProducto objN = new ClsNProducto();
            objE.proCodigo = TxtBuscar.Text;
            objN.MtdEliminarProducto(objE);
            MessageBox.Show("Producto Eliminado Correctamente...");
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            ClsNProducto objProd = new ClsNProducto();
            DgvProducto.DataSource = objProd.MtdListarTodoProducto();
        }
    }
}
