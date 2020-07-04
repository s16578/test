using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.DTO.Request;
using test.DTO.Response;
using test.Models;

namespace test.Services
{
    public interface IKlientZamowienieDbService
    {
        public ICollection<Zamowienie> GetZamowienia(string lastName);

        public ZamowienieResponseDto ZalozZamowienie(CreateZamowienieDto request);
    }
}
