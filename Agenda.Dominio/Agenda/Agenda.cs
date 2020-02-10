using System;
using System.Collections.Generic;

namespace Agenda.Dominio.Agenda
{
    public class Agenda: Base.Base
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public int OrganizacaoID { get; private set; }
        public Organizacao.Organizacao Organizacao { get; private set; }
        public List<AgendaHorario> Horarios { get; private set; }

        public Agenda(string nome, string descricao, int organizacaoID)
        {
            Nome = nome;
            Descricao = descricao;
            OrganizacaoID = organizacaoID;
            DataCadastro = DateTime.UtcNow;
            Ativo = true;
        }
    }
}   
