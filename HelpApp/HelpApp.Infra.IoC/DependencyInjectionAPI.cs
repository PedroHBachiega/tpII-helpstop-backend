using HelpApp.Domain.Interfaces;
using HelpApp.Infra.Data.Context;
using HelpApp.Infra.Data.Repositories;
using HelpApp.Application.Services;
using HelpApp.Application.Mapping;
using MediatR;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HelpApp.Application.Interface;
using HelpApp.Infra.Data.Identity;
using Microsoft.AspNetCore.Identity;
using HelpApp.Domain.Account;

namespace HelpApp.Infra.IoC
{
    public static class DependencyInjectionAPI
    {
        public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
            ), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<ICategoryServices, CategoryServices>();
            services.AddScoped<IProductServices, ProductServices>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            services.AddScoped<IAuthenticate, AuthenticateService>();

            var myhandlers = AppDomain.CurrentDomain.Load("HelpApp.Aplication");
            services.AddMediatR(cfg =>cfg.RegisterServicesFromAssemblies(myhandlers));


            return services;
        }
    }
}