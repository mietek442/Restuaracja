﻿namespace Api.Domain.Models
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        //public Order Order { get; set; }
        public Guid DishId { get; set; }
        public Dish Dish { get; set; }
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }
    }
}
