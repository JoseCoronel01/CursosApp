using Microsoft.Data.SqlClient;
using System.Data;

namespace CursosApp.Data
{
    public class DBGenerica
    {
        private readonly string _connectionString;

        public DBGenerica(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataSet EjecutarSP(string nombreProcedimiento, string[] parametros)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conexion = new SqlConnection(_connectionString))
            {
                using (SqlCommand comando = new SqlCommand(nombreProcedimiento, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    if (parametros != null && parametros.Length > 0)
                    {
                        for (int i = 0; i < parametros.Length; i++)
                        {
                            string parametro = parametros[i];
                            comando.Parameters.AddWithValue($"@param{i + 1}", parametro);
                        }
                    }

                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();
                    if (lector.HasRows)
                        ds.Load(lector, LoadOption.OverwriteChanges, "Resultado");
                }
            }
            return ds;
        }
    }
}
