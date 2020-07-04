using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.Configuration
{
    public class Zamowienie_WyrobCukerniczyEfConfiguration : IEntityTypeConfiguration<Zamowienie_WyrobCukierniczy>
    {
        public void Configure(EntityTypeBuilder<Zamowienie_WyrobCukierniczy> builder)
        {
            builder
                .HasKey(k => new { k.IdWyrobuCukierniczego, k.IdZamowienia });

            builder
                .Property(e => e.Ilosc)
                .IsRequired();

            builder
                .Property(e => e.Uwagi)
                .HasMaxLength(300);

        }
    }
}
