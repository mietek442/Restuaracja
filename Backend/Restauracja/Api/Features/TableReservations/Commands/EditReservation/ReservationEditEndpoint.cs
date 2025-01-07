using Api.Domain.Models;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.TableReservations.Commands.EditReservation
{
    public class ReservationEditEndpoint : EndpointBaseAsync.WithRequest<ReservationEditRequest>.WithActionResult<TableReservation>
    {
        private readonly IMediator _mediator;

        public ReservationEditEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPut("api/reservations/{id}")]
        [SwaggerOperation(
           Summary = "Edit a Reservation",
           Description = "Edit a Reservation",
           OperationId = "Reservations_Edit",
           Tags = new[] { "Reservations" })
        ]


        public override async Task<ActionResult<TableReservation>> HandleAsync(ReservationEditRequest request, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new EditReservationCommand {Id = request.Id, reservation = request.ReservationRequest });
        }
    }
}
