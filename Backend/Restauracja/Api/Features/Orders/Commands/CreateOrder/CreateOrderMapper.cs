using Api.Domain.Models;

namespace Api.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderMapper
    {
        public static CreateOrderResult ToCreateOrderResult(Order order, List<OrderItem> orderItems)
        {
            return new CreateOrderResult
            {
                Id = order.Id,
                UserId = order.UserId,
                OrderItems = orderItems,
                Status = order.Status.ToString(),
                Price = orderItems.Sum(i => i.TotalPrice),
            };
        }
    }
}
