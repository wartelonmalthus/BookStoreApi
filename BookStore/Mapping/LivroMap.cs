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
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
     

        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("LivrosBookStore");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasMaxLength(30).IsRequired();
            builder.Property(x => x.ISBN).HasMaxLength(30).IsRequired();

        }
    }
}
