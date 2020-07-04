using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.DTO.Response
{
    public class OrderResponseDto
    {
        public int IdZamowienia { get; set; }
        public DateTime DataPrzyjecia { get; set; }
        public DateTime? DataRealizacji { get; set; }
        public string Uwagi { get; set; }
        public ICollection<WyrobCukierniczy> Wyroby { get; set; }
    }
}
