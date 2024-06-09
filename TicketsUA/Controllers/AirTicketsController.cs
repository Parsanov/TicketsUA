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

        public AirTicketsController(ITickets tickets)
        {
            _tickets = tickets;
        }

        public async Task<IActionResult> Index() 
        { 
            return View();
        }


        public async Task<IActionResult> TicketsView(int id)
        {

            var tickets = await _tickets.GetTiketsById(id);

            return View(tickets);

        }


        public async Task<IActionResult> FindTickets([FromForm] TicketsVM ticketsVM)
        {

            if (ticketsVM.Ticket.ArrivalDate is null)
            {
                ticketsVM.ArrivalDateExist = false;
                var tickets = await _tickets.FindTicketsLeave(ticketsVM);

                var leaveTickets = new TicketsVM
                {
                    TicketsLeave = tickets,
                    ArrivalDateExist = ticketsVM.ArrivalDateExist
                };

                return View(leaveTickets);

            }


            var ticketsLeave = await _tickets.FindTicketsLeave(ticketsVM);
            var ticketsComeBack = await _tickets.FindTicketsComeBack(ticketsVM);


            var ticVM = new TicketsVM
            {
                TicketsLeave = ticketsLeave,
                TicketsComeBack = ticketsComeBack,
                ArrivalDateExist = ticketsVM.ArrivalDateExist
            };

            return View(ticVM);
        }



    }
}
