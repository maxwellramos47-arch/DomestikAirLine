using MySql.Data.MySqlClient;
using DomestikAirline.Entities;
using DomestikAirline.DataBase;

namespace DomestikAirline.DAL
{
    public class ReservaDAL
    {
        BDConnect bd = new BDConnect();

        public void Insertar(Reserva r)
        {
            using (MySqlConnection conn = bd.ObtenerConexion())
            {
                conn.Open();

                string sql = @"
                INSERT INTO reserva
                (tipo,valor,rut,numvlo)
                VALUES
                (@tipo,@valor,@rut,@numvlo)
                ";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@tipo", r.Tipo);
                cmd.Parameters.AddWithValue("@valor", r.Valor);
                cmd.Parameters.AddWithValue("@rut", r.Rut);
                cmd.Parameters.AddWithValue("@numvlo", r.NumVlo);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Reserva> Listar()
        {
            List<Reserva> lista = new List<Reserva>();

            using (MySqlConnection conn = bd.ObtenerConexion())
            {
                conn.Open();

                string sql = "SELECT * FROM reserva";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Reserva r = new Reserva()
                        {
                            Codigo = Convert.ToInt32(reader["codigo"]),

                            Tipo = reader["tipo"].ToString(),

                            Valor = Convert.ToDouble(reader["valor"]),

                            Rut = reader["rut"].ToString(),

                            NumVlo = reader["numvlo"].ToString()
                        };

                    lista.Add(r);
                }
            }

            return lista;
        }

        public void Actualizar(Reserva r)
        {
            using (MySqlConnection conn = bd.ObtenerConexion())
            {
                conn.Open();

                string sql = @"
                UPDATE reserva
                SET
                tipo = @tipo,
                valor = @valor,
                rut = @rut,
                numvlo = @numvlo
                WHERE codigo = @codigo";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@tipo", r.Tipo);
                cmd.Parameters.AddWithValue("@valor", r.Valor);
                cmd.Parameters.AddWithValue("@rut", r.Rut);
                cmd.Parameters.AddWithValue("@numvlo", r.NumVlo);
                cmd.Parameters.AddWithValue("@codigo", r.Codigo);

                cmd.ExecuteNonQuery();
            }
        }
    }
}