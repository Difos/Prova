using Microsoft.EntityFrameworkCore;
using ProjetoBRQ.Domain.Entities;

namespace ProjetoBRQ.Repository.Infra
{
    public class PessoaContext :DbContext
    {
        public PessoaContext()
        {
            
        }
        public PessoaContext(DbContextOptions<PessoaContext> options)
            :base(options)
        {
            
        }

        public DbSet<Pessoa> Pessoas { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DbBRQ;Data Source=DESKTOP-KI4M66M\SQLEXPRESS");
        }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
         { 
            modelBuilder.Entity<Pessoa>(entity => 
            {
                entity.HasKey(p => new { p.Id });
            });
        }
    }
}