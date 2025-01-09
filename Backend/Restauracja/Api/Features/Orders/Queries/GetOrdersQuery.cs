using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Features.Orders.Queries.GetOrders
{
    public class GetOrdersQuery : IRequest<ActionResult<List<OrderResult>>>
    {
    }

    public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, ActionResult<List<OrderResult>>>
    {
        private readonly IApplicationContext _context;

        public GetOrdersQueryHandler(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<List<OrderResult>>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {


            var orders = await _context.Orders
            .Include(order => order.OrderItems)
            .ThenInclude(orderItem => orderItem.Dish)
                .ToListAsync(cancellationToken);





            if (orders == null || orders.Count == 0)
            {
                return new NotFoundResult();
            }

            // jak coś to w orderResult liczy cene sumaryczną zamówienia, można by było to zmienić na takie co przy zapisywaniu ustala cene zamówienia, ale trudno :(

            var orderResponses = orders.Select(order => order.ToOrderResult(order.OrderItems)).ToList();
            return new OkObjectResult(orderResponses);
        }
    }
}
