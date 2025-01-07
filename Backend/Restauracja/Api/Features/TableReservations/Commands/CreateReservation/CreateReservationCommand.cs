using Api.Domain.Models;
using Api.Features.TableReservations.Helpers;
using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Features.TableReservations.Commands.CreateReservation
{
    public class CreateReservationCommand : IRequest<ActionResult<TableReservation>>
    {
        public ReservationRequest reservation { get; set; }
    }
    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand, ActionResult<TableReservation>>
    {
        private readonly IApplicationContext _context;

        public CreateReservationCommandHandler(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<TableReservation>> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            var reservation = request.reservation.toReservation();
            _context.TableReservations.Add(reservation);
            await _context.SaveChangesAsync(cancellationToken);
            return new OkObjectResult(reservation);
        }
    }
}
