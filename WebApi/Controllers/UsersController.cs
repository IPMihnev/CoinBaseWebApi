using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApiProject.Handlers.Users.Create;
using WebApiProject.Handlers.Users.GetAll;

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("/api/user")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator mediator;

        public UsersController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("all")]
        [ProducesResponseType(typeof(GetAllUsersResponse), StatusCodes.Status200OK)]
        public async Task<ActionResult<GetAllUsersResponse>> Get()
            => this.Ok(await mediator.Send(new GetAllUsersRequest()));

        [HttpPost]
        [ProducesResponseType(typeof(CreateUserResponse), StatusCodes.Status200OK)]
        public async Task<ActionResult<CreateUserResponse>> Create(CreateUserRequest request)
            => this.Ok(await mediator.Send(request));
    }
}
