using MediatR;
using Microsoft.AspNetCore.Mvc;
using Api.Domain.Models;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Api.Infrastructure.DbContext;
using Api.Shared.Enums;
using Microsoft.EntityFrameworkCore;
using Api.Features.Orders.Queries;

namespace Api.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommand : IRequest<ActionResult<CreateOrderResult>>
    {
        public CreateOrderRequest OrderRequest { get; set; }
    }

    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, ActionResult<CreateOrderResult>>
    {
        private readonly IApplicationContext _context;

        public CreateOrderCommandHandler(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<CreateOrderResult>> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var loggedInUser = await _context.Users
          .FirstOrDefaultAsync(u => u.isLogin == true, cancellationToken);
            if (loggedInUser is null)
            {
                return new UnauthorizedObjectResult("Użytkownik nie jest zalogowany");
            }
            var order = new Order
            {
                UserId = loggedInUser.Id,
                Status = OrderStatus.Pending,
                CreatedAt = DateTime.UtcNow
            };

            await _context.Orders.AddAsync(order, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            var orderItems = request.OrderRequest.OrderItems.Select(itemRequest => new OrderItem
            {
                OrderId = order.Id,
                DishId = itemRequest.DishId,
                Quantity = itemRequest.Quantity,
                TotalPrice = (float) Math.Round(itemRequest.DishPrice* itemRequest.Quantity,2)
            }).ToList();
            
            await _context.OrderItems.AddRangeAsync(orderItems, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            var mappedOrders = order.ToOrderResult(order.OrderItems);
            return new OkObjectResult(mappedOrders);
        }


        
    }
    
}