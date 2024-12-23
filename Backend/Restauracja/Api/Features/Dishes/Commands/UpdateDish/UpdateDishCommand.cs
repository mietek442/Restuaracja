using Api.Features.Common.Services.UrlHelper;

using Api.Features.Dishes.Common.Models;

using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Features.Dishes.Commands.UpdateDish
{
    public class UpdateDishCommand : IRequest<ActionResult<DishByIdResult>>
    {
        public Guid Id { get; set; }
        public required UpdateDishModelRequest UpdateDishModelRequest { get; set; }
    }

    public class UpdateDishCommandHandler : IRequestHandler<UpdateDishCommand, ActionResult<DishByIdResult>>
    {
        private readonly IApplicationContext _context;
        private readonly IUrlHelpers _urlHelpers;
        private readonly IMediator _mediator;

        public UpdateDishCommandHandler(IApplicationContext context, IUrlHelpers urlHelpers, IMediator mediator)
        {
            _context = context;
            _urlHelpers = urlHelpers;
            _mediator = mediator;
        }

        public async Task<ActionResult<DishByIdResult>> Handle(UpdateDishCommand request, CancellationToken cancellationToken)
        {
            var dish = await _context.Dishes.FindAsync(request.Id, cancellationToken);
            if (dish == null)
            {
                return new NotFoundResult();
            }

            // Mapowanie rzeczy z request do dania
            UpdateDishMapper.MapToDish(dish, request.UpdateDishModelRequest);

            // Uaktualnienie daty modyfikacji
            dish.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync(cancellationToken);

            // Zwracanie DishByIdResult
            var dishResult = dish.ToDishResult(_urlHelpers);
            return new OkObjectResult(dishResult);
        }
    }
}
