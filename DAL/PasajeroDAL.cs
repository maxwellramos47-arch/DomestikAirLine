using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using DomestikAirline.Entities;
using DomestikAirline.DataBase;

namespace DomestikAirline.DAL
{
    public class PasajeroDAL
    {
        BDConnect bd = new BDConnect();

        public void Insertar(Pasajero p)
        {
            using (MySqlConnection conn = bd.ObtenerConexion())
            {
                conn.Open();

                string sql = @"
                INSERT INTO pasajero
                (rut,nombre,apellido,tipo,puntaje)

                VALUES

                (@rut,@nombre,@apellido,@tipo,@puntaje)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@rut", p.Rut);
                cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@apellido", p.Apellido);
                cmd.Parameters.AddWithValue("@tipo", p.Tipo);
                cmd.Parameters.AddWithValue("@puntaje", p.Puntaje);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Pasajero> Listar()
        {
            List<Pasajero> lista = new List<Pasajero>();

            using (MySqlConnection conn = bd.ObtenerConexion())
            {
                conn.Open();

                string sql = "SELECT * FROM pasajero";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Pasajero p =
                        new Pasajero()
                        {
                            Rut = reader["rut"].ToString(),
                            Nombre = reader["nombre"].ToString(),
                            Apellido = reader["apellido"].ToString(),
                            Tipo = reader["tipo"].ToString(),
                            Puntaje = Convert.ToInt32(reader["puntaje"])
                        };

                    lista.Add(p);
                }
            }

            return lista;
        }

        public Pasajero ObtenerPorRut(string rut)
        {
            using (MySqlConnection conn = bd.ObtenerConexion())
            {
                conn.Open();

                string sql = @"
                SELECT *
                FROM pasajero
                WHERE rut = @rut
                ";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@rut", rut);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Pasajero()
                    {
                        Rut = reader["rut"].ToString(),
                        Nombre = reader["nombre"].ToString(),
                        Apellido = reader["apellido"].ToString(),
                        Tipo = reader["tipo"].ToString(),
                        Puntaje = Convert.ToInt32(reader["puntaje"])
                    };
                }
            }

            return null;
        }

        public void ActualizarPuntaje(string rut, int puntaje)
        {
            using (MySqlConnection conn = bd.ObtenerConexion())
            {
                conn.Open();

                string sql = @"
                UPDATE pasajero
                SET puntaje = @puntaje
                WHERE rut = @rut
                ";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@puntaje", puntaje);
                cmd.Parameters.AddWithValue("@rut", rut);

                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarTipo(string rut, string tipo)
        {
            using (MySqlConnection conn = bd.ObtenerConexion())
            {
                conn.Open();

                string sql = @"
                UPDATE pasajero
                SET tipo = @tipo
                WHERE rut = @rut
                ";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@rut", rut);

                cmd.ExecuteNonQuery();
            }
        }
    }
}