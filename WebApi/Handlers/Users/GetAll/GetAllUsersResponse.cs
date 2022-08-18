using Domain.Features.Users.Entities;

namespace WebApiProject.Handlers.Users.GetAll
{
    public class GetAllUsersResponse
    {
        public GetAllUsersResponse(UserEntity[] users)
        {
            this.Users = users;
        }

        public UserEntity[] Users { get; set; }
    }
}
