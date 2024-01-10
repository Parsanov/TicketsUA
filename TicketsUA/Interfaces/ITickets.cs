﻿using TicketsUA.Models;

namespace TicketsUA.Interfaces
{
    public interface ITickets
    {
        Task<IEnumerable<Tickets>> GetAll();
        Task<Tickets> GetTiketsById(int id);
        bool Add(Tickets tickets);
        bool Update(Tickets tickets);
        bool Delete(Tickets tickets);
        bool Save();
    }
}