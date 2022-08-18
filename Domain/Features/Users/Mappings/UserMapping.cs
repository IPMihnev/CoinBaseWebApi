using Domain.Features.Users.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Domain.Features.Users.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("users");
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.UserName).HasColumnName("user_name");
            builder.Property(x => x.Password).HasColumnName("password");
            builder.Property(x => x.Email).HasColumnName("email");
        }
    }
}
