using DomestikAirline.DAL;
using DomestikAirline.Entities;

namespace DomestikAirline.BLL
{
    public class PasajeroBLL
    {
        PasajeroDAL dal = new PasajeroDAL();

        public void Insertar(string rut, string nombre, string apellido, string tipo)
        {
            Pasajero p = new Pasajero()
            {
                Rut = rut,
                Nombre = nombre,
                Apellido = apellido,
                Tipo = tipo,
                Puntaje = 0
            };

            dal.Insertar(p);
        }

        public List<Pasajero> Listar()
        {
            return dal.Listar();
        }

        public Pasajero ObtenerPorRut(string rut)
        {
            return dal.ObtenerPorRut(rut);
        }

        public void ActualizarPuntaje(string rut, int puntaje)
        {
            dal.ActualizarPuntaje(rut, puntaje);
        }

        public void ActualizarTipo(string rut, string tipo)
        {
            dal.ActualizarTipo(rut, tipo);
        }
    }
}