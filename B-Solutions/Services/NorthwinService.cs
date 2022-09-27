using B_Solutions.Data;
using B_Solutions.Models;
using Microsoft.Data.SqlClient;

namespace B_Solutions.Services
{
    public class NorthwinService
    {
        public IConfigurationRoot GetConnection()
        {
            var builder = new ConfigurationBuilder()
                                  .SetBasePath(Directory.GetCurrentDirectory())
                                  .AddJsonFile("appsettings.json").Build();

            return builder;
        }
        public List<TipoProjetoModel> getTipos()
        {
            var connection = GetConnection().GetSection("ConnectionStrings")
                                       .GetSection("DataBase").Value;
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Select idTipos, Nome From Tipos", con);
            con.Open();

            SqlDataReader idr = cmd.ExecuteReader();
            List<TipoProjetoModel> customers = new List<TipoProjetoModel>();

            if (idr.HasRows)
            {
                while (idr.Read())
                {
                    customers.Add(new TipoProjetoModel
                    {
                        IdProjetoTipo = Convert.ToInt16(idr["IdProjetoTipo"]),
                        tipoProjetoNome = Convert.ToString(idr["tipoProjetoNome"]),
                    });
                }
            }
            con.Close();
            return customers;

        }

    }
}
