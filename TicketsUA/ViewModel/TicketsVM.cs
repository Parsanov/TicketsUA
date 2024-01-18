using TicketsUA.Models;

namespace TicketsUA.ViewModel
{
    public class TicketsVM
    {
        public List<Tickets> TicketsLeave { get; set; }
        public List<Tickets> TicketsComeBack { get; set; }
        public Tickets Ticket { get; set; }
        public bool ArrivalDateExist { get; set; } = true;
    }
}
