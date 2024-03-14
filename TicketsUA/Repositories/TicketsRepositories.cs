using Microsoft.EntityFrameworkCore;
using TicketsUA.Data;
using TicketsUA.Interfaces;
using TicketsUA.Models;
using TicketsUA.ViewModel;

namespace TicketsUA.Repositories
{
    public class TicketsRepositories : ITickets
    {
        private readonly AppDBContext _appData;

        public TicketsRepositories(AppDBContext appData)
        {
            _appData = appData;
        }



        public async Task<List<Tickets>> FindTicketsComeBack(TicketsVM ticketsVM)
        {

            var tickets = await GetAll();

            var find = tickets.Where(tic => tic.EndAirport == ticketsVM.Ticket.StartAirport &&
                                            tic.StartAirport == ticketsVM.Ticket.EndAirport &&
                                            tic.ArrivalDate.Value.Date == ticketsVM.Ticket.ArrivalDate.Value.Date &&
                                            tic.ClassSeat == ticketsVM.Ticket.ClassSeat).ToList();

            return find;
        }

        public async Task<List<Tickets>> FindTicketsLeave(TicketsVM ticketsVM)
        {
            var tickets = await GetAll();

            var find = tickets.Where(tic => tic.StartAirport == ticketsVM.Ticket.StartAirport && 
                                    tic.EndAirport == ticketsVM.Ticket.EndAirport &&
                                    tic.DepartureDate.Date == ticketsVM.Ticket.DepartureDate.Date &&
                                    tic.ClassSeat == ticketsVM.Ticket.ClassSeat).ToList();

            return find;
        }



        public async Task<IEnumerable<Tickets>> GetAll()
        {
            return await _appData.tickets.ToListAsync();
        }

        public async Task<Tickets> GetTiketsById(int id)
        {
            return await _appData.tickets.FirstOrDefaultAsync(i => i.Id == id);
        }


        public bool Add(Tickets tickets)
        {
            _appData.Add(tickets);
            return Save();
        }

        public bool Delete(Tickets tickets)
        {
            _appData.Remove(tickets);
            return Save();
        }

        public bool Save()
        {
            var save = _appData.SaveChanges();
            return save > 0 ? true : false;
        }

        public bool Update(Tickets tickets)
        {
            _appData.Update(tickets);
            return Save();
        }

    }
}
