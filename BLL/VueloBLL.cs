using System;
using System.Collections.Generic;
using DomestikAirline.DAL;
using DomestikAirline.Entities;

namespace DomestikAirline.BLL
{
    public class VueloBLL
    {
        VueloDAL dal = new VueloDAL();

        public void Insertar(string numVlo, string destino, DateTime fecha, TimeSpan hora)
        {
            Vuelo v = new Vuelo()
            {
                NumVlo = numVlo,
                Destino = destino,
                Fecha = fecha,
                Hora = hora
            };

            dal.Insertar(v);
        }

        public List<Vuelo> Listar()
        {
            return dal.Listar();
        }

        public void Actualizar(string numvlo, DateTime fecha, TimeSpan hora, string destino)
        {
            Vuelo v = new Vuelo()
            {
                NumVlo = numvlo,
                Fecha = fecha,
                Hora = hora,
                Destino = destino
            };

            dal.Actualizar(v);
        }
    }
}