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
    public partial class FrmBoleta : Form
    {
        public FrmBoleta()
        {
            InitializeComponent();
            cargardatos();
        }
        public static string dniemp;
        public static string nombre;
        public static string cargo;
        public static string apemp;
        public static string nrohab;
        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            ClsECliente objE1 = new ClsECliente();
            ClsNCliente objN1 = new ClsNCliente();

            objE1.cliDni = TxtDniCli.Text;

            DataTable dt = new DataTable();
            dt = objN1.MtdBuscarporDni(objE1);
            if (dt.Rows.Count > 0)
            {
                DataRow Fila = dt.Rows[0];
                TxtNombre.Text = Fila["Nombre"].ToString();
                TxtApellidos.Text = Fila["Apellido"].ToString();


            }


            ClsERegHabCli objE = new ClsERegHabCli();
            ClsNRegHabCli objN = new ClsNRegHabCli();
            objE.DniCli = TxtDniCli.Text;
            //DgvCliente.DataSource = objN.MtdBuscarporDni(objE);

            DataTable dtEmp = new DataTable();
            dtEmp = objN.MtdBuscarCostoHabitacion(objE);
            if (dtEmp.Rows.Count > 0)
            {
                DataRow Fila = dtEmp.Rows[0];
                TxtNroHabitacion.Text = Fila["NroHabitacion"].ToString();
                TxtTotal.Text = Fila["costo"].ToString();
                TxtHoraEntrada.Text = Fila["FechayHoraEntrada"].ToString();
                TxtHoraSalida.Text = DateTime.Now.ToString("G");
                
            }

            ClsEVentaProd objEcli = new ClsEVentaProd();
            ClsNVentaProd objNcli = new ClsNVentaProd();
            objEcli.DniCli = TxtDniCli.Text;
            DgvProductos.DataSource = objNcli.MtdBuscarCostoporProducto(objEcli);



            ClsNVentaProd objNvp = new ClsNVentaProd();
            ClsEVentaProd objEpro = new ClsEVentaProd();


            objEpro.DniCli = TxtDniCli.Text;
            DataTable tabla = new DataTable();
            tabla = objNvp.BuscaImporteFinal(objEpro);
            if (tabla.Rows.Count > 0)
            {
                DataRow Fila = tabla.Rows[0];
                TxtTotalCostoProducto.Text = Fila["Importe"].ToString();
            }





        }

        private void GpbContenedor_Enter(object sender, EventArgs e)
        {

        }

        public void cargardatos()
        {
            TxtNombreEnc.Text = nombre + " " + apemp;
            TxtCargoEnc.Text = cargo;
            if (cargo.Equals("1"))
            {
                TxtCargoEnc.Text = "ADMINISTRADOR";
            }
            if (cargo.Equals("2"))
            {
                TxtCargoEnc.Text = "RECEPCIONISTA";
            }
        }

        private void FrmBoleta_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            TxtFecha.Text = today.ToString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClsEBoleta objEc = new ClsEBoleta();
            ClsNBoleta objNc = new ClsNBoleta();
            objEc.serie = TxtSerie.Text;
            objEc.numero = TxtNumero.Text;
            objEc.fecha = TxtFecha.Text;
            objEc.total = Convert.ToDecimal(TxtTotalCostoProducto.Text);
            objEc.estado = "1";
            objEc.ruc = LblRuc.Text;
            objEc.dniCli = TxtDniCli.Text;
            objEc.codEmp = "empty";
            objNc.MtdAgregarBoleta(objEc);

            MessageBox.Show("Boleta Guardada Correctamente");

            
        }

        private void TxtTotalCostoProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
