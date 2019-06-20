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
    class ClsNVentaProd
    {
        public string MtdAgregarVentaProd(ClsEVentaProd objEHCli)
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
                sqlCmd.CommandText = "USP_I_VentaProd";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parametros al comando
                //Establecemos los valores para el parametro @codigoProducto del Procedimiento Almacenado
                SqlParameter sqldnicliente = new SqlParameter();
                sqldnicliente.ParameterName = "@DniCli";
                sqldnicliente.SqlDbType = SqlDbType.NVarChar;
                //sqldnicliente.Direction = ParameterDirection.InputOutput;
                sqldnicliente.Size = 100;
                sqldnicliente.Value = objEHCli.DniCli;
                sqlCmd.Parameters.Add(sqldnicliente); //Agregamos el parametro al comando
                                                      //Establecemos los valores para el parametro @nombre del Procedimiento Almacenado
                SqlParameter sqlParnombre = new SqlParameter();
                sqlParnombre.ParameterName = "@Codigo";
                sqlParnombre.SqlDbType = SqlDbType.NVarChar;
                sqlParnombre.Size = 100;
                sqlParnombre.Value = objEHCli.Codigo;
                sqlCmd.Parameters.Add(sqlParnombre); //Agregamos el parametro al comando
                                                     //Establecemos los valores para el parametro @precio del Procedimiento Almacenado
                SqlParameter sqlParApellido = new SqlParameter();
                sqlParApellido.ParameterName = "@Cantidad";
                sqlParApellido.SqlDbType = SqlDbType.NVarChar;
                sqlParApellido.Size = 100;
                sqlParApellido.Value = objEHCli.Cantidad;
                sqlCmd.Parameters.Add(sqlParApellido); //Agregamos el parametro al comando

                SqlParameter sqlParEmail = new SqlParameter();
                sqlParEmail.ParameterName = "@PrecioUnit";
                sqlParEmail.SqlDbType = SqlDbType.NVarChar;
                sqlParEmail.Size = 100;
                sqlParEmail.Value = objEHCli.PrecioUnit;
                sqlCmd.Parameters.Add(sqlParEmail); //Agregamos el parametro al comando

                SqlParameter sqlParacosto = new SqlParameter();
                sqlParacosto.ParameterName = "@CantidadCompra";
                sqlParacosto.SqlDbType = SqlDbType.NVarChar;
                sqlParacosto.Size = 100;
                sqlParacosto.Value = objEHCli.CantidadCompra;
                sqlCmd.Parameters.Add(sqlParacosto);

                SqlParameter sqlParafecha = new SqlParameter();
                sqlParafecha.ParameterName = "@Importe";
                sqlParafecha.SqlDbType = SqlDbType.NVarChar;
                sqlParacosto.Size = 100;
                sqlParafecha.Value = objEHCli.Importe;
                sqlCmd.Parameters.Add(sqlParafecha);

                SqlParameter sqlParatiempoalq = new SqlParameter();
                sqlParatiempoalq.ParameterName = "@ImporteFinal";
                sqlParatiempoalq.SqlDbType = SqlDbType.NVarChar;
                sqlParatiempoalq.Size = 100;
                sqlParatiempoalq.Value = objEHCli.ImporteFinal;
                sqlCmd.Parameters.Add(sqlParatiempoalq);

                SqlParameter sqlParaestado = new SqlParameter();
                sqlParaestado.ParameterName = "@Estado";
                sqlParaestado.SqlDbType = SqlDbType.NVarChar;
                sqlParaestado.Size = 100;
                sqlParaestado.Value = objEHCli.Estado;
                sqlCmd.Parameters.Add(sqlParaestado);


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

        public DataTable BuscaProdClienteDNI(ClsEVentaProd objEvp)
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
                sqlCmd.CommandText = "USP_S_BuscaProdClienteDNI";//El comando a ejecutar
                sqlCmd.CommandType = CommandType.StoredProcedure;//Decirle al comando que va a ejecutar una sentencia SQL
                SqlParameter sqldnicliente = new SqlParameter();
                sqldnicliente.ParameterName = "@DniCli";
                sqldnicliente.Value = objEvp.DniCli;
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

        public DataTable BuscaImporteFinal(ClsEVentaProd objEvp)
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
                sqlCmd.CommandText = "USP_S_BuscarImporteFinal";//El comando a ejecutar
                sqlCmd.CommandType = CommandType.StoredProcedure;//Decirle al comando que va a ejecutar una sentencia SQL
                SqlParameter sqldnicliente = new SqlParameter();
                sqldnicliente.ParameterName = "@DniCli";
                sqldnicliente.Value = objEvp.DniCli;
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
                sqlCmd.CommandText = "USP_S_BuscarNumeroRegistro";//El comando a ejecutar
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
