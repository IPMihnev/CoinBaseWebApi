using Domain.Features.Users.Dtos;
using Domain.Features.Users.Entities;

namespace WebApiProject.Handlers.Users.GetAll
{
    public class GetAllUsersResponse
    {
        public GetAllUsersResponse(List<UserDto> users)
        {
            this.Users = users;
        }

        public List<UserDto> Users { get; set; }
    }
}
