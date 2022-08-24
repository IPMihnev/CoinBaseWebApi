using Domain.Features.Users.Dtos;

namespace WebApiProject.Handlers.Users.Create
{
    public class CreateUserResponse
    {
        public CreateUserResponse(UserDto user)
        {
            User = user;
        }

        public UserDto User { get; set; }
    }
}
