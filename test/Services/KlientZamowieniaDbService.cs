using Microsoft.AspNetCore.Server.IIS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using test.DTO.Request;
using test.DTO.Response;
using test.Models;

namespace test.Services
{
    public class KlientZamowieniaDbService : IKlientZamowienieDbService
    {
        private readonly CukierniaDbContext _context;
        public KlientZamowieniaDbService(CukierniaDbContext context)
        {
            _context = context;
        }

        public ICollection<Zamowienie> GetZamowienia(string lastname)
        {
            ICollection<Zamowienie> order;
            
            if (lastname == null) {
                order = _context.Zamowienia.ToList();
            }
            else
            {
                order = _context.Zamowienia.Where(k => k.Klient.Nazwisko == lastname).ToList();
            }

            //ICollection<Zamowienie_WyrobCukierniczy> wyroby_zamowienia;

            if (order.Any())
            {
                _context.Zamowienia.Join(_context.Zamowienie_WyrobCukierniczy, x => x.IdZamowienia, y => y.IdZamowienia, (x, y) => new { x, y }).Select(o => new { o.x.Uwagi, o.y.WyrobCukierniczy });
                    
                    //var res = Emps.Join(Depts, emp => emp.Deptno, dept => dept.Deptno, (emp, dept) =>
                    //    new
                    //    {
                    //        emp.Ename,
                    //        emp.Job,
                    //        dept.Deptno
                    //    });
            }

            return null;

        }

        public ZamowienieResponseDto ZalozZamowienie(CreateZamowienieDto request)
        {
            foreach(var i in request.Wyroby)
            {
                if (!_context.WyrobyCukiernicze.Any(x => x.Nazwa == i.Wyrob))
                    throw new InvalidOperationException("Wyrob juz istieje");
            }

            var wyroby = _context.WyrobyCukiernicze.Where(we => request.Wyroby.Any(r => r.Wyrob == we.Nazwa)).ToList();
            
            var newOrder = new Zamowienie
            {
                DataPrzyjecia = request.DataPrzyjecia,
                Uwagi = request.Uwagi,
            };

            var newOrderProduct = request.Wyroby.Select(w => new
            {
                Ilosc = w.Ilosc,
                Uwagi = w.Uwagi,
                Zamowienie = newOrder,
                Wyrob = _context.WyrobyCukiernicze.Where(ww => ww.Nazwa == w.Wyrob).First()
            });

            _context.Zamowienia.Add(newOrder);
          
            _context.SaveChanges();

            return null;
        }
    }
}
