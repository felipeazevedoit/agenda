using Agenda.Infraestrutura;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Agenda.Repositorio.Base
{
    public class BaseRepositorio<T> : Dominio.Base.IBase<T> where T : class
    {
        private readonly Contexto Db = new Contexto();
        public T Alterar(T obj)
        {
           
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
            Db.Dispose();
            return obj;
        }
        public T Cadastrar(T obj)
        {
            Db.Entry(obj).State = EntityState.Added;
            Db.SaveChanges();
            Db.Dispose();
            return obj;
        }
        public IEnumerable<T> Listar()
        {
            return Db.Set<T>().ToList();
        }

    }
}
