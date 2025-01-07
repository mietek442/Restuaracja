using Api.Domain.Models;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.Tables.Commands.UpdateReservationTable
{
    public class UpdateReservationTableEndpoint : EndpointBaseAsync
        .WithRequest<UpdateReservationTableRequest>.WithActionResult<RestaurantTable>
    {
        private readonly IMediator _mediator;
        public UpdateReservationTableEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPut("api/tables/reservate")]
        [SwaggerOperation(
            Summary = "Update a Reservation status",
            Description = "Update a Reservation status",
            OperationId = "Tables_Reservation_Update",
            Tags = new[] { "Tables" })]
        public override async Task<ActionResult<RestaurantTable>> HandleAsync(UpdateReservationTableRequest request, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new UpdateReservationTableCommand { });
        }
    }
}
