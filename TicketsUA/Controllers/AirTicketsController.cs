using Microsoft.AspNetCore.Mvc;
using TicketsUA.Interfaces;
using TicketsUA.Models;

namespace TicketsUA.Controllers
{
    public class AirTicketsController : Controller
    {
        private readonly ITickets _tickets;

        public AirTicketsController(ITickets tickets)
        {
            _tickets = tickets;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }


        public async Task<IActionResult> FindTickets(Tickets tickets)
        {
            var AllTickets = await _tickets.GetAll();
            var find = AllTickets.Where(ti => ti.StartAirport == tickets.StartAirport && ti.EndAirport == tickets.EndAirport);
            return View(find); 
        }

    }
}
