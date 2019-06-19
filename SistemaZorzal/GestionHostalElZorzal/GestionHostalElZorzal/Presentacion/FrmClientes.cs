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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
            cargarclientes();
        }
        public void cargarclientes()
        {
            ClsNCliente objcli = new ClsNCliente();
            DgvCliente.DataSource = objcli.MtdListarTodoCliente();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            FrmAddCliente frm = new FrmAddCliente();
            frm.Show();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ClsECliente objE = new ClsECliente();
            ClsNCliente objN = new ClsNCliente();
            objE.cliDni = TxtBuscar.Text;
            DgvCliente.DataSource = objN.MtdBuscarporDni(objE);
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ClsNCliente objcli = new ClsNCliente();
            DgvCliente.DataSource = objcli.MtdListarTodoCliente();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FrmAddCliente frm = new FrmAddCliente();
            frm.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ClsECliente objE = new ClsECliente();
            ClsNCliente objN = new ClsNCliente();
            objE.cliDni = TxtBuscar.Text;
            objN.MtdEliminarCli(objE);
            MessageBox.Show("Cliente Eliminado Correctamente...");
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscar.Text != "")
            {
                DgvCliente.CurrentCell = null;
                foreach(DataGridViewRow r in DgvCliente.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in DgvCliente.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(TxtBuscar.Text.ToUpper()) == 0)
                        {

                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                ClsNCliente objcli = new ClsNCliente();
                DgvCliente.DataSource = objcli.MtdListarTodoCliente();

            }
        }
    }
}
