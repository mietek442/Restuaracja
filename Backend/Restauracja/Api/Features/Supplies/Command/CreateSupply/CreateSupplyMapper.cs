using Api.Domain.Models;
using System.Runtime.CompilerServices;

namespace Api.Features.Supplies.Command.CreateSupply
{
    public static class CreateSupplyMapper
    {
        public static Supply MapToSupply(this CreateSupplyRequest supplyDto) {
            return new Supply
            {
                Name = supplyDto.Name,
                Quantity = supplyDto.Quantity
            };
        }
    }
}
