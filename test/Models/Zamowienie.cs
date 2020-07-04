using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace test.Models
{
    public class Zamowienie
    {
        internal object idklient;

        public int IdZamowienia { get; set; }
        public DateTime DataPrzyjecia { get; set; }
        public DateTime? DataRealizacji { get; set; }
        public string Uwagi { get; set; }
        [ForeignKey("IdKlient")]
        public int IdKlient { get; set; }
        public virtual Klient Klient { get; set; }
        [ForeignKey("IdPracownik")]
        public int IdPracownik { get; set; }
        public virtual Pracownik Pracownik { get; set; }

    }
}
