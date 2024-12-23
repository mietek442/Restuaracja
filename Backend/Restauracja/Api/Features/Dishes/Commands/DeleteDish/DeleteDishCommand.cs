using Api.Domain.Models;
using Api.Features.Common.Services.Storage;
using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Features.Dishes.Commands.DeleteDish
{
    public class DeleteDishCommand : IRequest<ActionResult>
    {
        public Guid DishId { get; set; }
    }

    public class DeleteDishCommandHandler : IRequestHandler<DeleteDishCommand, ActionResult>
    {
        private readonly IApplicationContext _context;

        public DeleteDishCommandHandler(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Handle(DeleteDishCommand request, CancellationToken cancellationToken)
        {
            var dish = await _context.Dishes.FindAsync(request.DishId, cancellationToken);
            if (dish == null)
            {
                return new NotFoundResult();
            }

            _context.Dishes.Remove(dish);
            await _context.SaveChangesAsync(cancellationToken);

            return new NoContentResult();
        }
    }
}
