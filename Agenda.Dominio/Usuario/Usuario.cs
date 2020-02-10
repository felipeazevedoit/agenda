using System;

namespace Agenda.Dominio.Usuario
{
    public class Usuario: Base.Base
    {
        public string Login { get; private set; }
        public string Senha { get; private set; }

        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
            Ativo = true;
            DataCadastro = DateTime.UtcNow;
        }

        public Usuario(string login, string senha, bool ativo)
        {
            Login = login;
            Senha = senha;
            Ativo = ativo;
            DataCadastro = DateTime.UtcNow;
        }
    }
}
