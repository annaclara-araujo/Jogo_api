
using System.Collections.Generic;
using Jogos_Api.Domains;
using Microsoft.EntityFrameworkCore;

namespace Jogos_Api.Contexts

{
    public class Context : DbContext
    {

        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
        : base(options) { }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Jogo> Jogo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = NOTE42-S28\\SQLEXPRESS; Database=Jogos.v1; User Id = sa; Pwd = Senai@134; TrustServerCertificate=true; ");
            }
        }
    }
}
