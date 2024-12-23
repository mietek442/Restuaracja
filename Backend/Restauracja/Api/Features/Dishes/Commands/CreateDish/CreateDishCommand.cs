using Api.Domain.Models;
using Api.Features.Common.Services.Storage;
using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Features.Dishes.Commands.CreateDish
{
    public class CreateDishCommand : IRequest<ActionResult<Dish>>
    {
        public CreateDishRequest DishRequest { get; set; }
    }

    public class CreateDishCommandHandler : IRequestHandler<CreateDishCommand, ActionResult<Dish>>
    {
        private readonly IBlobService _blobService;
        private readonly IApplicationContext _context;

        public CreateDishCommandHandler(IBlobService blobService, IApplicationContext context)
        {
            _blobService = blobService;
            _context = context;
        }

        public async Task<ActionResult<Dish>> Handle(CreateDishCommand request, CancellationToken cancellationToken)
        {
            var dish = new Dish
            {
                Name = request.DishRequest.Name,
                ShortDescription = request.DishRequest.ShortDescription,
                FullDescription = request.DishRequest.FullDescription,
                Cuisine = request.DishRequest.Cuisine,
                IsAvailable = request.DishRequest.IsAvailable,
                Price = request.DishRequest.Price,
                DiscountPrice = request.DishRequest.DiscountPrice,
                ImageId = request.DishRequest.ImageId
            };



            _context.Dishes.Add(dish);
            var res = await _context.SaveChangesAsync(cancellationToken);
            return new OkObjectResult(dish);
        }
    }
}
