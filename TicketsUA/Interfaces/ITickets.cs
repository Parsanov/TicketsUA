using TicketsUA.Models;
using TicketsUA.ViewModel;

namespace TicketsUA.Interfaces
{
    public interface ITickets
    {
        Task<IEnumerable<Tickets>> GetAll();
        Task<Tickets> GetTiketsById(int id);
        Task<List<Tickets>> FindTicketsLeave(TicketsVM ticketsVM);
        Task<List<Tickets>> FindTicketsComeBack(TicketsVM ticketsVM);
        bool Add(Tickets tickets);
        bool Update(Tickets tickets);
        bool Delete(Tickets tickets);
        bool Save();
    }
}
