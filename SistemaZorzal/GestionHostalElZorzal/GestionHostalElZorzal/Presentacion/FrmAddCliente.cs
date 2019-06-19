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
    public partial class FrmAddCliente : Form
    {
        public FrmAddCliente()
        {
            InitializeComponent();
            LimpiarCajitas();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddCliente_Load(object sender, EventArgs e)
        {

        }

        public void LimpiarCajitas()
        {
            TxtDni.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtDireccion.Clear();
            TxtEmail.Clear();
            TxtTelefono.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClsECliente objE = new ClsECliente();
            ClsNCliente objN = new ClsNCliente();
            objE.cliDni = TxtDni.Text;
            objE.cliNombre = TxtNombre.Text;
            objE.cliApellido = TxtApellido.Text;
            objE.cliEmail = TxtEmail.Text;
            objN.MtdAgregarCliente(objE);
            MessageBox.Show("Datos Clientes Registrado Correctamente...");
            LimpiarCajitas();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ClsECliente objE = new ClsECliente();
            ClsNCliente objN = new ClsNCliente();
            objE.cliDni = TxtDni.Text;
            objE.cliNombre = TxtNombre.Text;
            objE.cliApellido = TxtApellido.Text;
            objE.cliEmail = TxtEmail.Text;
            objN.MtdModificarCliente(objE);
            MessageBox.Show("Datos Clientes Modificados Correctamente...");
            LimpiarCajitas();
        }
    }
}
