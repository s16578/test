using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace test.Models
{
    public class Zamowienie_WyrobCukierniczy
    {
        public int IdWyrobuCukierniczego { get; set; }
        public int IdZamowienia { get; set; }
        public int Ilosc { get; set; }
        public string Uwagi { get; set; }
        [ForeignKey("IdWyrobuCukierniczego")]
        public virtual WyrobCukierniczy WyrobCukierniczy { get; set; }
        [ForeignKey("IdZamowienia")]
        public virtual Zamowienie Zamowienie { get; set; }
    }
}
