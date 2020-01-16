using Enem.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enem.WebAPI.Data.Mappings;

namespace Enem.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Concurso> Concursos { get; set; }
        public DbSet<CandidatoConcurso> CandidatoConcursos{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CandidatoMap());
            modelBuilder.ApplyConfiguration(new ConcursoMap());
            modelBuilder.ApplyConfiguration(new CandidatoConcursoMap());

        }
    }
}
