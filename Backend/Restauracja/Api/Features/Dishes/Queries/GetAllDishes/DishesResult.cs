using Api.Domain.Models;

namespace Api.Features.Dishes.Queries.GetAllDishes
{
    public class DishResult
    {
        public required Guid Id { get; set; }
        public required string Name { get; set; }
        public string ShortDescription { get; set; }
        public string? FullDescription { get; set; }
        public string Cuisine { get; set; }
        public bool IsAvailable { get; set; }
        public float? Price { get; set; }
        public float? DiscountPrice { get; set; }
        public float FinalPrice { get; set; }
        public string ImgUrl { get; set; }
        public float? Size { get; set; }
    }

}
