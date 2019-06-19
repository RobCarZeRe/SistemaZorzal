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
    public partial class FrmAddProveedor : Form
    {
        public FrmAddProveedor()
        {
            InitializeComponent();
            LimpiarCajitas();
        }

        public void LimpiarCajitas()
        {
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtDireccion.Clear();
            TxtRuc.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClsEProveedor objEProv = new ClsEProveedor();
            ClsNProveedor objNProv = new ClsNProveedor();
            objEProv.provCodigo = TxtCodigo.Text;
            objEProv.provNombre = TxtNombre.Text;
            objEProv.provDireccion = TxtDireccion.Text;
            objEProv.provRuc = TxtRuc.Text;
            objEProv.provEmail = TxtEmail.Text;
            objEProv.provTelefono = TxtTelefono.Text;
            objNProv.MtdAgregarProveedor(objEProv);
            MessageBox.Show("Datos Registrados Correctamente...");
            LimpiarCajitas();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ClsEProveedor objEProv = new ClsEProveedor();
            ClsNProveedor objNProv = new ClsNProveedor();
            objEProv.provCodigo = TxtCodigo.Text;
            objEProv.provNombre = TxtNombre.Text;
            objEProv.provDireccion = TxtDireccion.Text;
            objEProv.provRuc = TxtRuc.Text;
            objEProv.provEmail = TxtEmail.Text;
            objEProv.provTelefono = TxtTelefono.Text;
            objNProv.MtdModificarProveedor(objEProv);
            MessageBox.Show("Datos Modificados Correctamente...");
            LimpiarCajitas();
        }
    }
}
