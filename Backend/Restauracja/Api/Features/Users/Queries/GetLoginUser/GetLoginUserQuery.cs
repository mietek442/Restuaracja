using Api.Domain.Models;
using Api.Infrastructure.DbContext;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Features.Users.Queries.GetLoginUser
{
    public class GetLoginUserQuery : IRequest<ActionResult<ResteurantUser>>
    {
      
    }

    public class GetLoginUserQueryHandler : IRequestHandler<GetLoginUserQuery, ActionResult<ResteurantUser>>
    {
        private readonly IApplicationContext _context;

        public GetLoginUserQueryHandler(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<ResteurantUser>> Handle(GetLoginUserQuery request, CancellationToken cancellationToken)
        {
            var loggedInUser = await _context.Users
          .FirstOrDefaultAsync(u => u.isLogin == true, cancellationToken);

           

            if (loggedInUser == null)
            {
                return new NotFoundResult();
            }

         
            return new OkObjectResult(loggedInUser);
        }
    }
}
