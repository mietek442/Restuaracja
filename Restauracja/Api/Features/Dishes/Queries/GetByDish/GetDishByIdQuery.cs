using Api.Domain.Models;
using Api.Features.Common.Services.UrlHelper;
using Api.Features.Dishes.Common.Models;
using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Features.Dishes.Queries.GetByIdDish
{
    public class GetDishByIdQuery : IRequest<ActionResult<DishByIdResult>>
    {
        public Guid Id { get; set; }
    }

    public class GetDishByIdQueryHandler : IRequestHandler<GetDishByIdQuery, ActionResult<DishByIdResult>>
    {
        private readonly IApplicationContext _context;
        private readonly IUrlHelpers _urlHelpers;

        public GetDishByIdQueryHandler(IApplicationContext context, IUrlHelpers urlHelpers)
        {
            _context = context;
            _urlHelpers = urlHelpers;
        }

        public async Task<ActionResult<DishByIdResult>> Handle(GetDishByIdQuery request, CancellationToken cancellationToken)
        {
            var dish = await _context.Dishes.FindAsync(request.Id);
            if (dish == null)
            {
                return new NotFoundResult();
            }
            var dishResult = dish.ToDishResult(_urlHelpers);

            return new OkObjectResult(dishResult);
        }
    }
}
