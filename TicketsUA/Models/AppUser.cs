using Microsoft.AspNetCore.Identity;

namespace TicketsUA.Models
{
    public class AppUser : IdentityUser
    {
        public string? ProfilePhotoUrl { get; set; }

        public ICollection<Tickets> UserTickersActual { get; set; }
        public ICollection<Tickets> UserTickersHistory { get; set; }
    }
}
