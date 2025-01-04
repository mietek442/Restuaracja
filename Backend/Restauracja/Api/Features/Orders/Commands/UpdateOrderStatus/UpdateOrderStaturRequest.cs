using Api.Shared.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Api.Features.Orders.Commands.UpdateOrderStatus
{
    public class UpdateOrderStatusRequest
    {
        [FromQuery(Name = "id")] public Guid Id { get; set; }
        [FromQuery] public OrderStatus Status { get; set; }
    }
}
