using AutoMapper;
using TicketsUA.Models;
using TicketsUA.ViewModel;

namespace TicketsUA
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Tickets, TicketsVM>();
        }
    }
}
