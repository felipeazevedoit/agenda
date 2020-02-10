using System;

namespace Agenda.Dominio.Organizacao
{
    public class OrganizacaoUsuario: Base.Base
    {
        public int UsuarioID  { get; private set; }
        public int OrganizacaoID { get; private set; }

        public OrganizacaoUsuario(int usuarioId, int organizacaoId)
        {
            UsuarioID = usuarioId;
            OrganizacaoID = organizacaoId;
            Ativo = true;
            DataCadastro = DateTime.UtcNow;
        }
    }
}
