using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketsUA.Data;
using TicketsUA.Interfaces;
using TicketsUA.Models;
using TicketsUA.ViewModel;

namespace TicketsUA.Controllers
{
    public class AirTicketsController : Controller
    {
        private readonly ITickets _tickets;
        private readonly IMapper _mapper;

        public AirTicketsController(ITickets tickets, AppDBContext context, IMapper mapper)
        {
            _tickets = tickets;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }


        public async Task<IActionResult> FindTickets(Tickets tickets)
        {
            var allTickets = await _tickets.GetAll();
            var find = allTickets
                .Where(ti => ti.StartAirport == tickets.StartAirport && ti.EndAirport == tickets.EndAirport)
                .ToList();

            return View(find);
        }



    }
}
