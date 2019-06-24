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
    public partial class FrmRegistroHabCliente : Form
    {
        public FrmRegistroHabCliente()
        {
            InitializeComponent();
            llenarcombo();
            cargardatos();
            timer1.Enabled = true;
            calcularfecha();
            cargarnroregistro();
        }
        public static string dniemp;
        public static string nombre;
        public static string cargo;
        public static string apemp;
        public static string nrohab;
        
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        public void llenarcombo()
        {
            
            ClsNHabitacion objhab = new ClsNHabitacion();
            DgvHabitacion.DataSource = objhab.MtdListarTodoHabitacionporEstado();
            for (int i = 0; i < DgvHabitacion.RowCount; i++)
            {
                string habi;
                habi = DgvHabitacion.Rows[i].Cells[0].Value.ToString() + "-" + DgvHabitacion.Rows[i].Cells[1].Value.ToString();
                CmbHabitacion.Items.Add(habi);

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
        private void FrmRegistroHabCliente_Load(object sender, EventArgs e)
        {
            GpbContenedor.Enabled = false;

        }

        public void cargarnroregistro()
        {
            // ClsEVentaProd objEvp = new ClsEVentaProd();
            ClsNRegHabCli objNvp = new ClsNRegHabCli();

            DataTable dt = new DataTable();
            dt = objNvp.BuscaNroRegistro();
            if (dt.Rows.Count > 0)
            {
                DataRow Fila = dt.Rows[0];
                TxtRegistro.Text = Fila["NumeroRegistro"].ToString();
            }

        }



        private void CmbHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string phrase = CmbHabitacion.Text;
            string[] words = phrase.Split('-');

            string valor;
            valor = words[1];
            nrohab = words[0];
            if(valor == "Matrimonial")
            {
                TxtCosto.Text = "200";
                

            }
            if(valor == "Doble")
            {
                TxtCosto.Text = "150";
            }
            if (valor == "Personal")
            {
                TxtCosto.Text = "100";
            }

        }

        private void ChckBoxporhora_CheckedChanged(object sender, EventArgs e)
        {
            if (ChckBoxporhora.Checked == true)
            {
                //TxtCosto.Text = "";
                TxtHoras.Enabled = true;
                TxtCosto.Visible = false;

            }
            else
            {
                TxtHoras.Enabled = false;
                TxtCosto.Visible = true;
                TxtHoras.Text = "";
                TxtCosto2.Text = "";
            }
        }

        private void TxtHoras_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void TxtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TxtCosto2.Text = ((Convert.ToInt32(TxtCosto.Text) / 20 * Convert.ToInt32(TxtHoras.Text)).ToString());
            }
        }

        private void TxtCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
           
        }

        private void calcularhora()
        {
            
        }

        private void calcularfecha()
        {
            TxtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TxtHora.Text = DateTime.Now.ToString("h:mm:ss");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        public void cambiarestado()
        {
            ClsEHabitacion objE = new ClsEHabitacion();
            ClsNHabitacion objN = new ClsNHabitacion();
            objE.NroHabitacion = nrohab;
            objE.Estado = "1";
            objN.MtdModificarEstadoHab(objE);
        }

        private void Label10_Click(object sender, EventArgs e)
        {
            
        }

        

        private void TxtDias_TextChanged(object sender, EventArgs e)
        {

        }

        private void CostoT_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
             CostoT.Text = ((Convert.ToInt32(TxtCosto.Text) * Convert.ToInt32(TxtDias.Text)).ToString());
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtRegistro.Text = (Convert.ToInt32(TxtRegistro.Text) + 1).ToString(); 
            GpbContenedor.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ClsERegHabCli objE = new ClsERegHabCli();
            ClsNRegHabCli objN = new ClsNRegHabCli();
            objE.NomEncargado = TxtNombreEnc.Text;
            objE.DniCli = TxtDniCli.Text;
            objE.NomCli = TxtNombre.Text;
            objE.NroHab = nrohab;
            if (ChckBoxporhora.Checked == true)
            {
                objE.Costo = TxtCosto2.Text;
                objE.TiempoAlq = TxtHoras.Text + " horas";
            }
            else
            {
                objE.Costo = CostoT.Text;
                objE.TiempoAlq = TxtDias.Text + " dias";

            }

            objE.FechayHora = TxtFecha.Text + " " + TxtHora.Text;

            objN.MtdAgregarRegHabCli(objE);
            MessageBox.Show("Datos Clientes Registrado Correctamente...");
            cambiarestado();
            this.Close();
        }

        private void BtnBuscar_Click_2(object sender, EventArgs e)
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
        }

        private void TxtDias_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtDias_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                CostoT.Text = ((Convert.ToInt32(TxtCosto.Text) * Convert.ToInt32(TxtDias.Text)).ToString());
            }
        }

        private void TxtCargoEnc_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbHabitacion_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string phrase = CmbHabitacion.Text;
            string[] words = phrase.Split('-');

            string valor;
            valor = words[1];
            nrohab = words[0];
            if (valor == "Matrimonial")
            {
                TxtCosto.Text = "200";


            }
            if (valor == "Doble")
            {
                TxtCosto.Text = "150";
            }
            if (valor == "Personal")
            {
                TxtCosto.Text = "100";
            }
        }
    }
}
