using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Features.Supplies.Command.DeleteSupply
{
    public class DeleteSupplyCommand : IRequest<ActionResult<string>>
    {
        public Guid Id { get; set; }    
    }
    public class DeleteSupplyCommandHandler : IRequestHandler<DeleteSupplyCommand, ActionResult<string>>
    {
        private readonly IApplicationContext _context;

        public DeleteSupplyCommandHandler( IApplicationContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<string>> Handle(DeleteSupplyCommand request, CancellationToken cancellationToken)
        {
            var res = await _context.Supplies.Where(s => s.Id == request.Id).FirstOrDefaultAsync();
            if (res == null)
            {
                return new NotFoundResult();
            }
            _context.Supplies.Remove(res);
            await _context.SaveChangesAsync(cancellationToken);
            return "Deleted successfully";
        }
    }
}
