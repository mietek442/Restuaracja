using Api.Domain.Models;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.Supplies.Command.CreateSupply
{
    public class CreateSupplyEndpoint : EndpointBaseAsync.WithRequest<CreateSupplyRequest>.WithActionResult<Supply>
    {
        private readonly IMediator _mediator;

        public CreateSupplyEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("api/supplies")]
        [SwaggerOperation(
       Summary = "Adds new supply",
       Description = "Adds new supply",
       OperationId = "Supplies_Create",
       Tags = new[] { "Supplies" })
    ]
        public override async Task<ActionResult<Supply>> HandleAsync(CreateSupplyRequest request, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new CreateSupplyCommand { SupplyRequest = request });
        }
    }
}
