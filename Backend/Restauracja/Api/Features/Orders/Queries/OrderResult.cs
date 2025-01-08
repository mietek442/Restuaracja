using Api.Domain.Models;
using Api.Shared.Enums;

namespace Api.Features.Orders.Queries
{
    public class OrderResult
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public string Status { get; set; }
        public float Price { get; set; }
        public string DishName { get; set; }
    }
}
