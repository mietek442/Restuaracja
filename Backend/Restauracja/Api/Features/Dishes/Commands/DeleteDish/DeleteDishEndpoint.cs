using Api.Domain.Models;

using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.Dishes.Commands.DeleteDish
{
    public class DeleteDishEndpoint : EndpointBaseAsync
        .WithRequest<Guid>
        .WithActionResult
    {
        private readonly IMediator _mediator;

        public DeleteDishEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpDelete("api/dishes/{id}")]
        [SwaggerOperation(
            Summary = "Deletes a Dish",
            Description = "Deletes a Dish by ID",
            OperationId = "Dishes_Delete",
            Tags = new[] { "Dishes" })
        ]
        public override async Task<ActionResult> HandleAsync([FromRoute] Guid id, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new DeleteDishCommand { DishId = id });
        }
    }
}
