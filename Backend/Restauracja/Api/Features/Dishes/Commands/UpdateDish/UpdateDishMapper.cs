using Api.Domain.Models;
using Api.Features.Common.Services.UrlHelper;

using Api.Features.Dishes.Common.Models;


namespace Api.Features.Dishes.Commands.UpdateDish
{
    public static class UpdateDishMapper
    {
        public static void MapToDish(Dish dish, UpdateDishModelRequest request)
        {
            dish.Name = request.Name;
            dish.ShortDescription = request.ShortDescription;
            dish.FullDescription = request.FullDescription;
            dish.Cuisine = request.Cuisine;
            dish.IsAvailable = request.IsAvailable;
            dish.Price = request.Price;
            dish.DiscountPrice = request.DiscountPrice;
            dish.ImageId = request.ImageId;
        
        }
    }
}
