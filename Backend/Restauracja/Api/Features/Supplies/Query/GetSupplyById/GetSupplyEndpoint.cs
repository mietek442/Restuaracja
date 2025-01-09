using Api.Domain.Models;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.Supplies.Query.GetSupplyById
{
    public class GetSupplyEndpoint : EndpointBaseAsync.WithRequest<Guid>.WithActionResult<Supply>
    {
        private readonly IMediator _mediator;

        public GetSupplyEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("api/supplies/{id}")]
        [SwaggerOperation(
        Summary = "Get supply by id",
        Description = "Get supply by id",
        OperationId = "Supplies_GetId",
        Tags = new[] { "Supplies" })]


        public override Task<ActionResult<Supply>> HandleAsync([FromRoute] Guid id, CancellationToken cancellationToken = default)
        {
            return _mediator.Send(new GetSupplyQuery { Id = id });
        }
    }
}
