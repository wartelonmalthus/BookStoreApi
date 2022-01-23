using BookStoreDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Mapping
{
    public class AutorMap : IEntityTypeConfiguration<Autor>
    {
      

        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.ToTable("AutoresBookStore");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasMaxLength(30).IsRequired();

            builder.HasMany(x => x.Livros).WithMany(x => x.Autores);

        }
    }
}
