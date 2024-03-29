﻿namespace TicketsUA.Models
{
    public class Tickets
    {
        public int Id { get; set; }
        public string StartAirport { get; set; }
        public string EndAirport { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public string ClassSeat { get; set; }
        public double Price { get; set; }
        public TimeSpan FlightTime { get; set; }
        public string AirCompanyName { get; set; }
        public string UrlCompanyLogo { get; set; }


    }
}
