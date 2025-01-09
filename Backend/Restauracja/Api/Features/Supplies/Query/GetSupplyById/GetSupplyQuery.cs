using Api.Domain.Models;
using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.Supplies.Query.GetSupplyById
{
    public class GetSupplyQuery : IRequest<ActionResult<Supply>>
    {
        public Guid Id { get; set; }
    }
    public class GetSupplyQueryHandler : IRequestHandler<GetSupplyQuery, ActionResult<Supply>>
    {
        private readonly IApplicationContext _context;

        public GetSupplyQueryHandler(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<Supply>> Handle(GetSupplyQuery request, CancellationToken cancellationToken)
        {
            var res = await _context.Supplies.Where(s => s.Id == request.Id).FirstOrDefaultAsync();
            if (res == null)
            {
                return new NotFoundResult();
            }
            return res;
        }
    }
}
