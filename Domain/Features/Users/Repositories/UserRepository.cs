using Domain.Features.Users.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Domain.Features.Users.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<UserEntity> userManager;

        public UserRepository(UserManager<UserEntity> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<List<UserEntity>> GetAllAsync()
            => await this.userManager
                .Users
                .OrderByDescending(x => x.Id)
                .ToListAsync();

        public async Task<bool> InsertAsync(UserEntity user, string password)
            => (await this.userManager.CreateAsync(user, password)).Succeeded;

        public async Task<bool> UpdateAsync(UserEntity user)
            => (await this.userManager.UpdateAsync(user)).Succeeded;

        public async Task<bool> DeleteAsync(UserEntity user)
            => (await this.userManager.DeleteAsync(user)).Succeeded;

        public async Task<bool> CheckPasswordAsync(UserEntity user, string password)
            => await this.userManager.CheckPasswordAsync(user, password);
    }
}
