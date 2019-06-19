using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using GestionHostalElZorzal.Entidad;
using GestionHostalElZorzal.Negocio;



    class ClsNHabitacion
    {
        public DataTable MtdListarTodoHabitacion()
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
                sqlCmd.CommandText = "USP_S_ListarHabitacion";//el comando a ejecutar
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

    public DataTable MtdListarTodoHabitacionporEstado()
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
            sqlCmd.CommandText = "USP_S_HabEstado";//el comando a ejecutar
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

    public string MtdAgregarHabitacion(ClsEHabitacion objECli)
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
                sqlCmd.CommandText = "USP_I_AgregarHabitacion";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parametros al comando
                //Establecemos los valores para el parametro @codigoProducto del Procedimiento Almacenado
                SqlParameter nrohabitacion= new SqlParameter();
                nrohabitacion.ParameterName = "@NroHab";
                nrohabitacion.SqlDbType = SqlDbType.NVarChar;
                //sqldnicliente.Direction = ParameterDirection.InputOutput;
                nrohabitacion.Size = 1000;
                nrohabitacion.Value = objECli.NroHabitacion;
                sqlCmd.Parameters.Add(nrohabitacion); //Agregamos el parametro al comando
                                                      //Establecemos los valores para el parametro @nombre del Procedimiento Almacenado
                SqlParameter sqlPartipohab = new SqlParameter();
            sqlPartipohab.ParameterName = "@TipoHab";
            sqlPartipohab.SqlDbType = SqlDbType.NVarChar;
            sqlPartipohab.Size = 100;
            sqlPartipohab.Value = objECli.TipodeHabitacion;
                sqlCmd.Parameters.Add(sqlPartipohab); //Agregamos el parametro al comando
                                                     //Establecemos los valores para el parametro @precio del Procedimiento Almacenado
                SqlParameter sqlParaprehab = new SqlParameter();
            sqlParaprehab.ParameterName = "@PreHab";
            sqlParaprehab.SqlDbType = SqlDbType.NVarChar;
            sqlParaprehab.Size = 100;
            sqlParaprehab.Value = objECli.Precio;
                sqlCmd.Parameters.Add(sqlParaprehab); //Agregamos el parametro al comando

                SqlParameter sqlParLimphab = new SqlParameter();
            sqlParLimphab.ParameterName = "@LimpHab";
            sqlParLimphab.SqlDbType = SqlDbType.NVarChar;
            sqlParLimphab.Size = 100;
            sqlParLimphab.Value = objECli.Limpieza;
                sqlCmd.Parameters.Add(sqlParLimphab); //Agregamos el parametro al comando

            //Establecemos los valores para el parametro @precio del Procedimiento Almacenado
            SqlParameter sqlParaestad = new SqlParameter();
            sqlParaestad.ParameterName = "@EstaHab";
            sqlParaestad.SqlDbType = SqlDbType.NVarChar;
            sqlParaestad.Size = 100;
            sqlParaestad.Value = objECli.Estado;
            sqlCmd.Parameters.Add(sqlParaestad);

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


    public DataTable MtdBuscarHabitacionNro(ClsEHabitacion objE)
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
            sqlCmd.CommandText = "USP_S_BuscarHabitacion";
            sqlCmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlcodEmp = new SqlParameter();
            sqlcodEmp.ParameterName = "@NroHabitacion";
            sqlcodEmp.Value = objE.NroHabitacion;
            sqlCmd.Parameters.Add(sqlcodEmp);

            
            SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
            sqlDat.Fill(dtEmpleado);

        }
        catch (Exception ex)
        {
            dtEmpleado = null;
        }
        return dtEmpleado;
    }

    public DataTable MtdBuscarHabitacionAlquilada(ClsEHabitacion objE)
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
            sqlCmd.CommandText = "USP_S_BuscarHabitacionAlquilada";
            sqlCmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlcodEmp = new SqlParameter();
            sqlcodEmp.ParameterName = "@NroHabitacion";
            sqlcodEmp.Value = objE.NroHabitacion;
            sqlCmd.Parameters.Add(sqlcodEmp);


            SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
            sqlDat.Fill(dtEmpleado);

        }
        catch (Exception ex)
        {
            dtEmpleado = null;
        }
        return dtEmpleado;
    }

    public string MtdModificarEstadoHab(ClsEHabitacion objECli)
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
            sqlCmd.CommandText = "USP_U_ActualizarEstadohabitacion";
            sqlCmd.CommandType = CommandType.StoredProcedure;

            //4. Agregar los parametros al comando
            //Establecemos los valores para el parametro @codigoProducto del Procedimiento Almacenado
            SqlParameter sqldnicliente = new SqlParameter();
            sqldnicliente.ParameterName = "@NroHab";
            sqldnicliente.SqlDbType = SqlDbType.Int;
            //sqldnicliente.Direction = ParameterDirection.InputOutput;
            
            sqldnicliente.Value = objECli.NroHabitacion;
            sqlCmd.Parameters.Add(sqldnicliente); //Agregamos el parametro al comando
                                                  //Establecemos los valores para el parametro @nombre del Procedimiento Almacenado
            SqlParameter sqlParnombre = new SqlParameter();
            sqlParnombre.ParameterName = "@EstadoHabitacion";
            sqlParnombre.SqlDbType = SqlDbType.Int;
             sqlParnombre.Value = objECli.Estado;
            sqlCmd.Parameters.Add(sqlParnombre); //Agregamos el parametro al comando
                                                 //Establecemos los valores para el parametro @precio del Procedimiento Almacenado
            

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

}

