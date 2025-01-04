using MediatR;
using Microsoft.AspNetCore.Mvc;
using Api.Domain.Models;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Api.Infrastructure.DbContext;
using Api.Shared.Enums;
using Microsoft.EntityFrameworkCore;

namespace Api.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommand : IRequest<ActionResult<Order>>
    {
        public CreateOrderRequest OrderRequest { get; set; }
    }

    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, ActionResult<Order>>
    {
        private readonly IApplicationContext _context;

        public CreateOrderCommandHandler(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<Order>> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order
            {
                UserId = request.OrderRequest.UserId,
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

            return new OkObjectResult(order);
        }


        
    }
    
}