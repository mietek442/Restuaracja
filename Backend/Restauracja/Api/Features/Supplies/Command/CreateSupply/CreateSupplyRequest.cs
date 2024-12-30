using System.ComponentModel.DataAnnotations;

namespace Api.Features.Supplies.Command.CreateSupply
{
    public class CreateSupplyRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}