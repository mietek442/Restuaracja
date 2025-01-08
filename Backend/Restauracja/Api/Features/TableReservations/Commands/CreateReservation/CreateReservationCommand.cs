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
            if (checkDates(reservation.StartTime, reservation.EndTime)) {
                return new ConflictObjectResult("Data rezerwacji nakłada się na już istniejącą!");
            }
            _context.TableReservations.Add(reservation);
            await _context.SaveChangesAsync(cancellationToken);
            return new OkObjectResult(reservation);
        }
        private bool checkDates(DateTime start, DateTime end) {
            var reservations = _context.TableReservations.AsQueryable();
            foreach (var res in reservations) {
                if (start < res.EndTime && end > res.StartTime)
                {
                    return false; 
                }
            }
            return true;
        }
    }
}
