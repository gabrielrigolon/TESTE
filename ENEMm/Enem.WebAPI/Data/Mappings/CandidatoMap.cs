using Enem.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enem.WebAPI.Data
{
    public class CandidatoMap : IEntityTypeConfiguration<Candidato>
    {
        public void Configure(EntityTypeBuilder<Candidato> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Nome)
                .IsRequired();

            builder.Property(x => x.Cidade)
                .IsRequired();

            builder.Property(x => x.Nota)
                .IsRequired();

            builder.Property(x => x.Status)
            .HasDefaultValue(false);

            //builder.Property(x => x.Concursos)
            //    .HasDefaultValue(false).IsRequired(false);
        }
    }
}
