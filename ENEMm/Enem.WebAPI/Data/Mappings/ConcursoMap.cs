using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enem.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Enem.WebAPI.Data.Mappings
{
    public class ConcursoMap : IEntityTypeConfiguration<Concurso>
    {
        public void Configure(EntityTypeBuilder<Concurso> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Descricao)
                .IsRequired();

            builder.Property(x => x.Candidatos)
                .HasDefaultValue(false).IsRequired(false);

            //builder.Entity<ContactCategory>()
            //    .HasOne(x => x.Category)
            //    .WithMany(x => x.ContactCategories)
            //    .HasForeignKey(x => x.CategoryId);

            //modelBuilder.Entity<ContactCategory>()
            //    .HasOne(x => x.Contact)
            //    .WithMany(x => x.ContactCategories)
            //    .HasForeignKey(x => x.ContactId);
        }
    }
}