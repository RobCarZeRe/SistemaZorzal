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
    public partial class FrmVentaProducto : Form
    {
        public FrmVentaProducto()
        {
            InitializeComponent();
            cargardatos();
            cargarnroregistro();
            
        }
        public static string dniemp;
        public static string nombre;
        public static string cargo;
        public static string apemp;
        public static string nrohab;
        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmVentaProducto_Load(object sender, EventArgs e)
        {
            gpbcontenedor.Enabled = false;

        }
        public void cargarnroregistro()
        {
           // ClsEVentaProd objEvp = new ClsEVentaProd();
            ClsNVentaProd objNvp = new ClsNVentaProd();

            DataTable dt = new DataTable();
            dt = objNvp.BuscaNroRegistro();
            if (dt.Rows.Count > 0)
            {
                DataRow Fila = dt.Rows[0];
                TxtRegistro.Text = Fila["NumeroRegistro"].ToString();
            }

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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ClsECliente objE = new ClsECliente();
            ClsNCliente objN = new ClsNCliente();
            objE.cliDni = TxtDniCli.Text;
            //DgvCliente.DataSource = objN.MtdBuscarporDni(objE);

            DataTable dtEmp = new DataTable();
            dtEmp = objN.MtdBuscarporDni(objE);
            if (dtEmp.Rows.Count > 0)
            {
                DataRow Fila = dtEmp.Rows[0];
                TxtNombre.Text = Fila["Nombre"].ToString();
                TxtApellidos.Text = Fila["Apellido"].ToString();
            }
            

            ClsEVentaProd objEvp = new ClsEVentaProd();
            ClsNVentaProd objNvp = new ClsNVentaProd();
            objEvp.DniCli = TxtDniCli.Text;
            DgvComprobante.DataSource = objNvp.BuscaProdClienteDNI(objEvp);

            DataTable dt = new DataTable();
            dt = objNvp.BuscaImporteFinal(objEvp);
            if (dt.Rows.Count > 0)
            {
                DataRow Fila = dt.Rows[0];
                TxtImporteFinal.Text = Fila["ImporteFinal"].ToString();
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClsNProducto objprod = new ClsNProducto();
            ClsEProducto objep = new ClsEProducto();
            objep.proCodigo = TxtCodigoPro.Text;
            DataTable tb_Producto = new DataTable();
            tb_Producto = objprod.MtdBuscarporCodigo(objep);

            if (tb_Producto.Rows.Count > 0)
            {
                DataRow Fila = tb_Producto.Rows[0];
                string desc, cant, prun;

                desc = Fila["Descripcion"].ToString();
                cant = Fila["Cantidad"].ToString();
                prun = Fila["PrecioUnitario"].ToString();
                TxtDescripcionPro.Text = desc;
                TxtCantidadPro.Text = cant;
                TxtPrecioUnitPro.Text = prun;


            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            TxtImporteFinal.Text = Convert.ToString(Convert.ToInt32(TxtImporteFinal.Text) + Convert.ToInt32(TxtImportePro.Text));
            ClsEVentaProd objE = new ClsEVentaProd();
            ClsNVentaProd objN = new ClsNVentaProd();
            objE.DniCli = TxtDniCli.Text;
            objE.Codigo = TxtCodigoPro.Text;
            objE.Cantidad = TxtCantidadPro.Text;
            objE.PrecioUnit = TxtPrecioUnitPro.Text;
            objE.CantidadCompra = TxtCantCompraPro.Text;
            objE.Importe = TxtImportePro.Text;
            objE.ImporteFinal = TxtImporteFinal.Text;
            objE.Estado = "1";     

            objN.MtdAgregarVentaProd(objE);
            MessageBox.Show("Datos Clientes Registrado Correctamente...");
            
            //cambiarestado();

        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int cactual = Convert.ToInt32(TxtCantidadPro.Text);
                int ccom = Convert.ToInt32(TxtCantCompraPro.Text);
                double puni = Convert.ToDouble(TxtPrecioUnitPro.Text);
                
                if (ccom > cactual)
                {

                    MessageBox.Show("Error");
                    TxtCantCompraPro.Clear();
                    TxtCantCompraPro.Focus();


                }
                else
                {
                    double pu = Convert.ToDouble(TxtPrecioUnitPro.Text);
                    double tot;
                    tot = pu * ccom;
                    TxtCantidadPro.Text = (cactual - ccom).ToString();
                    TxtImportePro.Text = tot.ToString();
                    TxtImportePro.Text = Convert.ToString(puni * ccom);
                    // TxtImporteprod.Text = Convert.ToString(puni * ccom);

                }
                //ActualizarPRoducto();

            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            gpbcontenedor.Enabled = true;
            TxtRegistro.Text = (Convert.ToInt32(TxtRegistro.Text) + 1).ToString();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            ClsNProducto objprod = new ClsNProducto();
            ClsEProducto objep = new ClsEProducto();
            objep.proCodigo = TxtCodigoPro.Text;
            DataTable tb_Producto = new DataTable();
            tb_Producto = objprod.MtdBuscarporCodigo(objep);

            if (tb_Producto.Rows.Count > 0)
            {
                DataRow Fila = tb_Producto.Rows[0];
                string desc, cant, prun;

                desc = Fila["Descripcion"].ToString();
                cant = Fila["Cantidad"].ToString();
                prun = Fila["PrecioUnitario"].ToString();
                TxtDescripcionPro.Text = desc;
                TxtCantidadPro.Text = cant;
                TxtPrecioUnitPro.Text = prun;


            }

            
        }

        private void TxtCantCompraPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                int cactual = Convert.ToInt32(TxtCantidadPro.Text);
                int ccom = Convert.ToInt32(TxtCantCompraPro.Text);
                double puni = Convert.ToDouble(TxtPrecioUnitPro.Text);

                if (ccom > cactual)
                {

                    MessageBox.Show("Error");
                    TxtCantCompraPro.Clear();
                    TxtCantCompraPro.Focus();


                }
                else
                {
                    double pu = Convert.ToDouble(TxtPrecioUnitPro.Text);
                    double tot;
                    tot = pu * ccom;
                    TxtCantidadPro.Text = (cactual - ccom).ToString();
                    TxtImportePro.Text = tot.ToString();
                    TxtImportePro.Text = Convert.ToString(puni * ccom);
                    // TxtImporteprod.Text = Convert.ToString(puni * ccom);

                }
                //ActualizarPRoducto();

            }
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            ClsECliente objE = new ClsECliente();
            ClsNCliente objN = new ClsNCliente();
            objE.cliDni = TxtDniCli.Text;
            //DgvCliente.DataSource = objN.MtdBuscarporDni(objE);

            DataTable dtEmp = new DataTable();
            dtEmp = objN.MtdBuscarporDni(objE);
            if (dtEmp.Rows.Count > 0)
            {
                DataRow Fila = dtEmp.Rows[0];
                TxtNombre.Text = Fila["Nombre"].ToString();
                TxtApellidos.Text = Fila["Apellido"].ToString();
            }


            ClsEVentaProd objEvp = new ClsEVentaProd();
            ClsNVentaProd objNvp = new ClsNVentaProd();
            objEvp.DniCli = TxtDniCli.Text;
            DgvComprobante.DataSource = objNvp.BuscaProdClienteDNI(objEvp);

            /*
            DataTable dt = new DataTable();
            dt = objNvp.BuscaImporteFinal(objEvp);
            if (dt.Rows.Count > 1)
            {
                DataRow Fila = dt.Rows[0];
                TxtImporteFinal.Text = Fila["ImporteFinal"].ToString();
            }
            */

            ClsNVentaProd objpro = new ClsNVentaProd();
            ClsEVentaProd objEpro = new ClsEVentaProd();

            objEpro.DniCli = TxtDniCli.Text;
            DataTable dt = new DataTable();
            dt = objNvp.BuscaImporteFinal(objEpro);
            if (dt.Rows.Count > 0)
            {
                DataRow Fila = dt.Rows[0];
                TxtImporteFinal.Text = Fila["Importe"].ToString();
            }


        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            
            TxtImporteFinal.Text = Convert.ToString(Convert.ToInt32(TxtImporteFinal.Text) + Convert.ToInt32(TxtImportePro.Text));
            ClsEVentaProd objE = new ClsEVentaProd();
            ClsNVentaProd objN = new ClsNVentaProd();
            objE.DniCli = TxtDniCli.Text;
            objE.Codigo = TxtCodigoPro.Text;
            objE.Cantidad = TxtCantidadPro.Text;
            objE.PrecioUnit = TxtPrecioUnitPro.Text;
            objE.CantidadCompra = TxtCantCompraPro.Text;
            objE.Importe = TxtImportePro.Text;
            objE.ImporteFinal = TxtImporteFinal.Text;
            objE.Estado = "1";

            objN.MtdAgregarVentaProd(objE);
            MessageBox.Show("Datos Clientes Registrado Correctamente...");
        }
    }
}
