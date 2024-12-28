using Api.Domain.Models;
using Api.Features.Common.Services.UrlHelper;
using Microsoft.AspNetCore.Mvc.Routing;
using static System.Net.WebRequestMethods;

namespace Api.Features.Dishes.Queries.GetAllDishes
{
    public static class GetAllDishesMapper
    {
        public static DishResult ToDishResult(this Dish dish, IUrlHelpers _urlHelpers)
        {
            return new DishResult
            {
                Id = dish.Id,
                Name = dish.Name,
                ShortDescription = dish.ShortDescription,
                FullDescription = dish.FullDescription,
                Cuisine = dish.Cuisine,
                IsAvailable = dish.IsAvailable,
                Price = dish.Price,
                DiscountPrice = (dish.DiscountPrice > 0) ? dish.DiscountPrice : 0,
                FinalPrice = CalculateFinalPrice(dish),
                ImgUrl = "https://kwalifikacje.edu.pl/wp-content/uploads/4-3-1024x683.jpg",
            };
        }

        private static float CalculateFinalPrice(Dish dish)
        {
            if (dish.DiscountPrice == 0)
            {
                return dish.Price;
            }
            if (dish.DiscountPrice > 0)
            {
                return dish.Price - (dish.Price * (dish.DiscountPrice ?? 0));
            }

            return dish.Price;
        }

        private static string CreatePictureUrl(Guid? imgId, IUrlHelpers _urlHelpers)
        {
            if (_urlHelpers == null)
                throw new InvalidOperationException("UrlHelper is not set.");

            var url = _urlHelpers.CreatePictureUrl(imgId);
            if (url == null)
            {
                return "Unable to generate the URL.";
            }

            return string.IsNullOrEmpty(url) ? "Unable to generate the URL." : url;
        }
    }
}
