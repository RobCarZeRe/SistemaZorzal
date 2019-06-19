using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionHostalElZorzal.Presentacion;
using GestionHostalElZorzal.Entidad;
using GestionHostalElZorzal.Negocio;


namespace GestionHostalElZorzal.Presentacion
{
    public partial class FrmHabitacionDetalle : Form
    {
        public FrmHabitacionDetalle()
        {
            InitializeComponent();
            llenar();
            jalardatos();
            jalardatoscliente();
        }
        string Tipo, Precio, Limpieza, Estado;
        string clientehospedado, dni, tiempo, registrofecha;
        private void FrmHabitacionDetalle_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenar()
        {
            label1.Text = FrmHabitaciones.datos;
        }

        private void FrmHabitacionDetalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        public void jalardatos()
        {
            ClsEHabitacion objEemp = new ClsEHabitacion();
            ClsNHabitacion objNemp = new ClsNHabitacion();
            objEemp.NroHabitacion = label1.Text;
            
            DataTable dtEmp = new DataTable();
            dtEmp = objNemp.MtdBuscarHabitacionNro(objEemp);

            if (dtEmp.Rows.Count > 0)
            {
                DataRow Fila = dtEmp.Rows[0];

                Tipo = Fila["TipoHabitacion"].ToString();
                Precio = Fila["PrecioHabitacion"].ToString();
                Limpieza = Fila["LimpiezaHab"].ToString();
                Estado = Fila["EstadoHab"].ToString();

                TxtTipo.Text = Tipo;
                TxtPrecio.Text = Precio;
                TxtLimpieza.Text = Limpieza;
                TxtEstado.Text = Estado;          
               

               
            }

        }

        public void jalardatoscliente()
        {
            ClsEHabitacion objEemp = new ClsEHabitacion();
            ClsNHabitacion objNemp = new ClsNHabitacion();
            objEemp.NroHabitacion = label1.Text;

            DataTable dtEmp = new DataTable();
            dtEmp = objNemp.MtdBuscarHabitacionAlquilada(objEemp);

            if (dtEmp.Rows.Count > 0)
            {
                DataRow Fila = dtEmp.Rows[0];

                
                clientehospedado = Fila["NomCliente"].ToString();
                dni = Fila["DniCliente"].ToString();
                tiempo = Fila["TiempoAlquilado"].ToString();
                registrofecha = Fila["FechayHoraEntrada"].ToString();

                TxtCliente.Text = clientehospedado;
                TxtDniCliente.Text = dni;
                TxtTiempo.Text = tiempo;
                TxtRegistro.Text = registrofecha;

            }

        }

        public void calcularsalida()
        {
           
            




        }
    }
}
