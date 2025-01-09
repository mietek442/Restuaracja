
using Api.Features.Dishes.Common.Models;
using Api.Features.Dishes.Queries.GetByIdDish;
using Api.Features.Products.Queries.GetByIdProduct;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.Products.Queries.GetByIdProduct
{
    public class GetByIdDishEndpoint : EndpointBaseAsync
        .WithRequest<Guid>
        .WithActionResult<DishByIdResult>
    {
        private readonly IMediator _mediator;

        public GetByIdDishEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("api/dishes/{id}")]
        [SwaggerOperation(
            Summary = "Get a Dish by ID",
            Description = "Retrieve a dish by its ID from the database",
            OperationId = "Dishes_GetById",
            Tags = new[] { "Dishes" })
        ]
        public override async Task<ActionResult<DishByIdResult>> HandleAsync(Guid id, CancellationToken cancellationToken = default)
        {
         
            return await _mediator.Send(new GetDishByIdQuery { Id = id }, cancellationToken);
        }
    }
}
