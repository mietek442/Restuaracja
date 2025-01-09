using Api.Features.Common.Services.UrlHelper;
using Api.Domain.Models;
using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Api.Features.Orders.Queries;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Api.Features.Orders.Commands.UpdateOrderStatus
{
    public class UpdateOrderStatusCommand : IRequest<ActionResult>
    {
        public Guid Id { get; set; }
        public required UpdateOrderStatusRequest UpdateOrderStatusRequest { get; set; }
    }

    public class UpdateOrderStatusCommandHandler : IRequestHandler<UpdateOrderStatusCommand, ActionResult>
    {
        private readonly IApplicationContext _context;
        private readonly IMediator _mediator;

        public UpdateOrderStatusCommandHandler(IApplicationContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<ActionResult> Handle(UpdateOrderStatusCommand request, CancellationToken cancellationToken)
        {
            var order = await _context.Orders.FindAsync(request.Id, cancellationToken);
            if (order == null)
            {
                return new NotFoundResult();
            }

          
            order.Status = request.UpdateOrderStatusRequest.Status;
            order.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync(cancellationToken);

            return new NoContentResult();
        }
    }
}
