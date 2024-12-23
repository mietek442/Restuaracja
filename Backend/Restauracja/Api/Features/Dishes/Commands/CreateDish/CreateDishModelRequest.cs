using System.ComponentModel.DataAnnotations;

namespace Api.Features.Dishes.Commands.CreateDish
{
    public class CreateDishRequest
    {
        [Required]
        public string Name { get; set; }  // Changed 'Title' to 'Name' to align with Dish model

        [Required]
        public string ShortDescription { get; set; }  // Changed 'ShortDesc' to 'ShortDescription' to align with Dish model

        public string FullDescription { get; set; }  // Changed 'Description' to 'FullDescription' to align with Dish model

        [Required]
        public bool IsAvailable { get; set; }  // Changed 'Available' to 'IsAvailable' to align with Dish model

        [Required]
        public float Price { get; set; }  // Changed 'BasePrice' to 'Price' to align with Dish model

        public float? DiscountPrice { get; set; }  // Changed 'Discount' to 'DiscountPrice' to align with Dish model

        [Required]
        public string Cuisine { get; set; }  // Kept 'Cuisine' as it is, as it matches the model
        [Required]
        public Guid? ImageId { get; set; }
    }
}
