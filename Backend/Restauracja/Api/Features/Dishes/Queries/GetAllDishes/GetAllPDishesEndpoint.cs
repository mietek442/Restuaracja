using Api.Features.Dishes.Queries.GetAllDishes;
using Api.Features.Dishes.Queries.GetDishes;

using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.Dishes.Queries.GetAllDishes
{
    public class GetAllDishesEndpoint : EndpointBaseAsync.WithoutRequest.WithResult<ActionResult<List<DishResult>>>
    {
        private readonly IMediator _mediator;

        public GetAllDishesEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("api/dishes")]
        [SwaggerOperation(
            Summary = "Get All Dishes",
            Description = "Retrieve all dishes from the database",
            OperationId = "Dishes_GetAll",
            Tags = new[] { "Dishes" })
        ]
        public override async Task<ActionResult<List<DishResult>>> HandleAsync(CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetDishesQuery { });
        }
    }
}
