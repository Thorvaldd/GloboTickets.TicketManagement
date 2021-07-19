using System;
using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetails;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events.GetEventDetails
{
    public class GetEventDetailQuery : IRequest<EventDetailVm>
    {
        public Guid Id { get; set; }
    }
}
