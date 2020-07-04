using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.Configuration
{
    public class ZamowienieEfConfiguration : IEntityTypeConfiguration<Zamowienie>
    {
        public void Configure(EntityTypeBuilder<Zamowienie> builder)
        {
            builder
                .HasKey(e => e.IdZamowienia);

            builder
                .Property(e => e.DataPrzyjecia)
                .IsRequired();

            builder
                .Property(e => e.Uwagi)
                .HasMaxLength(300);

            builder
                .Property(e => e.IdKlient)
                .IsRequired();

            builder
                .Property(e => e.IdPracownik)
                .IsRequired();

            //builder
            //    .Property(e => e.Klient)
            //    .IsRequired();

            //builder
            //    .Property(e => e.Pracownik)
            //    .IsRequired();
        }
    }
}
