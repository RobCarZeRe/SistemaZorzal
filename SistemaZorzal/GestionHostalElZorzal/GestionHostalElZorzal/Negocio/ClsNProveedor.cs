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
    class ClsNProveedor
    {
        SqlDataAdapter dsqlA = new SqlDataAdapter();
        SqlCommand dsqlC = new SqlCommand();
        DataTable dt = new DataTable();

        public DataTable MtdListarTodoProveedor()
        {
            DataTable dtProducto = new DataTable("Proveedor");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                ClsConexion objcon = new ClsConexion();
                objcon.conectar();

                sqlCon.ConnectionString = ClsConexion.ConBDcadena;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;//la conexion que va a usar el comando
                sqlCmd.CommandText = "USP_S_ListarProveedor";//el comando a ejecutar
                sqlCmd.CommandType = CommandType.StoredProcedure;//Decirle al comando que va 

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtProducto);//lenamos el DtaTable
            }
            catch (Exception ex)
            {
                dtProducto = null;
            }
            return dtProducto;
        }

        public string MtdAgregarProveedor(ClsEProveedor objEProv)
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
                sqlCmd.CommandText = "USP_I_AgregarProveedor";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parametros al comando
                //Establecemos los valores para el parametro @codigoProducto del Procedimiento Almacenado
                SqlParameter sqldnicliente = new SqlParameter();
                sqldnicliente.ParameterName = "@CodigoProv";
                sqldnicliente.SqlDbType = SqlDbType.VarChar;
                //sqldnicliente.Direction = ParameterDirection.InputOutput;
                sqldnicliente.Size = 6;
                sqldnicliente.Value = objEProv.provCodigo;
                sqlCmd.Parameters.Add(sqldnicliente); //Agregamos el parametro al comando
                                                      //Establecemos los valores para el parametro @nombre del Procedimiento Almacenado
                SqlParameter sqlParnombre = new SqlParameter();
                sqlParnombre.ParameterName = "@NombreProv";
                sqlParnombre.SqlDbType = SqlDbType.VarChar;
                sqlParnombre.Size = 100;
                sqlParnombre.Value = objEProv.provNombre;
                sqlCmd.Parameters.Add(sqlParnombre); //Agregamos el parametro al comando
                                                     //Establecemos los valores para el parametro @precio del Procedimiento Almacenado
                SqlParameter sqlParDireccion = new SqlParameter();
                sqlParDireccion.ParameterName = "@DireccionProv";
                sqlParDireccion.SqlDbType = SqlDbType.VarChar;
                sqlParDireccion.Size = 255;
                sqlParDireccion.Value = objEProv.provDireccion;
                sqlCmd.Parameters.Add(sqlParDireccion); //Agregamos el parametro al comando

                SqlParameter sqlParRuc = new SqlParameter();
                sqlParRuc.ParameterName = "@RucProv";
                sqlParRuc.SqlDbType = SqlDbType.Decimal;
                sqlParRuc.Size = 11;
                sqlParRuc.Value = objEProv.provRuc;
                sqlCmd.Parameters.Add(sqlParRuc); //Agregamos el parametro al comando

                SqlParameter sqlParTelefono = new SqlParameter();
                sqlParTelefono.ParameterName = "@TelefonoProv";
                sqlParTelefono.SqlDbType = SqlDbType.VarChar;
                sqlParTelefono.Size = 9;
                sqlParTelefono.Value = objEProv.provTelefono;
                sqlCmd.Parameters.Add(sqlParTelefono); //Agregamos el parametro al comando

                SqlParameter sqlParEmail = new SqlParameter();
                sqlParEmail.ParameterName = "@EmailProv";
                sqlParEmail.SqlDbType = SqlDbType.VarChar;
                sqlParEmail.Size = 255;
                sqlParEmail.Value = objEProv.provEmail;
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

        public string MtdModificarProveedor(ClsEProveedor objEProv)
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
                sqlCmd.CommandText = "USP_U_ActualizarProveedor";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parametros al comando
                //Establecemos los valores para el parametro @codigoProducto del Procedimiento Almacenado
                SqlParameter sqldnicliente = new SqlParameter();
                sqldnicliente.ParameterName = "@CodigoProv";
                sqldnicliente.SqlDbType = SqlDbType.VarChar;
                //sqldnicliente.Direction = ParameterDirection.InputOutput;
                sqldnicliente.Size = 6;
                sqldnicliente.Value = objEProv.provCodigo;
                sqlCmd.Parameters.Add(sqldnicliente); //Agregamos el parametro al comando
                                                      //Establecemos los valores para el parametro @nombre del Procedimiento Almacenado
                SqlParameter sqlParnombre = new SqlParameter();
                sqlParnombre.ParameterName = "@NombreProv";
                sqlParnombre.SqlDbType = SqlDbType.VarChar;
                sqlParnombre.Size = 100;
                sqlParnombre.Value = objEProv.provNombre;
                sqlCmd.Parameters.Add(sqlParnombre); //Agregamos el parametro al comando
                                                     //Establecemos los valores para el parametro @precio del Procedimiento Almacenado
                SqlParameter sqlParDireccion = new SqlParameter();
                sqlParDireccion.ParameterName = "@DireccionProv";
                sqlParDireccion.SqlDbType = SqlDbType.VarChar;
                sqlParDireccion.Size = 255;
                sqlParDireccion.Value = objEProv.provDireccion;
                sqlCmd.Parameters.Add(sqlParDireccion); //Agregamos el parametro al comando

                SqlParameter sqlParRuc = new SqlParameter();
                sqlParRuc.ParameterName = "@RucProv";
                sqlParRuc.SqlDbType = SqlDbType.Decimal;
                sqlParRuc.Size = 11;
                sqlParRuc.Value = objEProv.provRuc;
                sqlCmd.Parameters.Add(sqlParRuc); //Agregamos el parametro al comando

                SqlParameter sqlParTelefono = new SqlParameter();
                sqlParTelefono.ParameterName = "@TelefonoProv";
                sqlParTelefono.SqlDbType = SqlDbType.VarChar;
                sqlParTelefono.Size = 9;
                sqlParTelefono.Value = objEProv.provTelefono;
                sqlCmd.Parameters.Add(sqlParTelefono); //Agregamos el parametro al comando

                SqlParameter sqlParEmail = new SqlParameter();
                sqlParEmail.ParameterName = "@EmailProv";
                sqlParEmail.SqlDbType = SqlDbType.VarChar;
                sqlParEmail.Size = 255;
                sqlParEmail.Value = objEProv.provEmail;
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
        public DataTable MtdBuscarporCodigo(ClsEProveedor objEProv)
        {
            DataTable dtCliente = new DataTable("Proveedor");
            SqlConnection sqlCon = new SqlConnection();
            string rpta = "";
            try
            {
                ClsConexion objcon = new ClsConexion();
                objcon.conectar();
                sqlCon.ConnectionString = ClsConexion.ConBDcadena;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;//La conexion que va a usar el comando
                sqlCmd.CommandText = "USP_S_BuscarProveedor";//El comando a ejecutar
                sqlCmd.CommandType = CommandType.StoredProcedure;//Decirle al comando que va a ejecutar una sentencia SQL
                SqlParameter sqlcodproveedor = new SqlParameter();
                sqlcodproveedor.ParameterName = "@CodigoProv";
                sqlcodproveedor.Value = objEProv.provCodigo;
                sqlCmd.Parameters.Add(sqlcodproveedor);
                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtCliente);//Llenamos el DataTable
            }
            catch (Exception ex)
            {
                dtCliente = null;
            }
            return dtCliente;
        }

        public DataTable MtdEliminarProveedor(ClsEProveedor objEProv)
        {
            DataTable dtCliente = new DataTable("Proveedor");
            SqlConnection sqlCon = new SqlConnection();
            string rpta = "";
            try
            {
                ClsConexion objcon = new ClsConexion();
                objcon.conectar();
                sqlCon.ConnectionString = ClsConexion.ConBDcadena;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;//La conexion que va a usar el comando
                sqlCmd.CommandText = "USP_D_EliminarProveedor";//El comando a ejecutar
                sqlCmd.CommandType = CommandType.StoredProcedure;//Decirle al comando que va a ejecutar una sentencia SQL
                SqlParameter sqlcodproveedor = new SqlParameter();
                sqlcodproveedor.ParameterName = "@CodigoProv";
                sqlcodproveedor.Value = objEProv.provCodigo;
                sqlCmd.Parameters.Add(sqlcodproveedor);
                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtCliente);//Llenamos el DataTable
            }
            catch (Exception ex)
            {
                dtCliente = null;
            }
            return dtCliente;
        }


        public DataTable MtdListarProvedorPorNombre()
        {
            DataTable dtProducto = new DataTable("Proveedor");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                ClsConexion objcon = new ClsConexion();
                objcon.conectar();

                sqlCon.ConnectionString = ClsConexion.ConBDcadena;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;//la conexion que va a usar el comando
                sqlCmd.CommandText = "USP_S_PROVE";//el comando a ejecutar
                sqlCmd.CommandType = CommandType.StoredProcedure;//Decirle al comando que va 

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtProducto);//lenamos el DtaTable
            }
            catch (Exception ex)
            {
                dtProducto = null;
            }
            return dtProducto;
        }
    }
}
