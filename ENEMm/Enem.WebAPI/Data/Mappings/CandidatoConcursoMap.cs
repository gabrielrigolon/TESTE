using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enem.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Enem.WebAPI.Data.Mappings
{
    public class CandidatoConcursoMap : IEntityTypeConfiguration<CandidatoConcurso>
    {
        public void Configure(EntityTypeBuilder<CandidatoConcurso> builder)
        {

            builder.HasKey(x => new
                {
                    x.IdCandidato,
                    x.IdConcurso
                });
            builder.HasOne(x => x.Candidato)
                .WithMany(m => m.CandidatoConcursos)
                .HasForeignKey(x => x.IdCandidato);
            builder.HasOne(x => x.Concurso)
                .WithMany(e => e.CandidatoConcursos)
                .HasForeignKey(x => x.IdConcurso);
        }
    }
}