using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionHostalElZorzal.Negocio
{
    class ClsConexion
    {
        public string Servidor = @"EQUIPO";//nombre del servidor base de datos
        public string BaseDatos = "DbelZorzal";
        public string usuario = "";
        public string clave = "";
        public static SqlConnection con;
        public static string ConBDcadena;

        public void conectar()
        {
            try
            {
                ConBDcadena = "server=" + Servidor + ";database=" + BaseDatos + ";User Id=" + usuario + ";password=" + clave + "; Trusted_Connection=True;";
                con = new SqlConnection(ConBDcadena);
                con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void desconectar()
        {
            con.Close();
        }

    }
    
}
