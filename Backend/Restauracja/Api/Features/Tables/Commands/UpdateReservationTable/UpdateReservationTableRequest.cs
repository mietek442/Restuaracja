using Api.Shared.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Api.Features.Tables.Commands.UpdateReservationTable
{
    public class UpdateReservationTableRequest
    {
        [FromQuery(Name = "id")] public Guid Id { get; set; }
        [FromQuery] public bool IsReservate { get; set; }
    }
}
