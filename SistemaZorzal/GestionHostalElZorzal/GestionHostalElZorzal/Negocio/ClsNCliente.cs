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
    class ClsNCliente
    {
        public DataTable MtdListarTodoCliente()
        {
            DataTable dtCliente = new DataTable("Cliente");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                ClsConexion objcon = new ClsConexion();
                objcon.conectar();

                sqlCon.ConnectionString = ClsConexion.ConBDcadena;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;//la conexion que va a usar el comando
                sqlCmd.CommandText = "USP_S_ListarCliente";//el comando a ejecutar
                sqlCmd.CommandType = CommandType.StoredProcedure;//Decirle al comando que va 

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtCliente);//lenamos el DtaTable
            }
            catch (Exception ex)
            {
                dtCliente = null;
            }
            return dtCliente;
        }

        public DataTable MtdBuscarporDni(ClsECliente objECli)
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
                sqlCmd.CommandText = "USP_S_BuscarCliente";//El comando a ejecutar
                sqlCmd.CommandType = CommandType.StoredProcedure;//Decirle al comando que va a ejecutar una sentencia SQL
                SqlParameter sqldnicliente = new SqlParameter();
                sqldnicliente.ParameterName = "@DNiCli";
                sqldnicliente.Value = objECli.cliDni;
                sqlCmd.Parameters.Add(sqldnicliente);
                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtCliente);//Llenamos el DataTable
            }
            catch (Exception ex)
            {
                dtCliente = null;
            }
            return dtCliente;
        }

        public string MtdAgregarCliente(ClsECliente objECli)
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
                sqlCmd.CommandText = "USP_I_AgregarCliente";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parametros al comando
                //Establecemos los valores para el parametro @codigoProducto del Procedimiento Almacenado
                SqlParameter sqldnicliente = new SqlParameter();
                sqldnicliente.ParameterName = "@DniCli";
                sqldnicliente.SqlDbType = SqlDbType.VarChar;
                //sqldnicliente.Direction = ParameterDirection.InputOutput;
                sqldnicliente.Size = 8;
                sqldnicliente.Value = objECli.cliDni;
                sqlCmd.Parameters.Add(sqldnicliente); //Agregamos el parametro al comando
                                                      //Establecemos los valores para el parametro @nombre del Procedimiento Almacenado
                SqlParameter sqlParnombre = new SqlParameter();
                sqlParnombre.ParameterName = "@NombreCli";
                sqlParnombre.SqlDbType = SqlDbType.VarChar;
                sqlParnombre.Size = 100;
                sqlParnombre.Value = objECli.cliNombre;
                sqlCmd.Parameters.Add(sqlParnombre); //Agregamos el parametro al comando
                                                     //Establecemos los valores para el parametro @precio del Procedimiento Almacenado
                SqlParameter sqlParApellido = new SqlParameter();
                sqlParApellido.ParameterName = "@ApellidoCli";
                sqlParApellido.SqlDbType = SqlDbType.VarChar;
                sqlParApellido.Size = 100;
                sqlParApellido.Value = objECli.cliApellido;
                sqlCmd.Parameters.Add(sqlParApellido); //Agregamos el parametro al comando

                SqlParameter sqlParEmail = new SqlParameter();
                sqlParEmail.ParameterName = "@EmailCli";
                sqlParEmail.SqlDbType = SqlDbType.VarChar;
                sqlParEmail.Size = 100;
                sqlParEmail.Value = objECli.cliEmail;
                sqlCmd.Parameters.Add(sqlParEmail); //Agregamos el parametro al comando

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

        public string MtdModificarCliente(ClsECliente objECli)
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
                sqlCmd.CommandText = "USP_U_ActualizarCliente";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parametros al comando
                //Establecemos los valores para el parametro @codigoProducto del Procedimiento Almacenado
                SqlParameter sqldnicliente = new SqlParameter();
                sqldnicliente.ParameterName = "@DniCli";
                sqldnicliente.SqlDbType = SqlDbType.VarChar;
                //sqldnicliente.Direction = ParameterDirection.InputOutput;
                sqldnicliente.Size = 8;
                sqldnicliente.Value = objECli.cliDni;
                sqlCmd.Parameters.Add(sqldnicliente); //Agregamos el parametro al comando
                                                      //Establecemos los valores para el parametro @nombre del Procedimiento Almacenado
                SqlParameter sqlParnombre = new SqlParameter();
                sqlParnombre.ParameterName = "@NombreCli";
                sqlParnombre.SqlDbType = SqlDbType.VarChar;
                sqlParnombre.Size = 100;
                sqlParnombre.Value = objECli.cliNombre;
                sqlCmd.Parameters.Add(sqlParnombre); //Agregamos el parametro al comando
                                                     //Establecemos los valores para el parametro @precio del Procedimiento Almacenado
                SqlParameter sqlParApellido = new SqlParameter();
                sqlParApellido.ParameterName = "@ApellidoCli";
                sqlParApellido.SqlDbType = SqlDbType.VarChar;
                sqlParApellido.Size = 100;
                sqlParApellido.Value = objECli.cliApellido;
                sqlCmd.Parameters.Add(sqlParApellido); //Agregamos el parametro al comando

                SqlParameter sqlParEmail = new SqlParameter();
                sqlParEmail.ParameterName = "@EmailCli";
                sqlParEmail.SqlDbType = SqlDbType.VarChar;
                sqlParEmail.Size = 100;
                sqlParEmail.Value = objECli.cliEmail;
                sqlCmd.Parameters.Add(sqlParEmail); //Agregamos el parametro al comando

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

        public DataTable MtdEliminarCli(ClsECliente objECli)
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
                sqlCmd.CommandText = "USP_D_EliminarCliente";//El comando a ejecutar
                sqlCmd.CommandType = CommandType.StoredProcedure;//Decirle al comando que va a ejecutar una sentencia SQL
                SqlParameter sqldnicliente = new SqlParameter();
                sqldnicliente.ParameterName = "@DniCli";
                sqldnicliente.Value = objECli.cliDni;
                sqlCmd.Parameters.Add(sqldnicliente);
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
