using Microsoft.AspNetCore.Mvc;

namespace Api.Features.Supplies.Command.UpdateSupply
{
    public class UpdateSupplyRequest
    {
        [FromRoute(Name = "id")] public Guid Id { get; set; }
        [FromBody] public UpdateSupplyModelRequest model { get; set; }
    }
}