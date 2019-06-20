using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using GestionHostalElZorzal.Entidad;

namespace GestionHostalElZorzal.Negocio
{
    class ClsNRegHabCli
    {
        public string MtdAgregarRegHabCli(ClsERegHabCli objEHCli)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                ClsConexion objcon = new ClsConexion();
                objcon.conectar();
                //1. Establecer la cadena de conexion
                sqlCon.ConnectionString = ClsConexion.ConBDcadena;
                //2. Abrir la conexion de la BD
                sqlCon.Open();
                //3. Establecer el comando
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "USP_I_RegistroHabCliente";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parametros al comando
                //Establecemos los valores para el parametro @codigoProducto del Procedimiento Almacenado
                SqlParameter sqldnicliente = new SqlParameter();
                sqldnicliente.ParameterName = "@NomEncargado";
                sqldnicliente.SqlDbType = SqlDbType.NVarChar;
                //sqldnicliente.Direction = ParameterDirection.InputOutput;
                sqldnicliente.Size = 100;
                sqldnicliente.Value = objEHCli.NomEncargado;
                sqlCmd.Parameters.Add(sqldnicliente); //Agregamos el parametro al comando
                                                      //Establecemos los valores para el parametro @nombre del Procedimiento Almacenado
                SqlParameter sqlParnombre = new SqlParameter();
                sqlParnombre.ParameterName = "@DniCliente";
                sqlParnombre.SqlDbType = SqlDbType.NVarChar;
                sqlParnombre.Size = 100;
                sqlParnombre.Value = objEHCli.DniCli;
                sqlCmd.Parameters.Add(sqlParnombre); //Agregamos el parametro al comando
                                                     //Establecemos los valores para el parametro @precio del Procedimiento Almacenado
                SqlParameter sqlParApellido = new SqlParameter();
                sqlParApellido.ParameterName = "@NomCliente";
                sqlParApellido.SqlDbType = SqlDbType.NVarChar;
                sqlParApellido.Size = 100;
                sqlParApellido.Value = objEHCli.NomCli;
                sqlCmd.Parameters.Add(sqlParApellido); //Agregamos el parametro al comando

                SqlParameter sqlParEmail = new SqlParameter();
                sqlParEmail.ParameterName = "@NroHabitacion";
                sqlParEmail.SqlDbType = SqlDbType.NVarChar;
                sqlParEmail.Size = 100;
                sqlParEmail.Value = objEHCli.NroHab;
                sqlCmd.Parameters.Add(sqlParEmail); //Agregamos el parametro al comando

                SqlParameter sqlParacosto = new SqlParameter();
                sqlParacosto.ParameterName = "@Costo";
                sqlParacosto.SqlDbType = SqlDbType.NVarChar;
                sqlParacosto.Size = 100;
                sqlParacosto.Value = objEHCli.Costo;
                sqlCmd.Parameters.Add(sqlParacosto);

                SqlParameter sqlParafecha = new SqlParameter();
                sqlParafecha.ParameterName = "@FechayHoraEntrada";
                sqlParafecha.SqlDbType = SqlDbType.DateTime;
                sqlParafecha.Value = objEHCli.FechayHora;
                sqlCmd.Parameters.Add(sqlParafecha);

                SqlParameter sqlParatiempoalq = new SqlParameter();
                sqlParatiempoalq.ParameterName = "@TiempoAlq";
                sqlParatiempoalq.SqlDbType = SqlDbType.NVarChar;
                sqlParatiempoalq.Size = 100;
                sqlParatiempoalq.Value = objEHCli.TiempoAlq;
                sqlCmd.Parameters.Add(sqlParatiempoalq);


                //5. Ejecutamos el commando
                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se inserto el Cliente de forma correcta";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                //6. Cerramos la conexion con la BD
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return rpta;
        }

        public DataTable BuscaNroRegistro()
        {
            DataTable dtCliente = new DataTable("Cliente");
            SqlConnection sqlCon = new SqlConnection();
            string rpta = "";
            try
            {
                ClsConexion objcon = new ClsConexion();
                objcon.conectar();
                sqlCon.ConnectionString = ClsConexion.ConBDcadena;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;//La conexion que va a usar el comando
                sqlCmd.CommandText = "USP_S_BuscarNumeroRegistroHab";//El comando a ejecutar
                sqlCmd.CommandType = CommandType.StoredProcedure;//Decirle al comando que va a ejecutar una sentencia SQL

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtCliente);//Llenamos el DataTable
            }
            catch (Exception ex)
            {
                dtCliente = null;
            }
            return dtCliente;
        }
    }
}
