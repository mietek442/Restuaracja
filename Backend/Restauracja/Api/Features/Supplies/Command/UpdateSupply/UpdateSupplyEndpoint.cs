using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.Supplies.Command.UpdateSupply
{
    public class UpdateSupplyEndpoint : EndpointBaseAsync.WithRequest<UpdateSupplyRequest>.WithActionResult<string>
    {
        private readonly IMediator _mediator;

        public UpdateSupplyEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPut("api/supplies/{id}")]
        [SwaggerOperation(
      Summary = "Updates supply",
      Description = "Updates supply",
      OperationId = "Supplies_Update",
      Tags = new[] { "Supplies" })
   ]

        public override async Task<ActionResult<string>> HandleAsync(UpdateSupplyRequest request, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new UpdateSupplyCommand { Id = request.Id, supplyModel = request.model });
        }
    }
}
