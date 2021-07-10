using System;
using GloboTicket.TicketManagement.Domain;

namespace GloboTicket.TicketManagement.Application.Contracts.Persistence
{
    public interface IOrderRepository : IAsycRepository<Category>
    {
    }
}
