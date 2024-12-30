using Api.Domain.Models;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.Supplies.Query.GetSupplies
{
    public class GetSuppliesEndpoint : EndpointBaseAsync .WithRequest<string> .WithActionResult<List<Supply>>
    {
        private readonly IMediator _mediator;

        public GetSuppliesEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("api/supplies")]
        [SwaggerOperation(
      Summary = "Browse supplies",
      Description = "Browse supplies",
      OperationId = "Supplies_GetAll",
      Tags = new[] { "Supplies" })
   ]
        public override async Task<ActionResult<List<Supply>>> HandleAsync([FromQuery] string? name, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetSuppliesQuery { Name = name });
        }
    }
}
