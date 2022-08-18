using Domain.Features.Users.Repositories;
using MediatR;

namespace WebApiProject.Handlers.Users.GetAll
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersRequest, GetAllUsersResponse>
    {
        private readonly IUserRepository userRepository;

        public GetAllUsersHandler(
            IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<GetAllUsersResponse> Handle(GetAllUsersRequest request, CancellationToken cancellationToken)
        {
            var users = await this.userRepository.GetAllAsync();
            return new GetAllUsersResponse(users);
        }
    }
}
