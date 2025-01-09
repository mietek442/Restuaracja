using Api.Features.Dishes.Common.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Api.Features.Dishes.Commands.UpdateDish
{
    public class UpdateDishRequest
    {
        [FromRoute(Name = "id")] public Guid Id { get; set; }
        [FromBody] public required UpdateDishModelRequest UpdateDishModelRequest { get; set; }
    }
}
