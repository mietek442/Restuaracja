using Api.Domain.Models;
using Api.Features.Common.Services.UrlHelper;

namespace Api.Features.Dishes.Common.Models
{
    public static class GetByIdDishMapper
    {
        public static DishByIdResult ToDishResult(this Dish dish, IUrlHelpers urlHelpers)
        {
            return new DishByIdResult
            {
                Name = dish.Name,
                ShortDescription = dish.ShortDescription,
                FullDescription = dish.FullDescription,
                Cuisine = dish.Cuisine,
                IsAvailable = dish.IsAvailable,
                Price = dish.DiscountPrice > 0 ? dish.Price : null,
                DiscountPrice = dish.DiscountPrice > 0 ? dish.DiscountPrice : null,
                FinalPrice = CalculateFinalPrice(dish),
                ImgUrl = CreatePictureUrl(dish.ImageId, urlHelpers),
            };
        }

        private static float CalculateFinalPrice(Dish dish)
        {
            if (dish.DiscountPrice.HasValue && dish.DiscountPrice > 0)
            {

                return dish.Price - dish.Price * (dish.DiscountPrice.Value / 100);
            }

            return dish.Price;
        }

        private static string CreatePictureUrl(Guid? imgId, IUrlHelpers urlHelpers)
        {
            if (urlHelpers == null)
                throw new InvalidOperationException("UrlHelper is not set.");

            var url = urlHelpers.CreatePictureUrl(imgId);
            return string.IsNullOrEmpty(url) ? "Unable to generate the URL." : url;
        }
    }
}
