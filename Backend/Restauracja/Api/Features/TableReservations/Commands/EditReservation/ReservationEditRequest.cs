using Api.Features.TableReservations.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Api.Features.TableReservations.Commands.EditReservation
{
    public class ReservationEditRequest
    {
        [FromRoute(Name = "id")] public Guid Id { get; set; }
        [FromBody] public ReservationRequest ReservationRequest { get; set; }
    }
}