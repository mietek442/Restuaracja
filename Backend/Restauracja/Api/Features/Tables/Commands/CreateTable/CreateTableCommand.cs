using Api.Domain.Models;
using Api.Features.Tables.Commands.CreateTable;
using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;

public class CreateTableCommand : IRequest<ActionResult<RestaurantTable>>
{
    public CreateTableRequest TableRequest { get; set; }
}

public class CreateTableCommandHandler : IRequestHandler<CreateTableCommand, ActionResult<RestaurantTable>>
{
    private readonly IApplicationContext _context;

    public CreateTableCommandHandler(IApplicationContext context)
    {
        _context = context;
    }

    public async Task<ActionResult<RestaurantTable>> Handle(CreateTableCommand request, CancellationToken cancellationToken)
    {
        var table = new RestaurantTable
        {
           
            SeatNumber = request.TableRequest.SeatNumber,
            Description = request.TableRequest.Description,
            IsReservate = false
        };

        _context.RestaurantTable.Add(table);
        await _context.SaveChangesAsync(cancellationToken);
        return new OkObjectResult(table);
    }
}