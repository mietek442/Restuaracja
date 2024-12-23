using Api.Domain.Models;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.Dishes.Commands.CreateDish
{
    public class CreateDishEndpoint : EndpointBaseAsync
        .WithRequest<CreateDishRequest>
        .WithActionResult<Dish>
    {
        private readonly IMediator _mediator;

        public CreateDishEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("api/dishes")]
        [SwaggerOperation(
            Summary = "Creates a new Dish",
            Description = "Creates a new Dish",
            OperationId = "Dishes_Create",
            Tags = new[] { "Dishes" })
        ]
        public override async Task<ActionResult<Dish>> HandleAsync(CreateDishRequest request, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new CreateDishCommand { DishRequest = request });
        }
    }
}
