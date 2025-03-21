﻿using Api.Domain.Models;

namespace Api.Features.TableReservations.Commands.CreateReservation
{
    public class ReservationResponse
    {
        public Guid Id { get; set; }
        public string ClientName { get; set; }
        public Guid TableId { get; set; }
        public RestaurantTable Table { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}