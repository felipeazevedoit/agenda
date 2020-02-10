using System;

namespace Agenda.Dominio.Organizacao
{
    public class Organizacao: Base.Base
    {
        public string Nome { get; private set; }
        public string Identificacao { get;  private set; }

        public Organizacao(string nome, string identificacao)
        {
            Nome = nome;
            Identificacao = identificacao;
            Ativo = true;
            DataCadastro = DateTime.UtcNow;
        }
    }   

}
