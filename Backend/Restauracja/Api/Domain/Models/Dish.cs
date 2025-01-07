using Api.Features.Common.Services.UrlHelper;
using Api.Features.Dishes.Queries.GetAllDishes;

namespace Api.Domain.Models
{
    public class Dish
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string ShortDescription { get; set; }
        public required string FullDescription { get; set; }
        public string Cuisine { get; set; }
        public bool IsAvailable { get; set; }
        public float Price { get; set; }
        public float? DiscountPrice { get; set; }
        public Guid? ImageId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public DishResult ToDishResult(IUrlHelpers urlHelpers)
        {
            return new DishResult
            {
                Id = this.Id,
                Name = this.Name,
                ShortDescription = this.ShortDescription,
                FullDescription = this.FullDescription,
                Cuisine = this.Cuisine,
                IsAvailable = this.IsAvailable,
                Price = this.Price,
                DiscountPrice = this.DiscountPrice,
                FinalPrice = this.Price,
                ImgUrl = urlHelpers.CreatePictureUrl(this.ImageId)

            };
        }
    }
}
