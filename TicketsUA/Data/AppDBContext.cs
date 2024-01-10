using Microsoft.EntityFrameworkCore;
using TicketsUA.Models;

namespace TicketsUA.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }


        public DbSet<Tickets> tickets {  get; set; }

    }
}
