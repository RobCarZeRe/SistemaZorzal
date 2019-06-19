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
    public partial class FrmAddProducto : Form
    {
        public FrmAddProducto()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddProducto_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarCajitas()
        {
            TxtCodigo.Clear();
            TxtDescripcion.Clear();
            TxtStock.Clear();
            TxtPrecioUnitario.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
                ClsEProducto objEP = new ClsEProducto();
                ClsNProducto objNP = new ClsNProducto();
                objEP.proCodigo = TxtCodigo.Text;
                objEP.proDescripcion = TxtDescripcion.Text;
                objEP.proCantidad = TxtStock.Text;
                objEP.proPrecioUnitario = TxtPrecioUnitario.Text;
                objNP.MtdAgregarProducto(objEP);
                MessageBox.Show("Datos Registrados Correctamente...");
                LimpiarCajitas();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ClsEProducto objEP = new ClsEProducto();
            ClsNProducto objNP = new ClsNProducto();
            objEP.proCodigo = TxtCodigo.Text;
            objEP.proDescripcion = TxtDescripcion.Text;
            objEP.proCantidad = TxtStock.Text;
            objEP.proPrecioUnitario = TxtPrecioUnitario.Text;
            objNP.MtdModificarProducto(objEP);
        }
    }
}
