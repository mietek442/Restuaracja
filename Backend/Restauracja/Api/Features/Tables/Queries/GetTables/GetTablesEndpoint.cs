using Api.Domain.Models;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.Tables.Queries.GetTables
{
    public class GetTablesEndpoint : EndpointBaseAsync.WithoutRequest.WithActionResult<List<RestaurantTable>>
    {
        private readonly IMediator _mediator;

        public GetTablesEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("api/tables")]
        [SwaggerOperation(
             Summary = "Browse Tables",
             Description = "Browse Tables",
             OperationId = "Tables_Get",
             Tags = new[] { "Tables" })]
        public override async Task<ActionResult<List<RestaurantTable>>> HandleAsync(CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetTablesQuery());
        }
    }
}
