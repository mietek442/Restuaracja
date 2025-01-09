using Api.Domain.Models;
using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Api.Features.Tables.Queries.GetTables
{
    public class GetTablesQuery : IRequest<ActionResult<List<RestaurantTable>>>
    {
    }

    public class GetTablesQueryHandler : IRequestHandler<GetTablesQuery, ActionResult<List<RestaurantTable>>>
    {
        private readonly IApplicationContext _context;

        public GetTablesQueryHandler( IApplicationContext context)
        {
            _context = context; 
        }

        public async Task<ActionResult<List<RestaurantTable>>> Handle(GetTablesQuery request, CancellationToken cancellationToken)
        {
            var res = await _context.RestaurantTables.Include(s=>s.TableReservations).ToListAsync();
            foreach (var table in res) {
                foreach (var reservation in table.TableReservations) {
                    if (DateTime.Now >= reservation.StartTime && DateTime.Now <= reservation.EndTime)
                    {
                        table.HasReservation = true;
                    }
                }
            }
            if (res.Count == 0 )
            {
                return new NotFoundObjectResult("Nie znaleziono stolików!");
            }
            return new OkObjectResult(res);
        }
    }
}
