namespace Api.Features.Dishes.Common.Models
{
    public class UpdateDishModelRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string Cuisine { get; set; }
        public bool IsAvailable { get; set; }
        public float Price { get; set; }
        public float? DiscountPrice { get; set; }
        public Guid? ImageId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
