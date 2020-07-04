using Microsoft.AspNetCore.Mvc;
using test.DTO.Request;
using test.Services;

namespace test.Controllers
{
    [Route("api/klient")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IKlientZamowienieDbService _context;

        public OrdersController(IKlientZamowienieDbService context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get(string lastName)
        {
            _context.GetZamowienia(lastName);
            return Ok();
        }


        [HttpPost]
        public IActionResult CreateZamowienie(CreateZamowienieDto request)
        {
            
            if(request.Wyroby == null || request.Wyroby.Count == 0)
            {
                return BadRequest("brak zamowien");
            }

            _context.ZalozZamowienie(request);
            return Ok();
        }
    }
}
