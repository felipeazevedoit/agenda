using Microsoft.EntityFrameworkCore;

namespace Agenda.Infraestrutura
{
    public class Contexto: DbContext
    {
       // public DbSet<Dominio.Agenda.Agenda> Agenda { get; set; }
        //public DbSet<Dominio.Agenda.AgendaHorario> AgendaHorarios { get; set; }
        public DbSet<Dominio.Organizacao.Organizacao> Organizacao { get; set; }
        //public DbSet<Dominio.Organizacao.OrganizacaoUsuario> OrganizacaoUsuario { get; set; }
       // public DbSet<Dominio.Usuario.Usuario> Usuario { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AGENDA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
