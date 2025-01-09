using Api.Domain.Models;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.TableReservations.Queries.GetReservations
{
    public class GetReservationsEndpoint : EndpointBaseAsync.WithoutRequest.WithActionResult<List<TableReservation>>
    {
        private readonly IMediator _mediator;

        public GetReservationsEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("api/reservations")]
        [SwaggerOperation(
            Summary = "Gets all Reservations",
            Description = "Retrieves a list of all Reservations",
            OperationId = "Reservations_GetAll",
            Tags = new[] { "Reservations" })
        ]

        public override async Task<ActionResult<List<TableReservation>>> HandleAsync(CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetReservationsQuery());
        }
    }
}
