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
                var tickets = new List<Tickets>()
                {
                    // Прямі рейси
    new Tickets
    {
        StartAirport = "Мехіко",
        EndAirport = "Лос-Анджелес",
        DepartureDate = new DateTime(2024, 01, 20, 09, 00, 00),
        ArrivalDate = new DateTime(2024, 01, 20, 11, 00, 00),
        ClassSeat = "Економ",
        Price = 250.0,
        FlightTime = (new DateTime(2024, 01, 20, 11, 00, 00) - new DateTime(2024, 01, 20, 09, 00, 00))
    },
    new Tickets
    {
        StartAirport = "Лондон",
        EndAirport = "Париж",
        DepartureDate = new DateTime(2024, 02, 15, 14, 30, 00),
        ArrivalDate = new DateTime(2024, 02, 15, 16, 15, 00),
        ClassSeat = "Бізнес",
        Price = 400.0,
        FlightTime = (new DateTime(2024, 02, 15, 16, 15, 00) - new DateTime(2024, 02, 15, 14, 30, 00))
    },
    new Tickets
    {
        StartAirport = "Токіо",
        EndAirport = "Сідней",
        DepartureDate = new DateTime(2024, 03, 10, 18, 45, 00),
        ArrivalDate = new DateTime(2024, 03, 11, 07, 30, 00),
        ClassSeat = "Преміум",
        Price = 600.0,
        FlightTime = (new DateTime(2024, 03, 11, 07, 30, 00) - new DateTime(2024, 03, 10, 18, 45, 00))
    },
    new Tickets
    {
        StartAirport = "Нью-Йорк",
        EndAirport = "Маямі",
        DepartureDate = new DateTime(2024, 04, 05, 12, 15, 00),
        ArrivalDate = new DateTime(2024, 04, 05, 14, 30, 00),
        ClassSeat = "Економ",
        Price = 180.0,
        FlightTime = (new DateTime(2024, 04, 05, 14, 30, 00) - new DateTime(2024, 04, 05, 12, 15, 00))
    },
    new Tickets
    {
        StartAirport = "Сіетл",
        EndAirport = "Ванкувер",
        DepartureDate = new DateTime(2024, 05, 20, 08, 45, 00),
        ArrivalDate = new DateTime(2024, 05, 20, 10, 30, 00),
        ClassSeat = "Бізнес",
        Price = 300.0,
        FlightTime = (new DateTime(2024, 05, 20, 10, 30, 00) - new DateTime(2024, 05, 20, 08, 45, 00))
    },
    new Tickets
    {
        StartAirport = "Сідней",
        EndAirport = "Аукленд",
        DepartureDate = new DateTime(2024, 06, 15, 20, 00, 00),
        ArrivalDate = new DateTime(2024, 06, 16, 06, 30, 00),
        ClassSeat = "Економ",
        Price = 450.0,
        FlightTime = (new DateTime(2024, 06, 16, 06, 30, 00) - new DateTime(2024, 06, 15, 20, 00, 00))
    },
    new Tickets
    {
        StartAirport = "Пекін",
        EndAirport = "Шанхай",
        DepartureDate = new DateTime(2024, 07, 10, 15, 30, 00),
        ArrivalDate = new DateTime(2024, 07, 10, 17, 00, 00),
        ClassSeat = "Преміум",
        Price = 550.0,
        FlightTime = (new DateTime(2024, 07, 10, 17, 00, 00) - new DateTime(2024, 07, 10, 15, 30, 00))
    },
    new Tickets
    {
        StartAirport = "Сеул",
        EndAirport = "Токіо",
        DepartureDate = new DateTime(2024, 08, 05, 10, 15, 00),
        ArrivalDate = new DateTime(2024, 08, 05, 12, 00, 00),
        ClassSeat = "Бізнес",
        Price = 380.0,
        FlightTime = (new DateTime(2024, 08, 05, 12, 00, 00) - new DateTime(2024, 08, 05, 10, 15, 00))
    },
    new Tickets
    {
        StartAirport = "Рим",
        EndAirport = "Барселона",
        DepartureDate = new DateTime(2024, 09, 20, 17, 45, 00),
        ArrivalDate = new DateTime(2024, 09, 20, 19, 30, 00),
        ClassSeat = "Економ",
        Price = 280.0,
        FlightTime = (new DateTime(2024, 09, 20, 19, 30, 00) - new DateTime(2024, 09, 20, 17, 45, 00))
    },
    new Tickets
    {
        StartAirport = "Москва",
        EndAirport = "Санкт-Петербург",
        DepartureDate = new DateTime(2024, 10, 15, 08, 30, 00),
        ArrivalDate = new DateTime(2024, 10, 15, 09, 45, 00),
        ClassSeat = "Преміум",
        Price = 200.0,
        FlightTime = (new DateTime(2024, 10, 15, 09, 45, 00) - new DateTime(2024, 10, 15, 08, 30, 00))
    },

    // Зворотні рейси
    new Tickets
    {
        StartAirport = "Лос-Анджелес",
        EndAirport = "Мехіко",
        DepartureDate = new DateTime(2024, 01, 25, 14, 30, 00),
        ArrivalDate = new DateTime(2024, 01, 25, 16, 30, 00),
        ClassSeat = "Економ",
        Price = 250.0,
        FlightTime = (new DateTime(2024, 01, 25, 16, 30, 00) - new DateTime(2024, 01, 25, 14, 30, 00))
    },
    new Tickets
    {
        StartAirport = "Париж",
        EndAirport = "Лондон",
        DepartureDate = new DateTime(2024, 02, 20, 09, 15, 00),
        ArrivalDate = new DateTime(2024, 02, 20, 10, 45, 00),
        ClassSeat = "Бізнес",
        Price = 400.0,
        FlightTime = (new DateTime(2024, 02, 20, 10, 45, 00) - new DateTime(2024, 02, 20, 09, 15, 00))
    },
    new Tickets
    {
        StartAirport = "Сідней",
        EndAirport = "Токіо",
        DepartureDate = new DateTime(2024, 03, 20, 22, 15, 00),
        ArrivalDate = new DateTime(2024, 03, 21, 11, 00, 00),
        ClassSeat = "Преміум",
        Price = 600.0,
        FlightTime = (new DateTime(2024, 03, 21, 11, 00, 00) - new DateTime(2024, 03, 20, 22, 15, 00))
    },
    new Tickets
    {
    StartAirport = "Маямі",
    EndAirport = "Нью-Йорк",
    DepartureDate = new DateTime(2024, 04, 10, 16, 45, 00),
    ArrivalDate = new DateTime(2024, 04, 10, 19, 00, 00),
    ClassSeat = "Економ",
    Price = 180.0,
    FlightTime = (new DateTime(2024, 04, 10, 19, 00, 00) - new DateTime(2024, 04, 10, 16, 45, 00))
    },

    new Tickets
    {
        StartAirport = "Ванкувер",
        EndAirport = "Сіетл",
        DepartureDate = new DateTime(2024, 05, 25, 11, 30, 00),
        ArrivalDate = new DateTime(2024, 05, 25, 13, 15, 00),
        ClassSeat = "Бізнес",
        Price = 300.0,
        FlightTime = (new DateTime(2024, 05, 25, 13, 15, 00) - new DateTime(2024, 05, 25, 11, 30, 00))
    },
    new Tickets
    {
        StartAirport = "Аукленд",
        EndAirport = "Сідней",
        DepartureDate = new DateTime(2024, 06, 20, 10, 45, 00),
        ArrivalDate = new DateTime(2024, 06, 20, 19, 15, 00),
        ClassSeat = "Економ",
        Price = 450.0,
        FlightTime = (new DateTime(2024, 06, 20, 19, 15, 00) - new DateTime(2024, 06, 20, 10, 45, 00))
    },
    new Tickets
    {
        StartAirport = "Шанхай",
        EndAirport = "Пекін",
        DepartureDate = new DateTime(2024, 07, 15, 18, 30, 00),
        ArrivalDate = new DateTime(2024, 07, 15, 20, 00, 00),
        ClassSeat = "Преміум",
        Price = 550.0,
        FlightTime = (new DateTime(2024, 07, 15, 20, 00, 00) - new DateTime(2024, 07, 15, 18, 30, 00))
    },
    new Tickets
    {
        StartAirport = "Токіо",
        EndAirport = "Сеул",
        DepartureDate = new DateTime(2024, 08, 10, 14, 00, 00),
        ArrivalDate = new DateTime(2024, 08, 10, 15, 45, 00),
        ClassSeat = "Бізнес",
        Price = 380.0,
        FlightTime = (new DateTime(2024, 08, 10, 15, 45, 00) - new DateTime(2024, 08, 10, 14, 00, 00))
    },
    new Tickets
{
    StartAirport = "Маямі",
    EndAirport = "Нью-Йорк",
    DepartureDate = new DateTime(2024, 04, 10, 16, 45, 00),
    ArrivalDate = new DateTime(2024, 04, 10, 19, 00, 00),
    ClassSeat = "Економ",
    Price = 180.0,
    FlightTime = (new DateTime(2024, 04, 10, 19, 00, 00) - new DateTime(2024, 04, 10, 16, 45, 00))
}
 };

                context.tickets.AddRange(tickets);
                context.SaveChanges();
            }
        } // Закриваюча фігурна дужка для методу SeedData
    }
}