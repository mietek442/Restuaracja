using Api.Domain.Models;
using Api.Features.Common.Services.UrlHelper;
using Api.Features.Dishes.Queries.GetAllDishes;
using Api.Shared.Enums;

namespace Api.Features.Orders.Queries
{
    public static class GetAllOrderMapper
    {
        public static OrderResult ToOrderResult(this Order order, List<OrderItem> orderItems)
        {
            return new OrderResult
            {
                Id = order.Id,
                UserId = order.UserId,
                OrderItems = orderItems.Select(ToOrderItemResult).ToList(),
                Status = order.Status.ToString(),
                Price = orderItems.Sum(i=>i.TotalPrice),
              
            };
        }
        public static OrderItem ToOrderItemResult(OrderItem orderItem)
        {
            return new OrderItem
            {
                Id = orderItem.Id,
                
                Dish = orderItem.Dish,
                DishName = orderItem.Dish.Name,
                Quantity = orderItem.Quantity,
                TotalPrice = orderItem.TotalPrice
            };
        }
    }
}

