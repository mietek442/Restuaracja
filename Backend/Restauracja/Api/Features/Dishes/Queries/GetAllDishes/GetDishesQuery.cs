using Api.Features.Common.Services.Storage;
using Api.Features.Common.Services.UrlHelper;
using Api.Features.Dishes.Queries.GetAllDishes;
using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Features.Dishes.Queries.GetDishes
{
    public class GetDishesQuery : IRequest<ActionResult<List<DishResult>>>
    {
    }

    public class GetDishesQueryHandler : IRequestHandler<GetDishesQuery, ActionResult<List<DishResult>>>
    {
        private readonly IApplicationContext _context;
        private readonly IUrlHelpers _urlHelpers;

        public GetDishesQueryHandler(IApplicationContext context, IUrlHelpers urlHelpers)
        {
            _context = context;
            _urlHelpers = urlHelpers;
        }

        public async Task<ActionResult<List<DishResult>>> Handle(GetDishesQuery request, CancellationToken cancellationToken)
        {
            var dishes = await _context.Dishes
                .ToListAsync(cancellationToken);

            if (dishes == null || dishes.Count == 0)
            {
                return new NotFoundResult();
            }

            var dishResponses = dishes.Select(dish => dish.ToDishResult(_urlHelpers)).ToList();
            return new OkObjectResult(dishResponses);
        }
    }
}
