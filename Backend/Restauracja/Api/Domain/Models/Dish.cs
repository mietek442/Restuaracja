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

    }
}
