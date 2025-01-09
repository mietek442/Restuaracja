namespace Api.Features.Orders.Commands.CreateOrder
{
    public class OrderItemRequest
    {
        public Guid DishId { get; set; }
        public int Quantity { get; set; }
        public float DishPrice { get; set; }
    }
}
