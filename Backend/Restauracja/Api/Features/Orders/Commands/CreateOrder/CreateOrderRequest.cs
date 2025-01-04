namespace Api.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderRequest
    {
        public Guid UserId { get; set; }
        public List<OrderItemRequest> OrderItems { get; set; } = new List<OrderItemRequest>();
    }
}
