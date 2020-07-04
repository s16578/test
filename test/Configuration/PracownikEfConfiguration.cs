using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.Configuration
{
    public class PracownikEfConfiguration : IEntityTypeConfiguration<Pracownik>
    {
        public void Configure(EntityTypeBuilder<Pracownik> builder)
        {
            builder
                .HasKey(e => e.IdPracownika);

            builder
                .Property(e => e.Imie)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(e => e.Nazwisko)
                .IsRequired()
                .HasMaxLength(60);
            
        }
    }
}
