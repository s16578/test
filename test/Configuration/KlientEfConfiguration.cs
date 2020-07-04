using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.Configuration
{
    public class KlientEfConfiguration : IEntityTypeConfiguration<Klient>
    {
        public void Configure(EntityTypeBuilder<Klient> builder)
        {
            builder
                .HasKey(e => e.IdKlient);

            builder
                .Property(e => e.Imie)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(e => e.Nazwisko)
                .HasMaxLength(60)
                .IsRequired();
        }
    }
}
