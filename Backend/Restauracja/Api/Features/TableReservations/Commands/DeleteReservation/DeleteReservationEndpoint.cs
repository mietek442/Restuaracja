using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.TableReservations.Commands.DeleteReservation
{
    public class DeleteReservationEndpoint : EndpointBaseAsync.WithRequest<Guid>.WithResult<ActionResult<string>>
    {
        private readonly IMediator _mediator;

        public DeleteReservationEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpDelete("api/reservations/{id}")]
        [SwaggerOperation(
          Summary = "Deletes a  Reservation",
          Description = "Deletes a Reservation",
          OperationId = "Reservations_Delete",
          Tags = new[] { "Reservations" })
      ]
        public override async Task<ActionResult<string>> HandleAsync([FromRoute]Guid id, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new DeleteReservationCommand { Id = id });
        }
    }
}
