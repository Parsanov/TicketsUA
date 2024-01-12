namespace TicketsUA.ViewModel
{
    public class TicketsVM
    {
        public string StartAirport { get; set; }
        public string EndAirport { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public string ClassSeat { get; set; }
    }
}
