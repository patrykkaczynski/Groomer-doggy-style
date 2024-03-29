﻿using GroomerDoggyStyle.Domain.Interfaces;
using GroomerDoggyStyle.Infrastructure.Persistence;
using GroomerDoggyStyle.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace GroomerDoggyStyle.Infrastructure.Configurations;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<GroomerDoggyStyleDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("GroomerDoggyStyle")));

        services.AddScoped<IOwnerRepository, OwnerRepository>();
        services.AddScoped<IDogRepository, DogRepository>();
        services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));


        return services;
    }
}
