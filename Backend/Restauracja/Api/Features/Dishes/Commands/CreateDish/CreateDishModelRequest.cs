using System.ComponentModel.DataAnnotations;

namespace Api.Features.Dishes.Commands.CreateDish
{
    public class CreateDishRequest
    {
        [Required]
        public string Name { get; set; }  

        [Required]
        public string ShortDescription { get; set; }  

        public string FullDescription { get; set; }  

        [Required]
        public bool IsAvailable { get; set; } 

        [Required]
        public float Price { get; set; }  

        public float? DiscountPrice { get; set; } 

        [Required]
        public string Cuisine { get; set; }  
        [Required]
        public Guid? ImageId { get; set; }
    }
}
