using DomestikAirline.DAL;
using DomestikAirline.Entities;

namespace DomestikAirline.BLL
{
    public class ReservaBLL
    {
        ReservaDAL reservaDAL = new ReservaDAL();

        PasajeroBLL pasajeroBLL = new PasajeroBLL();

        public void Insertar(string tipo, double valor, string rut, string numvlo)
        {
            Reserva r = new Reserva()
            {
                Tipo = tipo,
                Valor = valor,
                Rut = rut,
                NumVlo = numvlo
            };

            reservaDAL.Insertar(r);

            Pasajero pasajero = pasajeroBLL.ObtenerPorRut(rut);

            if (pasajero.Tipo == "Frecuente")
            {
                int puntos = 0;

                switch (tipo)
                {
                    case "Económica":
                        puntos = 500;
                        break;

                    case "Turista":
                        puntos = 700;
                        break;

                    case "Ejecutivo":
                        puntos = 1000;
                        break;
                }

                int nuevoPuntaje = pasajero.Puntaje + puntos;

                pasajeroBLL.ActualizarPuntaje(rut, nuevoPuntaje);
            }
        }

        public List<Reserva> Listar()
        {
            return reservaDAL.Listar();
        }

        public void Actualizar(int codigo, string tipo, double valor, string rut, string numvlo)
        {
            Reserva r = new Reserva()
            {
                Codigo = codigo,
                Tipo = tipo,
                Valor = valor,
                Rut = rut,
                NumVlo = numvlo
            };
            reservaDAL.Actualizar(r);
        }

        public string ObtenerCondicion(string tipo)
        {
            switch (tipo)
            {
                case "Económica":
                    return
                    "No sujeta a cambio";

                case "Turista":
                    return
                    "Para cambio debe pagar 10% del valor base";

                case "Ejecutivo":
                    return
                    "Puede efectuar cambio sin costo";

                default:
                    return
                    "Tipo inválido";
            }
        }
    }
}