using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace DomestikAirline.DataBase
{
    public class BDConnect
    {
        private string conexion =
            "Server=localhost;" +
            "Database=domestik;" +
            "Uid=root;" +
            "Pwd=;";

        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(conexion);
        }
    }
}
