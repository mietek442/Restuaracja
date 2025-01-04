namespace Api.Features.User.Commands.LogutUser
{
    using Api.Domain.Models;
    using Api.Infrastructure.DbContext;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Threading;
    using System.Threading.Tasks;

    public class LogoutUserCommand : IRequest<ActionResult>
    {
     
    }

    public class LogoutUserCommandHandler : IRequestHandler<LogoutUserCommand, ActionResult>
    {
        private readonly IApplicationContext _context;

        public LogoutUserCommandHandler(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Handle(LogoutUserCommand request, CancellationToken cancellationToken)
        {
          

           
            // to robi tak że ustawia wszystkim status zalogawany na false
            await _context.Users.ForEachAsync(u => u.isLogin = false, cancellationToken);
           
            await _context.SaveChangesAsync(cancellationToken);

            return new NoContentResult();
        }
    }
}
