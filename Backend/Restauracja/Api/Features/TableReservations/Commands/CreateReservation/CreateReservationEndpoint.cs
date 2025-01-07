using Api.Domain.Models;
using Api.Features.TableReservations.Helpers;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.TableReservations.Commands.CreateReservation
{
    public class CreateReservationEndpoint : EndpointBaseAsync.WithRequest<ReservationRequest>.WithActionResult<TableReservation>
    {
        private readonly IMediator _mediator;
        public CreateReservationEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("api/reservations")]
        [SwaggerOperation(
           Summary = "Creates a new Reservation",
           Description = "Creates a new Reservation",
           OperationId = "Reservations_Create",
           Tags = new[] { "Reservations" })
       ]
        public override async Task<ActionResult<TableReservation>> HandleAsync(ReservationRequest request, CancellationToken cancellationToken = default)
        {
          return await _mediator.Send(new CreateReservationCommand { reservation = request});
        }
    }
}
