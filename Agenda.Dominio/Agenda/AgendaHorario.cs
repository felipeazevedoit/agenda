using System;

namespace Agenda.Dominio.Agenda
{
    public class AgendaHorario: Base.Base
    {
        public DateTime Inicio { get; private set; }
        public DateTime Fim { get; private set; }
        public int AgendaID { get; private set; }
        public Agenda Agenda { get; private set; }
        public int UsarioId { get; private set; }
        public Usuario.Usuario Usuario { get; private set; }

        public AgendaHorario(DateTime inicio, DateTime fim, int agendaId)
        {
            Inicio = inicio;
            Fim = fim;
            AgendaID = agendaId;
            Ativo = true;
            DataCadastro = DateTime.UtcNow;
        }

    }

}
