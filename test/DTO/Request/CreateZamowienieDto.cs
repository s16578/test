using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.DTO.Request
{
    public class CreateZamowienieDto
    {
        public DateTime DataPrzyjecia { get; set; }
        public string  Uwagi { get; set; }
        public ICollection<WyrobRequestDto> Wyroby { get; set; }
    }

    public class WyrobRequestDto
    {
        public int Ilosc { get; set; }
        public string Wyrob { get; set; }
        public string Uwagi { get; set; }
    }
}
