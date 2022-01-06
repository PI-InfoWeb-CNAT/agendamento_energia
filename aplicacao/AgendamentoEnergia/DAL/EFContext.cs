using AgendamentoEnergia.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AgendamentoEnergia.DAL
{
    public class EFContext : DbContext
    {
        public EFContext() : base("TestDrive") {Database.SetInitializer<EFContext>(new DropCreateDatabaseIfModelChanges<EFContext>());}

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<Serviço> Serviços { get; set; }
        public DbSet<Sistema> Sistemas { get; set; }
        public DbSet<Agendamento> Agendamentoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}

