using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.Supplies.Command.DeleteSupply
{
    public class DeleteSupplyEndpoint : EndpointBaseAsync.WithRequest<Guid>.WithActionResult<string>
    {
        private readonly IMediator _mediator;

        public DeleteSupplyEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpDelete("api/supplies/{id}")]
        [SwaggerOperation(
      Summary = "Deletes supply",
      Description = "Deletes supply",
      OperationId = "Supplies_Delete",
      Tags = new[] { "Supplies" })
   ]
        public override async Task<ActionResult<string>> HandleAsync([FromRoute] Guid id, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new DeleteSupplyCommand { Id = id });
        }
    }
}
