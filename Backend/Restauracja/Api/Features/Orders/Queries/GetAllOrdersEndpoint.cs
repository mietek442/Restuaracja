using Api.Domain.Models;
using Api.Features.Orders.Queries.GetOrders;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.Orders.Queries
{
    public class GetAllOrdersEndpoint : EndpointBaseAsync
        .WithoutRequest
        .WithActionResult<List<OrderResult>>
    {
        private readonly IMediator _mediator;

        public GetAllOrdersEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("api/orders")]
        [SwaggerOperation(
            Summary = "Gets all Orders",
            Description = "Retrieves a list of all orders",
            OperationId = "Orders_GetAll",
            Tags = new[] { "Orders" })
        ]
        public override async Task<ActionResult<List<OrderResult>>> HandleAsync(CancellationToken cancellationToken = default)
        {
            return  await _mediator.Send(new GetOrdersQuery(), cancellationToken);
       
          
        }
    }
}
