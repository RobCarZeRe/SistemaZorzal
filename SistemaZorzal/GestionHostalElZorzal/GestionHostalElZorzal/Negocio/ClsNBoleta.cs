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
    class ClsNBoleta
    {
        public string MtdAgregarBoleta(ClsEBoleta objEc)
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
                sqlCmd.CommandText = "USP_I_AGREGARCOMPROBANTE";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter sqlserieboleta = new SqlParameter();
                sqlserieboleta.ParameterName = "@SerieBo";
                sqlserieboleta.SqlDbType = SqlDbType.VarChar;
                sqlserieboleta.Size = 3;
                sqlserieboleta.Value = objEc.serie;
                sqlCmd.Parameters.Add(sqlserieboleta);

                ///////////////////////////////////////////////////////////

                SqlParameter sqlparanroboleta = new SqlParameter();
                sqlparanroboleta.ParameterName = "@NumeroBo";
                sqlparanroboleta.SqlDbType = SqlDbType.VarChar;
                sqlparanroboleta.Size = 6;
                sqlparanroboleta.Value = objEc.numero;
                sqlCmd.Parameters.Add(sqlparanroboleta);

                ///////////////////////////////////////////////////////////

                SqlParameter sqlparafechaboleta = new SqlParameter();
                sqlparafechaboleta.ParameterName = "@FechaBo";
                sqlparafechaboleta.SqlDbType = SqlDbType.DateTime;
                //sqlparafechaboleta.Size = 50;
                sqlparafechaboleta.Value = objEc.fecha;
                sqlCmd.Parameters.Add(sqlparafechaboleta);

                ///////////////////////////////////////////////////////////

                SqlParameter sqlparatotalboleta = new SqlParameter();
                sqlparatotalboleta.ParameterName = "@TotalBo";
                sqlparatotalboleta.SqlDbType = SqlDbType.Decimal;
                sqlparatotalboleta.Size = 50;
                sqlparatotalboleta.Value = objEc.total;
                sqlCmd.Parameters.Add(sqlparatotalboleta);



                ///////////////////////////////////////////////////////////

                SqlParameter sqlparafrucboleta = new SqlParameter();
                sqlparafrucboleta.ParameterName = "@Fruc";
                sqlparafrucboleta.SqlDbType = SqlDbType.VarChar;
                sqlparafrucboleta.Size = 11;
                sqlparafrucboleta.Value = objEc.ruc;
                sqlCmd.Parameters.Add(sqlparafrucboleta);

                ///////////////////////////////////////////////////////////

                SqlParameter sqlparafdclboleta = new SqlParameter();
                sqlparafdclboleta.ParameterName = "Fdnicliente";
                sqlparafdclboleta.SqlDbType = SqlDbType.VarChar;
                sqlparafdclboleta.Size = 8;
                sqlparafdclboleta.Value = objEc.dniCli;
                sqlCmd.Parameters.Add(sqlparafdclboleta);

                ///////////////////////////////////////////////////////////

                SqlParameter sqlparacodcliboleta = new SqlParameter();
                sqlparacodcliboleta.ParameterName = "@Fcodigoempleado";
                sqlparacodcliboleta.SqlDbType = SqlDbType.VarChar;
                sqlparacodcliboleta.Size = 8;
                sqlparacodcliboleta.Value = objEc.codEmp;
                sqlCmd.Parameters.Add(sqlparacodcliboleta);


                ///////////////////////////////////////////////////////////

                SqlParameter sqlparaestadoboleta = new SqlParameter();
                sqlparaestadoboleta.ParameterName = "@EstadoBol";
                sqlparaestadoboleta.SqlDbType = SqlDbType.VarChar;
                sqlparaestadoboleta.Size = 20;
                sqlparaestadoboleta.Value = objEc.estado;
                sqlCmd.Parameters.Add(sqlparaestadoboleta);
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
