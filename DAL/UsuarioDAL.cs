using DomestikAirline.DataBase;
using DomestikAirline.Entities;
using DomestikAirline.Helpers;
using MySql.Data.MySqlClient;

namespace DomestikAirline.DAL
{
    public class UsuarioDAL
    {
        BDConnect bd = new BDConnect();

        public bool Login(string usuario, string password)
        {
            using (MySqlConnection conn = bd.ObtenerConexion())
            {
                conn.Open();

                string sql = @"
                SELECT COUNT(*)
                FROM usuario
                WHERE usuario = @usuario
                AND password = @password";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@usuario", usuario);

                string hash = SecurityHelper.HashPassword(password);

                cmd.Parameters.AddWithValue("@password", hash);

                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());

                return cantidad > 0;
            }
        }

        public bool Registrar(string usuario, string password)
        {
            using (MySqlConnection conn = bd.ObtenerConexion())
            {
                conn.Open();

                string sql = @"
                INSERT INTO usuario (usuario, password)
                VALUES (@usuario, @password)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@usuario", usuario);

                string hash= SecurityHelper.HashPassword(password);

                cmd.Parameters.AddWithValue("@password", hash);

                int filasAfectadas = cmd.ExecuteNonQuery();

                return filasAfectadas > 0;
            }
        }

        public bool ExisteUsuario(string usuario)
        {
            using (MySqlConnection conn = bd.ObtenerConexion())
            {
                conn.Open();

                string sql = @"
                SELECT COUNT(*)
                FROM usuario
                WHERE usuario = @usuario";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@usuario", usuario);

                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());

                return cantidad > 0;
            }
        }
    }
}