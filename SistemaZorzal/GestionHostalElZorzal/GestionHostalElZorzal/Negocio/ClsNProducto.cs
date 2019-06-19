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
    class ClsNProducto
    {
        

        SqlDataAdapter dsqlA = new SqlDataAdapter();
        SqlCommand dsqlC = new SqlCommand();
        DataTable dt = new DataTable();

        public DataTable MtdListarTodoProducto()
        {
            DataTable dtProducto = new DataTable("Producto");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                ClsConexion objcon = new ClsConexion();
                objcon.conectar();

                sqlCon.ConnectionString = ClsConexion.ConBDcadena;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;//la conexion que va a usar el comando
                sqlCmd.CommandText = "USP_S_ListarProducto";//el comando a ejecutar
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
        public DataTable MtdListarTotalProducto()
        {
            DataTable dtProducto = new DataTable("Producto");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                ClsConexion objcon = new ClsConexion();
                objcon.conectar();

                sqlCon.ConnectionString = ClsConexion.ConBDcadena;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;//la conexion que va a usar el comando
                sqlCmd.CommandText = "USP_S_ListarTotalProducto";//el comando a ejecutar
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

        public DataTable MtdListarBajoStockProducto()
        {
            DataTable dtProducto = new DataTable("Producto");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                ClsConexion objcon = new ClsConexion();
                objcon.conectar();

                sqlCon.ConnectionString = ClsConexion.ConBDcadena;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;//la conexion que va a usar el comando
                sqlCmd.CommandText = "USP_S_ListBajoStockProducto";//el comando a ejecutar
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
        public DataTable MtFiltroProducto(ClsEProducto objEP)
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
                sqlCmd.CommandText = "USP_S_BuscarProductoTexto";//El comando a ejecutar
                sqlCmd.CommandType = CommandType.StoredProcedure;//Decirle al comando que va a ejecutar una sentencia SQL

                SqlParameter sqldnicliente = new SqlParameter();
                sqldnicliente.ParameterName = "@Descripcion";
                sqldnicliente.Value = objEP.proDescripcion;
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

        public string MtdAgregarProducto(ClsEProducto objEProd)
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
                sqlCmd.CommandText = "USP_I_AgregarProducto";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parametros al comando
                //Establecemos los valores para el parametro @codigoProducto del Procedimiento Almacenado
                SqlParameter sqldnicliente = new SqlParameter();
                sqldnicliente.ParameterName = "@CodigoPro";
                sqldnicliente.SqlDbType = SqlDbType.VarChar;
                //sqldnicliente.Direction = ParameterDirection.InputOutput;
                sqldnicliente.Size = 6;
                sqldnicliente.Value = objEProd.proCodigo;
                sqlCmd.Parameters.Add(sqldnicliente); //Agregamos el parametro al comando
                                                      //Establecemos los valores para el parametro @nombre del Procedimiento Almacenado
                SqlParameter sqlParnombre = new SqlParameter();
                sqlParnombre.ParameterName = "@DescripcionPro";
                sqlParnombre.SqlDbType = SqlDbType.VarChar;
                sqlParnombre.Size = 100;
                sqlParnombre.Value = objEProd.proDescripcion;
                sqlCmd.Parameters.Add(sqlParnombre); //Agregamos el parametro al comando
                                                     //Establecemos los valores para el parametro @precio del Procedimiento Almacenado
                SqlParameter sqlParCantidad = new SqlParameter();
                sqlParCantidad.ParameterName = "@CantidadPro";
                sqlParCantidad.SqlDbType = SqlDbType.VarChar;
                sqlParCantidad.Size = 3;
                sqlParCantidad.Value = objEProd.proCantidad;
                sqlCmd.Parameters.Add(sqlParCantidad); //Agregamos el parametro al comando

                SqlParameter sqlParPresUnitario = new SqlParameter();
                sqlParPresUnitario.ParameterName = "@PrecioUnitarioPro";
                sqlParPresUnitario.SqlDbType = SqlDbType.Decimal;
                sqlParPresUnitario.Size = 6;
                sqlParPresUnitario.Value = objEProd.proPrecioUnitario;
                sqlCmd.Parameters.Add(sqlParPresUnitario); //Agregamos el parametro al comando
                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se inserto el Cliente de forma correcta";

                //SqlParameter sqlParFoto = new SqlParameter();
                //sqlParFoto.ParameterName = "@FotoPro";
                //sqlParFoto.SqlDbType = SqlDbType.VarChar;
                //sqlParFoto.Size = 100;
                //sqlParFoto.Value = objEProd.proFoto;
                //sqlCmd.Parameters.Add(sqlParFoto); //Agregamos el parametro al comando

                //5. Ejecutamos el commando


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

        public string MtdModificarProducto(ClsEProducto objEProd)
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
                sqlCmd.CommandText = "USP_U_ActualizarProducto";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parametros al comando
                //Establecemos los valores para el parametro @codigoProducto del Procedimiento Almacenado
                SqlParameter sqldnicliente = new SqlParameter();
                sqldnicliente.ParameterName = "@CodigoPro";
                sqldnicliente.SqlDbType = SqlDbType.VarChar;
                //sqldnicliente.Direction = ParameterDirection.InputOutput;
                sqldnicliente.Size = 6;
                sqldnicliente.Value = objEProd.proCodigo;
                sqlCmd.Parameters.Add(sqldnicliente); //Agregamos el parametro al comando
                                                      //Establecemos los valores para el parametro @nombre del Procedimiento Almacenado
                SqlParameter sqlParnombre = new SqlParameter();
                sqlParnombre.ParameterName = "@DescripcionPro";
                sqlParnombre.SqlDbType = SqlDbType.VarChar;
                sqlParnombre.Size = 250;
                sqlParnombre.Value = objEProd.proDescripcion;
                sqlCmd.Parameters.Add(sqlParnombre); //Agregamos el parametro al comando
                                                     //Establecemos los valores para el parametro @precio del Procedimiento Almacenado
                SqlParameter sqlParCantidad = new SqlParameter();
                sqlParCantidad.ParameterName = "@CantidadPro";
                sqlParCantidad.SqlDbType = SqlDbType.VarChar;
                sqlParCantidad.Size = 3;
                sqlParCantidad.Value = objEProd.proCantidad;
                sqlCmd.Parameters.Add(sqlParCantidad); //Agregamos el parametro al comando

                SqlParameter sqlParPresUnitario = new SqlParameter();
                sqlParPresUnitario.ParameterName = "@PrecioUnitarioPro";
                sqlParPresUnitario.SqlDbType = SqlDbType.Decimal;
                sqlParPresUnitario.Size = 6;
                sqlParPresUnitario.Value = objEProd.proPrecioUnitario;
                sqlCmd.Parameters.Add(sqlParPresUnitario); //Agregamos el parametro al comando
                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se inserto el Cliente de forma correcta";
                //SqlParameter sqlParFoto = new SqlParameter();
                //sqlParFoto.ParameterName = "@FotoPro";
                //sqlParFoto.SqlDbType = SqlDbType.VarChar;
                //sqlParFoto.Size = 100;
                //sqlParFoto.Value = objEProd.proFoto;
                //sqlCmd.Parameters.Add(sqlParFoto); //Agregamos el parametro al comando
                ////5. Ejecutamos el commando


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
        public DataTable MtdBuscarporCodigo(ClsEProducto objEPro)
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
                sqlCmd.CommandText = "USP_S_BuscarProducto";//El comando a ejecutar
                sqlCmd.CommandType = CommandType.StoredProcedure;//Decirle al comando que va a ejecutar una sentencia SQL
                SqlParameter sqldnicliente = new SqlParameter();
                sqldnicliente.ParameterName = "@Cod";
                sqldnicliente.Value = objEPro.proCodigo;
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

        public DataTable MtdEliminarProducto(ClsEProducto objEPro)
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
                sqlCmd.CommandText = "USP_D_ELIMINARPRODUCTO";//El comando a ejecutar
                sqlCmd.CommandType = CommandType.StoredProcedure;//Decirle al comando que va a ejecutar una sentencia SQL
                SqlParameter sqldnicliente = new SqlParameter();
                sqldnicliente.ParameterName = "@CODproducto";
                sqldnicliente.Value = objEPro.proCodigo;
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

        public string MtdAumentarProducto(ClsEProducto objProd)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                ClsConexion objcon = new ClsConexion();
                objcon.conectar();
                sqlCon.ConnectionString = ClsConexion.ConBDcadena;
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "USP_U_AUMENTARPRODUCTO";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter sqlcodprod = new SqlParameter();
                sqlcodprod.ParameterName = "@CODprod";
                sqlcodprod.SqlDbType = SqlDbType.NVarChar;
                sqlcodprod.Size = 8;

                sqlcodprod.Value = objProd.proCodigo;
                sqlCmd.Parameters.Add(sqlcodprod);

                ///////////////////////////////////////////////////////////

                SqlParameter sqlparacantprod = new SqlParameter();
                sqlparacantprod.ParameterName = "@CANTprod";
                sqlparacantprod.SqlDbType = SqlDbType.VarChar;
                sqlparacantprod.Size = 10;
                sqlparacantprod.Value = objProd.proCantidad; ;
                sqlCmd.Parameters.Add(sqlparacantprod);
                rpta = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se inserto el Cliente de forma correcta";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {

                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return rpta;
        }
    }
}
