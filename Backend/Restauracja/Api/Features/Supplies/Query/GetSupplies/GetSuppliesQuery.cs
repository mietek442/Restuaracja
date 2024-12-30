using Api.Domain.Models;
using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Api.Features.Supplies.Query.GetSupplies
{
    public class GetSuppliesQuery : IRequest<ActionResult<List<Supply>>>
    {
        public string Name { get; set; }
    }

    public class GetSuppliesQueryHandler : IRequestHandler<GetSuppliesQuery, ActionResult<List<Supply>>>
    {
        private readonly IApplicationContext _context;

        public GetSuppliesQueryHandler(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<List<Supply>>> Handle(GetSuppliesQuery request, CancellationToken cancellationToken)
        {
            var query = _context.Supplies.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request.Name))
            {
                query = query.Where(s => s.Name.Contains(request.Name));
            }

            var supplies = await query.ToListAsync(cancellationToken);

            return new OkObjectResult(supplies);
        }
    }
}
