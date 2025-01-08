using Api.Domain.Models;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.TableReservations.Queries.GetReservationById
{
    public class AddReservationEndpoint : EndpointBaseAsync .WithRequest<Guid> .WithActionResult<TableReservation>
    {
        private readonly IMediator _mediator;

        public AddReservationEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("api/reservations/{id}")]
        [SwaggerOperation(
           Summary = "Gets a Reservation",
           Description = "Gets a Reservation",
           OperationId = "Reservations_Get",
           Tags = new[] { "Reservations" })
        ]

        public override async Task<ActionResult<TableReservation>> HandleAsync([FromRoute]Guid id, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetReservationQuery { Id = id });
        }
    }
}
