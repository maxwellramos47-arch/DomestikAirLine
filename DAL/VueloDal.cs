using MySql.Data.MySqlClient;
using DomestikAirline.Entities;
using DomestikAirline.DataBase;

namespace DomestikAirline.DAL
{
    public class VueloDAL
    {
        BDConnect bd = new BDConnect();

        public void Insertar(Vuelo v)
        {
            using (MySqlConnection conn = bd.ObtenerConexion())
            {
                conn.Open();

                string sql = @"
                INSERT INTO vuelo
                (numvlo,fecha,hora,destino)
                VALUES
                (@numvlo,@fecha,@hora,@destino)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@numvlo", v.NumVlo);
                cmd.Parameters.AddWithValue("@fecha", v.Fecha);
                cmd.Parameters.AddWithValue("@hora",v.Hora);
                cmd.Parameters.AddWithValue("@destino", v.Destino);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Vuelo> Listar()
        {
            List<Vuelo> lista = new List<Vuelo>();

            using (MySqlConnection conn = bd.ObtenerConexion())
            {
                conn.Open();

                string sql = "SELECT * FROM vuelo";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Vuelo v = new Vuelo()
                    {
                        NumVlo = reader["numvlo"].ToString(),

                        Fecha = Convert.ToDateTime(reader["fecha"]),

                        Hora = TimeSpan.Parse(reader["hora"].ToString()),

                        Destino = reader["destino"].ToString()
                    };

                    lista.Add(v);
                }
            }

            return lista;
        }

        public void Actualizar(Vuelo v)
        {
            using (MySqlConnection conn = bd.ObtenerConexion())
            {
                conn.Open();

                string sql = @"
                UPDATE vuelo
                SET
                fecha = @fecha,
                hora = @hora,
                destino = @destino
                WHERE numvlo = @numvlo
                ";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@fecha", v.Fecha);
                cmd.Parameters.AddWithValue("@hora",v.Hora);
                cmd.Parameters.AddWithValue("@destino", v.Destino);
                cmd.Parameters.AddWithValue("@numvlo", v.NumVlo);

                cmd.ExecuteNonQuery();
            }
        }
    }
}