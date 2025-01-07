using Api.Domain.Models;
using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Features.TableReservations.Queries.GetReservations
{
    public class GetReservationsQuery : IRequest<ActionResult<List<TableReservation>>>
    {
        
    }
    public class GetReservationsQueryHandler : IRequestHandler<GetReservationsQuery, ActionResult<List<TableReservation>>>
    {
        private readonly IApplicationContext _context;

        public GetReservationsQueryHandler(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<List<TableReservation>>> Handle(GetReservationsQuery request, CancellationToken cancellationToken)
        {
            var reservations =await _context.TableReservations
                .Include(s => s.Table)
                .ToListAsync(cancellationToken);

            if (reservations.Count() == 0) {
                return new NotFoundObjectResult("Brak wyników!");
            }
            return new OkObjectResult(reservations);
        }
    }
}
