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
    public partial class FrmAddEmpleado : Form
    {
        private string ruta;
        public FrmAddEmpleado()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                PcbFoto.Image = Image.FromFile(opf.FileName);
                ruta = opf.FileName;
            }
        }
        public void LimpiarCajitas()
        {
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtClave.Clear();
            CmbCargo.SelectedIndex = -1;
            CmbEstado.SelectedIndex = -1;
            ruta = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClsEEmpleado objE = new ClsEEmpleado();
            ClsNEmpleado objN = new ClsNEmpleado();
            objE.empCodigo = TxtCodigo.Text;
            objE.empNombres = TxtNombre.Text;
            objE.empApellidos = TxtApellido.Text;
            objE.empCargo = CmbCargo.Text;
            objE.empClave = TxtClave.Text;
            objE.empEstado = CmbEstado.Text;
            objE.empFoto = ruta;
            objN.MtdAgregarEmpleado(objE);
            
            MessageBox.Show("Datos Clientes Registrado Correctamente...");
            LimpiarCajitas();

        }

        private void FrmAddEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ClsEEmpleado objE = new ClsEEmpleado();
            ClsNEmpleado objN = new ClsNEmpleado();
            objE.empCodigo = TxtCodigo.Text;
            objE.empNombres = TxtNombre.Text;
            objE.empApellidos = TxtApellido.Text;
            objE.empCargo = CmbCargo.Text;
            objE.empClave = TxtClave.Text;
            objE.empEstado = CmbEstado.Text;
            objE.empFoto = ruta;
            objN.MtdModificarEmpleado(objE);
            LimpiarCajitas();
        }
    }
}
