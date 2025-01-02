namespace Api.Features.User.Commands.LoginUser
{
    using Api.Domain.Models;
    using Api.Features.User.Commands.LogutUser;
    using Api.Infrastructure.DbContext;
    using MediatR;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public class LoginUserCommand : IRequest<ActionResult<ResteurantUser>>
    {
        public LoginUserRequest LoginRequest { get; set; }
    }

    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, ActionResult<ResteurantUser>>
    {
        private readonly IApplicationContext _context;
        private readonly PasswordHasher<object> _passwordHasher;

        public LoginUserCommandHandler(IApplicationContext context)
        {
            _context = context;
            _passwordHasher = new PasswordHasher<object>();
        }

        public async Task<ActionResult<ResteurantUser>> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            //szuka usera i zwraca null jak by go sobie nie zwórciło 
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Name == request.LoginRequest.Name, cancellationToken);

            if (user == null)
            {
                return new UnauthorizedResult();
            }

            var verficatePassword = _passwordHasher.VerifyHashedPassword(null, user.HashedPassword, request.LoginRequest.Password);

            if (verficatePassword != PasswordVerificationResult.Success)
            {
                return new UnauthorizedResult();
            }
            // to robi tak że ustawia wszystkim status zalogawany na false
            await _context.Users.Where(u => u.Id != user.Id).ForEachAsync(u => u.isLogin = false, cancellationToken);


            user.isLogin = true;
            _context.Users.Update(user);
            await _context.SaveChangesAsync(cancellationToken);

            
            return new OkObjectResult(user);
        }
    }
}
