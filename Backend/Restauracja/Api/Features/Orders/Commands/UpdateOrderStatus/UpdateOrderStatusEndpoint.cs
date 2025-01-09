namespace Api.Features.Orders.Commands.UpdateOrderStatus
{
    using Api.Domain.Models;
    using Ardalis.ApiEndpoints;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using Swashbuckle.AspNetCore.Annotations;

    public class UpdateOrderStatusEndpoint : EndpointBaseAsync
        .WithRequest<UpdateOrderStatusRequest>
        .WithActionResult
    {
        private readonly IMediator _mediator;

        public UpdateOrderStatusEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut("api/orders/status")]
        [SwaggerOperation(
            Summary = "Updates the status of an Order",
            Description = "Updates the status of an Order",
            OperationId = "Orders_UpdateStatus",
            Tags = new[] { "Orders" })
        ]
        public override async Task<ActionResult> HandleAsync(UpdateOrderStatusRequest request, CancellationToken cancellationToken = default)
        {
            // sam nie wiek kurde czemu nie można przekazać całego request tylko trzeba rozbić na Id i na request bo nie łapie id
            return await _mediator.Send(new UpdateOrderStatusCommand {Id = request.Id,  UpdateOrderStatusRequest = request });
        }
    }
}
