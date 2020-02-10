using System;

namespace Agenda.Dominio.Base
{
    public abstract class Base
    {
        public int ID { get; protected set; }
        public bool Ativo { get; protected set; }
        public DateTime DataCadastro { get; protected set; }

    }
}
