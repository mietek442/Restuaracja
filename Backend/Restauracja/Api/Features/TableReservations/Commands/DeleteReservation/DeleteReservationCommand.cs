using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Features.TableReservations.Commands.DeleteReservation
{
    public class DeleteReservationCommand : IRequest<ActionResult<string>>
    {
        public Guid Id { get; set; }
    }
    public class DeleteReservationCommandHanlder : IRequestHandler<DeleteReservationCommand, ActionResult<string>>
    {
        private readonly IApplicationContext _context;

        public DeleteReservationCommandHanlder(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<string>> Handle(DeleteReservationCommand request, CancellationToken cancellationToken)
        {
            var res = await _context.TableReservations.FindAsync(request.Id);

            if (res == null)
            {
                return new OkObjectResult("Nie znaleziono podanej rezerwacji!");
            }

            _context.TableReservations.Remove(res);

            await _context.SaveChangesAsync(cancellationToken);

            return new OkObjectResult("Rezerwacja prawidłowo usinięta");
        }
    }
}
