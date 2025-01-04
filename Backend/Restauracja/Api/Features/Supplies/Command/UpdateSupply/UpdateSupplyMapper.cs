using Api.Domain.Models;

namespace Api.Features.Supplies.Command.UpdateSupply
{
    public static class UpdateSupplyMapper
    {
        public static Supply MapToSupply(this Supply model) {
            return new Supply
            {
                Name = model.Name,
                Quantity = model.Quantity,
                Unit = model.Unit

            };
        }
    }
}
