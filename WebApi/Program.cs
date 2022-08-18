using Domain.Database;
using Domain.Features.CoinBaseApi;
using Domain.Features.Users.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace WebApiProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

            var connectionString = builder.Configuration.GetConnectionString("ApiConnectionString");
            builder.Services.AddDbContext<WebApiProjectContext>(x => x.UseSqlServer(connectionString));

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddHttpClient<CoinBaseApiService>(httpClient =>
            {
                httpClient.BaseAddress = new Uri("https://api.coinbase.com/v2/");
            });

            builder.Services.AddScoped<IUserRepository, UserRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}