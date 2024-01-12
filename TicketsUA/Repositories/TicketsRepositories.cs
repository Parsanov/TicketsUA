using Microsoft.EntityFrameworkCore;
using TicketsUA.Data;
using TicketsUA.Interfaces;
using TicketsUA.Models;

namespace TicketsUA.Repositories
{
    public class TicketsRepositories : ITickets
    {
        private readonly AppDBContext _appData;

        public TicketsRepositories(AppDBContext appData)
        {
            _appData = appData;
        }


        async Task<IEnumerable<Tickets>> ITickets.GetAll()
        {
            return await _appData.tickets.ToListAsync();
        }


        public async Task<List<Tickets>> GetTickets(Tickets tickets)
        {
            var filteredTickets = await _appData.tickets
                .Where(item => item.StartAirport == tickets.StartAirport && item.EndAirport == tickets.EndAirport)
                .ToListAsync();

            return filteredTickets;
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

        public async Task<List<Tickets>> GetAll()
        {
            return await _appData.tickets.ToListAsync();
        }

        public async Task<Tickets> GetTiketsById(int id)
        {
            return await _appData.tickets.FirstOrDefaultAsync(i => i.Id == id);
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
