using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Features.Supplies.Command.UpdateSupply
{
    public class UpdateSupplyCommand : IRequest<ActionResult<string>>
    {
        public Guid Id { get; set; }
        public UpdateSupplyModelRequest supplyModel { get; set; }
    }
    public class UpdateSupplyCommandHandler : IRequestHandler<UpdateSupplyCommand, ActionResult<string>>
    {
        private readonly IApplicationContext _context;

        public UpdateSupplyCommandHandler(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<string>> Handle(UpdateSupplyCommand request, CancellationToken cancellationToken)
        {
            var res = await _context.Supplies.Where(s => s.Id == request.Id).FirstOrDefaultAsync();
            if (res == null)
            {
                return new NotFoundResult();
            }
            res.Name = request.supplyModel.Name;
            res.Quantity= request.supplyModel.Quantity;

            int result = await _context.SaveChangesAsync(cancellationToken);
            if (result == 0) {
                return "Sometging went wrong";
            }
            return "Updated succesfully";
        }
    }
}
