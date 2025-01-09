using Api.Domain.Models;
using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Features.TableReservations.Queries.GetReservationById
{
    public class GetReservationQuery : IRequest<ActionResult<TableReservation>>
    {
        public Guid Id { get; set; }
    }

    public class GetReservationQueryHandler : IRequestHandler<GetReservationQuery, ActionResult<TableReservation>>
    {
        private readonly IApplicationContext _context;

        public GetReservationQueryHandler(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<TableReservation>> Handle(GetReservationQuery request, CancellationToken cancellationToken)
        {
            var res = await _context.TableReservations.Where(s => s.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            if (res == null) {
                return new NotFoundObjectResult("Nie znaleziono podanej rezerwacji!");
            }
            return new OkObjectResult(res);
        }
    }
}
