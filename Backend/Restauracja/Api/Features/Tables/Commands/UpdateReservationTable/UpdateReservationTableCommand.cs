using Api.Domain.Models;
using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Features.Tables.Commands.UpdateReservationTable
{
    public class UpdateReservationTableCommand:IRequest<ActionResult<RestaurantTable>>
    {
        public Guid Id { get; set; }
        public UpdateReservationTableRequest UpdateReservationTableRequest { get; set; }

    }
    public class UpdateReservationTableCommandHandler : IRequestHandler<UpdateReservationTableCommand, ActionResult<RestaurantTable>>
    {
        private readonly IApplicationContext _context;

        public UpdateReservationTableCommandHandler(IApplicationContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<RestaurantTable>> Handle(UpdateReservationTableCommand request, CancellationToken cancellationToken)
        {
       
            var table = await _context.RestaurantTables.FindAsync(request.Id, cancellationToken);
            if (table == null)
            {
                return new NotFoundResult();
            }
            table.HasReservation = request.UpdateReservationTableRequest.HasReservation;

           await _context.SaveChangesAsync(cancellationToken);

           return new NoContentResult();
        }
    }
}
