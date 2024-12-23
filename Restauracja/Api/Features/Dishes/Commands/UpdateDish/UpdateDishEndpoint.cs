using Api.Domain.Models;
using Api.Features.Common.Services.UrlHelper;

using Api.Features.Dishes.Commands.UpdateDish;
using Api.Features.Dishes.Common.Models;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.Dishes.Commands.UpdateDish
{
    public class UpdateDishEndpoint : EndpointBaseAsync
        .WithRequest<UpdateDishRequest>
        .WithActionResult<DishByIdResult>
    {
        private readonly IMediator _mediator;

        public UpdateDishEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut("api/dishes/{id}")]
        [SwaggerOperation(
           Summary = "Updates an existing Dish",
           Description = "Updates an existing Dish by ID",
           OperationId = "Dishes_Update",
           Tags = new[] { "Dishes" })
        ]
        public async override Task<ActionResult<DishByIdResult>> HandleAsync(UpdateDishRequest request, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new UpdateDishCommand { Id = request.Id, UpdateDishModelRequest = request.UpdateDishModelRequest }, cancellationToken);
        }
    }
}
