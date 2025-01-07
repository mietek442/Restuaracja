using Api.Domain.Models;
using Api.Features.TableReservations.Commands.CreateReservation;
using Api.Features.TableReservations.Helpers;
using Api.Infrastructure.DbContext;
using Azure.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Features.TableReservations.Commands.EditReservation
{
    public class EditReservationCommand : IRequest<ActionResult<TableReservation>>
    {
        public Guid Id { get; set; }
        public ReservationRequest reservation { get; set; }
    }
    public class EditReservationCommandHandler : IRequestHandler<EditReservationCommand, ActionResult<TableReservation>>
    {
        private readonly IApplicationContext _context;

        public EditReservationCommandHandler(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<TableReservation>> Handle(EditReservationCommand request, CancellationToken cancellationToken)
        {
            var reservation = await _context.TableReservations.Where(s => s.Id == request.Id).Include(s=>s.Table).FirstOrDefaultAsync();

            if (reservation == null)
            {
                return new NotFoundObjectResult("Nie znaleziono podanej rezerwacji!");
            }

            reservation.ClientName = request.reservation.ClientName;
            reservation.TableId = request.reservation.TableId;
            reservation.StartTime= request.reservation.StartTime;
            reservation.EndTime= request.reservation.EndTime;

            await _context.SaveChangesAsync(cancellationToken);


            return new OkObjectResult(reservation);
        }


    }
}
