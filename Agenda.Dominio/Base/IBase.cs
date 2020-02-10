using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Dominio.Base
{
    public interface IBase<T> where T : class
    {
        public T Cadastrar(T obj);
        public T Alterar(T obj);
        public IEnumerable<T> Listar();
        public IEnumerable<T> ListarAtivos();
    }
}
