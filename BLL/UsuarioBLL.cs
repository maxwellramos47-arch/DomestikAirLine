using DomestikAirline.DAL;
using DomestikAirline.Entities;

namespace DomestikAirline.BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL dal = new UsuarioDAL();

        public bool Ingresar(string usuario, string password)
        {
            return dal.Login(usuario, password);
        }

        public bool Registrar(string usuario, string password)
        {
            return dal.Registrar(usuario, password);
        }

        public bool ExisteUsuario(string usuario)
        {
            return dal.ExisteUsuario(usuario);
        }
    }
}