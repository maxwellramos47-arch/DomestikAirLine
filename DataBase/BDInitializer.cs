using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using DomestikAirline.Helpers;

namespace DomestikAirline.DataBase
{
    public class BDInitializer
    {
        private string servidor =
        "Server=localhost;Uid=root;Pwd=;";

        public void CrearBaseDatos()
        {
            using (MySqlConnection conexion = new MySqlConnection(servidor))
            {
                conexion.Open();

                string sq1 = "CREATE DATABASE IF NOT EXISTS domestik;";

                MySqlCommand cmd = new MySqlCommand(sq1, conexion);

                cmd.ExecuteNonQuery();
            }
        }

        public void CrearTablas()
        {
            string conexionBD =
                "Server=localhost;" +
                "Database=domestik;" +
                "Uid=root;" +
                "Pwd=;";

            using (MySqlConnection conn = new MySqlConnection(conexionBD))
            {
                conn.Open();

                CrearTablaUsuario(conn);
                CrearTablaPasajero(conn);
                CrearTablaVuelo(conn);
                CrearTablaReserva(conn);
                InsertarDatosPrueba(conn);
            }
        }

        private void CrearTablaUsuario(MySqlConnection conexion)
        {
            string sq1 = @"
            CREATE TABLE IF NOT EXISTS usuario(
                id int primary key auto_increment,
                usuario varchar(50) not null,
                password varchar(255) not null
            )";

            MySqlCommand cmd = new MySqlCommand(sq1, conexion);

            cmd.ExecuteNonQuery();

            string hashAdmin = SecurityHelper.HashPassword("admin");

            string admin = @"
            INSERT INTO usuario (usuario, password)
            SELECT @usuario, @password
            WHERE NOT EXISTS (
                SELECT 1 
                FROM usuario 
                WHERE usuario = @usuario
            )";

            MySqlCommand cmdAdmin = new MySqlCommand(admin, conexion);

            cmdAdmin.Parameters.AddWithValue("@usuario", "admin");
            cmdAdmin.Parameters.AddWithValue("@password", hashAdmin);

            cmdAdmin.ExecuteNonQuery();
        }

        private void CrearTablaPasajero(MySqlConnection conexion)
        {
            string sql = @"
            CREATE TABLE IF NOT EXISTS pasajero(
                rut VARCHAR(10) PRIMARY KEY,
                nombre VARCHAR(50),
                apellido VARCHAR(50),
                tipo VARCHAR(20),
                puntaje INT
            )";

            MySqlCommand cmd = new MySqlCommand(sql, conexion);

            cmd.ExecuteNonQuery();
        }

        private void CrearTablaVuelo(MySqlConnection conexion)
        {
            string sql = @"
            CREATE TABLE IF NOT EXISTS vuelo(
                numvlo VARCHAR(10) PRIMARY KEY,
                fecha DATE,
                hora TIME,
                destino VARCHAR(30)
            )";

            MySqlCommand cmd = new MySqlCommand(sql, conexion);

            cmd.ExecuteNonQuery();
        }

        private void CrearTablaReserva(MySqlConnection conexion)
        {
            string sql = @"
            CREATE TABLE IF NOT EXISTS reserva(
                codigo INT PRIMARY KEY AUTO_INCREMENT,
                tipo VARCHAR(20),
                valor DOUBLE,
                rut VARCHAR(10),
                numvlo VARCHAR(10),

                FOREIGN KEY(rut)
                    REFERENCES pasajero(rut),

                FOREIGN KEY(numvlo)
                    REFERENCES vuelo(numvlo)
            )";

            MySqlCommand cmd = new MySqlCommand(sql, conexion);

            cmd.ExecuteNonQuery();
        }

        private void InsertarDatosPrueba(MySqlConnection conexion)
        {
            string pasajero1 = @"
            INSERT INTO pasajero
            (rut, nombre, apellido, tipo, puntaje)
            SELECT
            '12345678-9',
            'Juan',
            'Perez',
            'Normal',
            0
            WHERE NOT EXISTS
            (
                SELECT 1
                FROM pasajero
                WHERE rut = '12345678-9'
            )";

            MySqlCommand cmdPas1 = new MySqlCommand(pasajero1, conexion);

            cmdPas1.ExecuteNonQuery();

            string pasajero2 = @"
            INSERT INTO pasajero
            (rut, nombre, apellido, tipo, puntaje)
            SELECT
            '98765432-1',
            'Maria',
            'Gonzalez',
            'Frecuente',
            0
            WHERE NOT EXISTS
            (
                SELECT 1
                FROM pasajero
                WHERE rut = '98765432-1'
            )";

            MySqlCommand cmdPas2 = new MySqlCommand(pasajero2, conexion);

            cmdPas2.ExecuteNonQuery();

            string vuelo1 = @"
            INSERT INTO vuelo
            (numvlo, fecha, hora, destino)
            SELECT
            'VL001',
            '2026-05-27',
            '10:00:00',
            'Santiago'
            WHERE NOT EXISTS
            (
                SELECT 1
                FROM vuelo
                WHERE numvlo = 'VL001'
            )";

            MySqlCommand cmdVuelo1 = new MySqlCommand(vuelo1, conexion);

            cmdVuelo1.ExecuteNonQuery();

            string vuelo2 = @"
            INSERT INTO vuelo
            (numvlo, fecha, hora, destino)
            SELECT
            'VL002',
            '2026-05-28',
            '15:00:00',
            'Valparaiso'
            WHERE NOT EXISTS
            (
                SELECT 1
                FROM vuelo
                WHERE numvlo = 'VL002'
            )";

            MySqlCommand cmdVuelo2 = new MySqlCommand(vuelo2, conexion);

            cmdVuelo2.ExecuteNonQuery();

            string reserva1 = @"
            INSERT INTO reserva
            (tipo, valor, rut, numvlo)
            SELECT
            'Económica',
            100000,
            '98765432-1',
            'VL001'
            WHERE NOT EXISTS
            (
                SELECT 1
                FROM reserva
                WHERE rut = '98765432-1' AND numvlo = 'VL001'
            )";

            MySqlCommand cmdReserva1 = new MySqlCommand(reserva1, conexion);

            cmdReserva1.ExecuteNonQuery();
        }
    }
}
