using Api.Domain.Models;
using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Features.Supplies.Command.CreateSupply
{
    public class CreateSupplyCommand : IRequest<ActionResult<Supply>>
    {
        public CreateSupplyRequest SupplyRequest { get; set; }
    }

    public class CreateSupplyCommandHandler : IRequestHandler<CreateSupplyCommand, ActionResult<Supply>>
    {
        private readonly IApplicationContext _context;
        public CreateSupplyCommandHandler(IApplicationContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<Supply>> Handle(CreateSupplyCommand request, CancellationToken cancellationToken)
        {
            var supply = request.SupplyRequest.MapToSupply();
            _context.Supplies.Add(supply);
            await _context.SaveChangesAsync(cancellationToken);
            return new OkObjectResult(supply);
        }
    }
}
