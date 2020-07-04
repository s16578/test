using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.Configuration
{
    public class WyrobCukierniczyEfConfiguration : IEntityTypeConfiguration<WyrobCukierniczy>
    {
        public void Configure(EntityTypeBuilder<WyrobCukierniczy> builder)
        {
            builder
                .HasKey(e => e.IdWyrobuCukierniczego);

            builder
                .Property(e => e.Nazwa)
                .IsRequired()
                .HasMaxLength(200);

            builder
                .Property(e => e.CenaZaSztuke)
                .IsRequired();

            builder
                .Property(e => e.Typ)
                .IsRequired()
                .HasMaxLength(40);
        }
    }
}
