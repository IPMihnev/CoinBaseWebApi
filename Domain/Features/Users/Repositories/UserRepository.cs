using Domain.Database;
using Domain.Features.Users.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Features.Users.Repositories
{
    public class UserRepository : DbGenericRepository<WebApiProjectContext, UserEntity>, IUserRepository
    {
        public UserRepository(WebApiProjectContext context)
            : base(context)
        {
            this.Entities = context.Users;
        }

        public async Task<UserEntity[]> GetAllAsync()
            => await this.Entities.ToArrayAsync();
    }
}
