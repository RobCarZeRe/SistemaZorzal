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
    public partial class FrmHabitaciones : Form
    {
        public FrmHabitaciones()
        {
            InitializeComponent();
            ListarHabitaciones();
            cargarbotones();
        }
        int coordenada1 = 200, coordenada2 =250, contador = 0;
        public static string datos;
        
        private void FrmHabitaciones_Load(object sender, EventArgs e)
        {

        }

        public void ListarHabitaciones()
        {
            ClsNHabitacion objcli = new ClsNHabitacion();
            DgvHabitacion.DataSource = objcli.MtdListarTodoHabitacion();

        }
        public void LimpiarCajitas()
        {
            TxtNroHabitacion.Text = "";
            TxtPrecioHab.Text = "";
            CmbTipohabitacion.SelectedIndex = -1;
        }
        


        private void Button1_Click(object sender, EventArgs e)
        {
            ClsEHabitacion objE = new ClsEHabitacion();
            ClsNHabitacion objN = new ClsNHabitacion();
            objE.NroHabitacion = TxtNroHabitacion.Text;
            objE.Precio = Convert.ToDecimal(TxtPrecioHab.Text);
            objE.TipodeHabitacion = CmbTipohabitacion.Text;
            objE.Limpieza = "0";
            objE.Estado = "0";
            objN.MtdAgregarHabitacion(objE);
            MessageBox.Show("Datos Clientes Registrado Correctamente...");
            LimpiarCajitas();
            this.Refresh();
            

        }

        private void DgvHabitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void cargarbotones()
        {
            
            for (int i = 0; i < DgvHabitacion.RowCount; i++)
            {

                //datos = DgvHabitacion.Rows[i].Cells[0].Value.ToString();
                Button button1 = new Button();
                Label label1 = new Label();
                Label label2 = new Label();
                button1.Location = new System.Drawing.Point(coordenada1, coordenada2);
                label1.Location = new System.Drawing.Point(coordenada1+85, coordenada2 + 210);
                //label2.Location = new System.Drawing.Point(coordenada1+85, coordenada2 -330);
                label2.Location = new System.Drawing.Point(coordenada1 + 70, coordenada2 +230);
                button1.Size = new System.Drawing.Size(200 , 200);
                label1.Size = new System.Drawing.Size(100,20);
                label2.Size = new System.Drawing.Size(100, 20);
                button1.Name = DgvHabitacion.Rows[i].Cells[0].Value.ToString();
                label1.Text = DgvHabitacion.Rows[i].Cells[0].Value.ToString();
                label2.Text = DgvHabitacion.Rows[i].Cells[1].Value.ToString(); 
                label1.Font = new Font("Proxy 9", 10);
                label2.Font = new Font("Proxy 9", 10);
                //btn1.Text = "un boton";
                //button1.Text = 
                if (button1.Name == "Matrimonial")
                {
                    datos = "Matrimonial";
                }               
                int estado;
                
                estado = Convert.ToInt32(DgvHabitacion.Rows[i].Cells[4].Value);
                if(estado == 1)
                {
                    button1.BackColor = Color.Red;
                    //button1.BackgroundImage = "C:/Users/Usuario/Desktop/puerta.jpg";
                    //button1.BackgroundImage = Image.FromFile(@"C:/Users/Usuario/Desktop/puerta.jpg");
                    button1.BackgroundImage = Image.FromFile(@"C:/Users/DEPIS01/Desktop/puerta.jpg");

                    
                }
                else
                {
                    button1.BackgroundImage = Image.FromFile(@"C:/Users/DEPIS01/Desktop/puertab.jpg");
                }
                
                this.Controls.Add(button1);
                this.Controls.Add(label1);
                this.Controls.Add(label2);
                coordenada1 = coordenada1 + 300;
                contador = contador + 1;
                if(contador == 5)
                {
                    coordenada1 = 200;
                    coordenada2 = coordenada2 + 300;
                    contador = 0;

                }


                button1.Click += new EventHandler(handlerComun_Click);
                

            }

            
        }
        private void handlerComun_Click(object sender, EventArgs e)
        {
            datos = ((Button)sender).Name;
            FrmHabitacionDetalle frm = new FrmHabitacionDetalle();
            frm.Show();
            
        }
    }
}
