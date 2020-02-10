using Agenda.Dominio.Base;

namespace Agenda.Dominio.Usuario
{
    public interface IUsuario:IBase<Usuario>
    {
        public Usuario Login(Usuario usuario);
    }
}
