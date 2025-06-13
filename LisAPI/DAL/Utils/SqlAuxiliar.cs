
using Microsoft.Data.SqlClient;
using System.Data;
namespace LisAPI.DAL.Utils
{
    public class SqlAuxiliar : Interfaces.ISqlAuxiliar
    {
        private readonly string? _cadena_de_conexion;
        public SqlAuxiliar(string? cadena_de_conexion)
        {
            _cadena_de_conexion = cadena_de_conexion;
        }
        public DataTable EjecutarTablaProcedimientoAlmacenado(string procedimientoAlmacenado, Dictionary<string, object>? parametros = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_cadena_de_conexion))
            {
                using (SqlCommand cmd = new SqlCommand(procedimientoAlmacenado, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (parametros != null)
                    {
                        foreach (var param in parametros)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    conn.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }    
    }
}
