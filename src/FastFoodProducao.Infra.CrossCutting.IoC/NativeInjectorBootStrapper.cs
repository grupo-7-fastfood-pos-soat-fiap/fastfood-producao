using FastFoodProducao.Application.AutoMapper;
using FastFoodProducao.Application.Interfaces;
using FastFoodProducao.Application.Services;
using FastFoodProducao.Domain.Interfaces;
using FastFoodProducao.Infra.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using GenericPack.Mediator;
using FastFoodProducao.Infra.CrossCutting.Bus;
using System.Reflection;
using FastFoodProducao.Domain.Commands.AndamentoCommands;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using GenericPack.Messaging;
using System.Data;
using MongoDB.Driver;
using GenericPack.Data;
using Microsoft.Extensions.Options;

namespace FastFoodProducao.Infra.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services,  IConfiguration configuration)
        {
            services.Configure<StoreDatabaseConfig>(
                 configuration.GetSection("DatabaseConfig"));

            // Adding MediatR for Domain Events and Notifications
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

             // Domain Bus (Mediator)
             services.AddScoped<IMediatorHandler, InMemoryBus>();

             // Application            
             services.AddScoped<IAndamentoApp, AndamentoApp>();
        
             // Infra - Data           
             services.AddScoped<IAndamentoRepository, AndamentoMensageria>();
        
             // AutoMapper Settings
             services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(InputModelToDomainMappingProfile));

             // Domain - Commands
             services.AddScoped<IRequestHandler<AndamentoCreateCommand, CommandResult>, AndamentoCommandHandler>();
             services.AddScoped<IRequestHandler<AndamentoUpdateCommand, CommandResult>, AndamentoCommandHandler>();

         }
    }
}
