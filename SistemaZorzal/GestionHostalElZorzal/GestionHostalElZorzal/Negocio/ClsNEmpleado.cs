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
    class ClsNEmpleado
    {
        SqlDataAdapter dsqlA = new SqlDataAdapter();
        SqlCommand dsqlC = new SqlCommand();
        DataTable dt = new DataTable();


        public DataTable MtdValidarLogin(ClsEEmpleado objE)
        {
            DataTable dtEmpleado = new DataTable("Empleado");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                ClsConexion objcon = new ClsConexion();
                objcon.conectar();
                sqlcon.ConnectionString = ClsConexion.ConBDcadena;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlcon;
                sqlCmd.CommandText = "USP_S_Login";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlcodEmp = new SqlParameter();
                sqlcodEmp.ParameterName = "@CodigoEmp";
                sqlcodEmp.Value = objE.empCodigo;
                sqlCmd.Parameters.Add(sqlcodEmp);

                SqlParameter sqlclavEmp = new SqlParameter();
                sqlclavEmp.ParameterName = "@ClaveEmp";
                sqlclavEmp.Value = objE.empClave;
                sqlCmd.Parameters.Add(sqlclavEmp);

                SqlParameter sqlestEmp = new SqlParameter();
                sqlestEmp.ParameterName = "@EstadoEmp";
                sqlestEmp.Value = objE.empEstado;
                sqlCmd.Parameters.Add(sqlestEmp);
                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtEmpleado);

            }
            catch (Exception ex)
            {
                dtEmpleado = null;
            }
            return dtEmpleado;
        }


        public DataTable MtdListarTodoEmpleado()
        {
            DataTable dtEmpleado = new DataTable("Empleado");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                ClsConexion objcon = new ClsConexion();
                objcon.conectar();

                sqlCon.ConnectionString = ClsConexion.ConBDcadena;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;//la conexion que va a usar el comando
                sqlCmd.CommandText = "USP_S_ListarEmpleado";//el comando a ejecutar
                sqlCmd.CommandType = CommandType.StoredProcedure;//Decirle al comando que va 

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtEmpleado);//lenamos el DtaTable
            }
            catch (Exception ex)
            {
                dtEmpleado = null;
            }
            return dtEmpleado;
        }

        public string MtdAgregarEmpleado(ClsEEmpleado objEemp)
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
                sqlCmd.CommandText = "USP_I_AgregarEmpleado";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parametros al comando
                //Establecemos los valores para el parametro @codigoProducto del Procedimiento Almacenado
                SqlParameter sqldnicliente = new SqlParameter();
                sqldnicliente.ParameterName = "@CodigoEmpl";
                sqldnicliente.SqlDbType = SqlDbType.VarChar;
                //sqldnicliente.Direction = ParameterDirection.InputOutput;
                sqldnicliente.Size = 8;
                sqldnicliente.Value = objEemp.empCodigo;
                sqlCmd.Parameters.Add(sqldnicliente); //Agregamos el parametro al comando
                                                      //Establecemos los valores para el parametro @nombre del Procedimiento Almacenado
                SqlParameter sqlParnombre = new SqlParameter();
                sqlParnombre.ParameterName = "@NombreEmpl";
                sqlParnombre.SqlDbType = SqlDbType.VarChar;
                sqlParnombre.Size = 100;
                sqlParnombre.Value = objEemp.empNombres;
                sqlCmd.Parameters.Add(sqlParnombre); //Agregamos el parametro al comando
                                                     //Establecemos los valores para el parametro @precio del Procedimiento Almacenado
                SqlParameter sqlParApellido = new SqlParameter();
                sqlParApellido.ParameterName = "@ApellidoEmpl";
                sqlParApellido.SqlDbType = SqlDbType.VarChar;
                sqlParApellido.Size = 100;
                sqlParApellido.Value = objEemp.empApellidos;
                sqlCmd.Parameters.Add(sqlParApellido); //Agregamos el parametro al comando

                
                SqlParameter sqlParCargo = new SqlParameter();
                sqlParCargo.ParameterName = "@CargoEmpl";
                sqlParCargo.SqlDbType = SqlDbType.VarChar;
                sqlParCargo.Size = 15;
                sqlParCargo.Value = objEemp.empCargo;
                sqlCmd.Parameters.Add(sqlParCargo); //Agregamos el parametro al comando

                SqlParameter sqlParClave = new SqlParameter();
                sqlParClave.ParameterName = "@ClaveEmpl";
                sqlParClave.SqlDbType = SqlDbType.VarChar;
                sqlParClave.Size = 6;
                sqlParClave.Value = objEemp.empClave;
                sqlCmd.Parameters.Add(sqlParClave); //Agregamos el parametro al comando

                SqlParameter sqlParEstado = new SqlParameter();
                sqlParEstado.ParameterName = "@EstadoEmpl";
                sqlParEstado.SqlDbType = SqlDbType.VarChar;
                sqlParEstado.Size = 10;
                sqlParEstado.Value = objEemp.empEstado;
                sqlCmd.Parameters.Add(sqlParEstado); //Agregamos el parametro al comando

                SqlParameter sqlParFoto = new SqlParameter();
                sqlParFoto.ParameterName = "@Foto";
                sqlParFoto.SqlDbType = SqlDbType.VarChar;
                sqlParFoto.Size = 100;
                sqlParFoto.Value = objEemp.empFoto;
                sqlCmd.Parameters.Add(sqlParFoto); //Agregamos el parametro al comando

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

        public string MtdModificarEmpleado(ClsEEmpleado objEemp)
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
                sqlCmd.CommandText = "USP_U_ActualizarEmpleado";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parametros al comando
                //Establecemos los valores para el parametro @codigoProducto del Procedimiento Almacenado
                SqlParameter sqldnicliente = new SqlParameter();
                sqldnicliente.ParameterName = "@CodigoEmpl";
                sqldnicliente.SqlDbType = SqlDbType.VarChar;
                //sqldnicliente.Direction = ParameterDirection.InputOutput;
                sqldnicliente.Size = 8;
                sqldnicliente.Value = objEemp.empCodigo;
                sqlCmd.Parameters.Add(sqldnicliente); //Agregamos el parametro al comando
                                                      //Establecemos los valores para el parametro @nombre del Procedimiento Almacenado
                SqlParameter sqlParnombre = new SqlParameter();
                sqlParnombre.ParameterName = "@NombreEmpl";
                sqlParnombre.SqlDbType = SqlDbType.VarChar;
                sqlParnombre.Size = 100;
                sqlParnombre.Value = objEemp.empNombres;
                sqlCmd.Parameters.Add(sqlParnombre); //Agregamos el parametro al comando
                                                     //Establecemos los valores para el parametro @precio del Procedimiento Almacenado
                SqlParameter sqlParApellido = new SqlParameter();
                sqlParApellido.ParameterName = "@ApellidoEmpl";
                sqlParApellido.SqlDbType = SqlDbType.VarChar;
                sqlParApellido.Size = 100;
                sqlParApellido.Value = objEemp.empApellidos;
                sqlCmd.Parameters.Add(sqlParApellido); //Agregamos el parametro al comando
                            
                    

                SqlParameter sqlParCargo = new SqlParameter();
                sqlParCargo.ParameterName = "@CargoEmpl";
                sqlParCargo.SqlDbType = SqlDbType.VarChar;
                sqlParCargo.Size = 15;
                sqlParCargo.Value = objEemp.empCargo;
                sqlCmd.Parameters.Add(sqlParCargo); //Agregamos el parametro al comando

                SqlParameter sqlParClave = new SqlParameter();
                sqlParClave.ParameterName = "@ClaveEmpl";
                sqlParClave.SqlDbType = SqlDbType.VarChar;
                sqlParClave.Size = 6;
                sqlParClave.Value = objEemp.empClave;
                sqlCmd.Parameters.Add(sqlParClave); //Agregamos el parametro al comando

                SqlParameter sqlParEstado = new SqlParameter();
                sqlParEstado.ParameterName = "@EstadoEmpl";
                sqlParEstado.SqlDbType = SqlDbType.VarChar;
                sqlParEstado.Size = 10;
                sqlParEstado.Value = objEemp.empEstado;
                sqlCmd.Parameters.Add(sqlParEstado); //Agregamos el parametro al comando

                SqlParameter sqlParFoto = new SqlParameter();
                sqlParFoto.ParameterName = "@Foto";
                sqlParFoto.SqlDbType = SqlDbType.VarChar;
                sqlParFoto.Size = 100;
                sqlParFoto.Value = objEemp.empFoto;
                sqlCmd.Parameters.Add(sqlParFoto); //Agregamos el parametro al comando

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

        public DataTable MtdEliminarEmpleado(ClsEEmpleado objEemp)
        {
            DataTable dtEmpleado = new DataTable("Empleado");
            SqlConnection sqlCon = new SqlConnection();
            string rpta = "";
            try
            {
                ClsConexion objcon = new ClsConexion();
                objcon.conectar();
                sqlCon.ConnectionString = ClsConexion.ConBDcadena;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;//La conexion que va a usar el comando
                sqlCmd.CommandText = "USP_D_EliminarEmpleado";//El comando a ejecutar
                sqlCmd.CommandType = CommandType.StoredProcedure;//Decirle al comando que va a ejecutar una sentencia SQL
                SqlParameter sqldnicliente = new SqlParameter();
                sqldnicliente.ParameterName = "@Codigo";
                sqldnicliente.Value = objEemp.empCodigo;
                sqlCmd.Parameters.Add(sqldnicliente);
                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtEmpleado);//Llenamos el DataTable
            }
            catch (Exception ex)
            {
                dtEmpleado = null;
            }
            return dtEmpleado;
        }

        public DataTable MtdBuscarporCodigo(ClsEEmpleado objEemp)
        {
            DataTable dtEmpleado = new DataTable("Empleado");
            SqlConnection sqlCon = new SqlConnection();
            string rpta = "";
            try
            {
                ClsConexion objcon = new ClsConexion();
                objcon.conectar();
                sqlCon.ConnectionString = ClsConexion.ConBDcadena;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;//La conexion que va a usar el comando
                sqlCmd.CommandText = "USP_S_BuscarEmpleado";//El comando a ejecutar
                sqlCmd.CommandType = CommandType.StoredProcedure;//Decirle al comando que va a ejecutar una sentencia SQL
                SqlParameter sqldnicliente = new SqlParameter();
                sqldnicliente.ParameterName = "@Codigo";
                sqldnicliente.Value = objEemp.empCodigo;
                sqlCmd.Parameters.Add(sqldnicliente);
                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtEmpleado);//Llenamos el DataTable
            }
            catch (Exception ex)
            {
                dtEmpleado = null;
            }
            return dtEmpleado;
        }

    }


}
