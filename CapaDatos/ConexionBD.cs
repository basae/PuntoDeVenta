using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConexionBD
    {
        protected SqlConnection _conexion;
        public ConexionBD()
        {
            _conexion = new SqlConnection();
            _conexion.ConnectionString = ConfigurationManager.AppSettings["CadenaConexion"];
        }

        protected bool EjecutarProcedimientoAlmacenado(string NombreProcedimiento, Dictionary<string,object> Parametros)
        {
            bool resultado = false;
            SqlCommand cmd;
            using (cmd = new SqlCommand(NombreProcedimiento))
            {
                _conexion.Open();
                cmd.Connection = _conexion;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                
                foreach(var parametro in Parametros)
                {
                    cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);
                }

                cmd.ExecuteNonQuery();
                _conexion.Close();
            }
            return resultado;
        }
        protected DataTable EjecutarProcedimientoAlmacenadoDataTable(string NombreProcedimiento, Dictionary<string, object> Parametros = null)
        {
            DataTable resultado = new DataTable();
            SqlCommand cmd;
            SqlDataAdapter adapter;
            using (cmd = new SqlCommand(NombreProcedimiento))
            {
                _conexion.Open();
                cmd.Connection = _conexion;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                if (Parametros != null)
                {
                    foreach (var parametro in Parametros)
                    {
                        cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);
                    }
                }
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(resultado);                
                _conexion.Close();
            }
            return resultado;
        }
    }
}
