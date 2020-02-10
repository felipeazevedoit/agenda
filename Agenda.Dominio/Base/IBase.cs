using System.Collections.Generic;

namespace Agenda.Dominio.Base
{
    public interface IBase<T> where T : class
    {
        public T Cadastrar(T obj);
        public T Alterar(T obj);
        public IEnumerable<T> Listar();
    }
}
