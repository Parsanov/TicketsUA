using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using TicketsUA.Data;
using TicketsUA.Models;

public static class Seed
{
    public static async Task SeedData(IApplicationBuilder applicationBuilder)
    {
        using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetRequiredService<AppDBContext>();

            if (!context.tickets.Any())
            {
                var tickets = new List<Tickets>
{
    new Tickets
    {
        StartAirport = "Київ",
        EndAirport = "Лондон",
        DepartureDate = new DateTime(2024, 01, 10, 10, 30, 00),
        ArrivalDate = new DateTime(2024, 01, 10, 12, 00, 00),
        ClassSeat = "Економ"
    },
    new Tickets
    {
        StartAirport = "Київ",
        EndAirport = "Лондон",
        DepartureDate = new DateTime(2024, 01, 11, 14, 00, 00),
        ArrivalDate = new DateTime(2024, 01, 11, 16, 30, 00),
        ClassSeat = "Бізнес"
    },
    new Tickets
    {
        StartAirport = "Київ",
        EndAirport = "Лондон",
        DepartureDate = new DateTime(2024, 01, 12, 10, 00, 00),
        ArrivalDate = new DateTime(2024, 01, 12, 18, 00, 00),
        ClassSeat = "Перший клас"
    },
    new Tickets
    {
        StartAirport = "Київ",
        EndAirport = "Лондон",
        DepartureDate = new DateTime(2024, 01, 13, 08, 00, 00),
        ArrivalDate = new DateTime(2024, 01, 13, 11, 00, 00),
        ClassSeat = "Економ"
    },
    new Tickets
    {
        StartAirport = "Сан-Франциско",
        EndAirport = "Токіо",
        DepartureDate = new DateTime(2024, 01, 14, 12, 00, 00),
        ArrivalDate = new DateTime(2024, 01, 15, 16, 00, 00),
        ClassSeat = "Бізнес"
    },
    new Tickets
    {
        StartAirport = "Токіо",
        EndAirport = "Сідней",
        DepartureDate = new DateTime(2024, 01, 16, 09, 00, 00),
        ArrivalDate = new DateTime(2024, 01, 16, 20, 00, 00),
        ClassSeat = "Перший клас"
    },
    new Tickets
    {
        StartAirport = "Сідней",
        EndAirport = "Аукленд",
        DepartureDate = new DateTime(2024, 01, 17, 14, 00, 00),
        ArrivalDate = new DateTime(2024, 01, 17, 18, 00, 00),
        ClassSeat = "Економ"
    },
    new Tickets
    {
        StartAirport = "Аукленд",
        EndAirport = "Ванкувер",
        DepartureDate = new DateTime(2024, 01, 18, 08, 00, 00),
        ArrivalDate = new DateTime(2024, 01, 18, 14, 00, 00),
        ClassSeat = "Бізнес"
    },
    new Tickets
    {
        StartAirport = "Ванкувер",
        EndAirport = "Мехіко",
        DepartureDate = new DateTime(2024, 01, 19, 12, 00, 00),
        ArrivalDate = new DateTime(2024, 01, 19, 16, 00, 00),
        ClassSeat = "Перший клас"
    },
    new Tickets
    {
        StartAirport = "Мехіко",
        EndAirport = "Лос-Анджелес",
        DepartureDate = new DateTime(2024, 01, 20, 09, 00, 00),
        ArrivalDate = new DateTime(2024, 01, 20, 11, 00, 00),
        ClassSeat = "Економ"
    },
    // Add more sample data as needed...
};


                context.tickets.AddRange(tickets);
                context.SaveChanges();
            }
        }
    }
}
