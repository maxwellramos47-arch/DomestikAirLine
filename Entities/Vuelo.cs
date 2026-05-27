using System;

namespace DomestikAirline.Entities
{
    public class Vuelo
    {
        public string NumVlo { get; set; }

        public DateTime Fecha { get; set; }

        public TimeSpan Hora { get; set; }

        public string Destino { get; set; }
    }
}