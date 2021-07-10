using System;
using GloboTicket.TicketManagement.Domain;

namespace GloboTicket.TicketManagement.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsycRepository<Event>
    {
    }
}
