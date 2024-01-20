// using FastFoodProducao.Application.AutoMapper;
// using FastFoodProducao.Application.Interfaces;
// using FastFoodProducao.Application.Services;
// using FastFoodProducao.Domain.Commands.ProdutoCommands;
// using FastFoodProducao.Domain.Interfaces;
// using FastFoodProducao.Infra.Data.Repository;
// using MediatR;
using Microsoft.Extensions.DependencyInjection;
using GenericPack.Mediator;
using FastFoodProducao.Infra.CrossCutting.Bus;
using System.Reflection;
// using FastFoodProducao.Domain.Commands.CategoriaProdutoCommands;
// using FastFoodProducao.Domain.Commands.ClienteCommands;
// using FastFoodProducao.Infra.Data.Context;
// using FastFoodProducao.Domain.Commands.PedidoCommands;
// using FastFoodProducao.Domain.Commands.AndamentoCommands;
// using FastFoodProducao.Domain.Commands.PagamentoCommands;
// using FastFoodProducao.Domain.Events.AndamentoEvents;
// using FastFoodProducao.Domain.Events.PagamentoEvents;
// using FastFoodProducao.Domain.Interfaces.Services;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using GenericPack.Messaging;
using System.Data;

namespace FastFoodProducao.Infra.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
        //     // Setting DBContexts
        //     services.AddDbContext<AppDbContext>(options =>
        //         options.UseNpgsql(configuration.GetConnectionString("Connectionstring")));

        //     services.AddScoped<AppDbContext>();
        //     AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        //     services.AddScoped<IDbConnection, Npgsql.NpgsqlConnection>();

        //     // Adding MediatR for Domain Events and Notifications
        //     services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        //     // Domain Bus (Mediator)
        //     services.AddScoped<IMediatorHandler, InMemoryBus>();

        //     // Application            
        //     services.AddScoped<IAndamentoApp, AndamentoApp>();
        //     services.AddScoped<ICategoriaProdutoApp, CategoriaProdutoApp>();
        //     services.AddScoped<IProdutoApp, ProdutoApp>();
        //     services.AddScoped<IClienteApp, ClienteApp>();
        //     services.AddScoped<IPedidoApp, PedidoApp>();
        //     services.AddScoped<IPagamentoApp, PagamentoApp>();
        //     services.AddScoped<IFuncionarioApp, FuncionarioApp>();
        //     services.AddScoped<ISituacaoPedidoApp, SituacaoPedidoApp>();
        //     services.AddScoped<IFuncionarioApp, FuncionarioApp>();
        //     services.AddScoped<ISituacaoPagamentoApp, SituacaoPagamentoApp>();

        //     // Infra - Data           
        //     services.AddScoped<IAndamentoRepository, AndamentoRepository>();
        //     services.AddScoped<ICategoriaProdutoRepository, CategoriaProdutoRepository>();
        //     services.AddScoped<IProdutoRepository, ProdutoRepository>();
        //     services.AddScoped<IClienteRepository, ClienteRepository>();
        //     services.AddScoped<IPedidoRepository, PedidoRepository>();
        //     services.AddScoped<IPagamentoRepository, PagamentoRepository>();
        //     services.AddScoped<IOcupacaoRepository, OcupacaoRepository>();
        //     services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
        //     services.AddScoped<ISituacaoPedidoRepository, SituacaoPedidoRepository>();
        //     services.AddScoped<ISituacaoPagamentoRepository, SituacaoPagamentoRepository>();

        //     // AutoMapper Settings
        //     services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(InputModelToDomainMappingProfile));

        //     // Domain - Commands
        //     services.AddScoped<IRequestHandler<CategoriaProdutoCreateCommand, CommandResult>, CategoriaProdutoCommandHandler>();
        //     services.AddScoped<IRequestHandler<CategoriaProdutoUpdateCommand, CommandResult>, CategoriaProdutoCommandHandler>();
        //     services.AddScoped<IRequestHandler<CategoriaProdutoDeleteCommand, CommandResult>, CategoriaProdutoCommandHandler>();

        //     services.AddScoped<IRequestHandler<ProdutoCreateCommand, CommandResult>, ProdutoCommandHandler>();
        //     services.AddScoped<IRequestHandler<ProdutoUpdateCommand, CommandResult>, ProdutoCommandHandler>();
        //     services.AddScoped<IRequestHandler<ProdutoDeleteCommand, CommandResult>, ProdutoCommandHandler>();

        //     services.AddScoped<IRequestHandler<ClienteCreateCommand, CommandResult>, ClienteCommandHandler>();

        //     services.AddScoped<IRequestHandler<PedidoCreateCommand, CommandResult>, PedidoCommandHandler>();
        //     services.AddScoped<IRequestHandler<PedidoUpdateCommand, CommandResult>, PedidoCommandHandler>();
        //     services.AddScoped<IRequestHandler<PedidoDeleteCommand, CommandResult>, PedidoCommandHandler>();

        //     services.AddScoped<IRequestHandler<AndamentoCreateCommand, CommandResult>, AndamentoCommandHandler>();
        //     services.AddScoped<IRequestHandler<AndamentoUpdateCommand, CommandResult>, AndamentoCommandHandler>();

        //     services.AddScoped<IRequestHandler<PagamentoUpdateCommand, CommandResult>, PagamentoCommandHandler>();

        //     // Domain - Events
        //     services.AddScoped<INotificationHandler<AndamentoCreateEvent>, AndamentoEventHandler>();
        //     services.AddScoped<INotificationHandler<PagamentoCreateEvent>, PagamentoEventHandler>();

        //     //Infra - Services
        //     services.AddScoped<IGatewayPagamento, MercadoPagoService>();
            
        //     //Gateway de Pagamento
        //     services.AddHttpClient<IGatewayPagamento, MercadoPagoService>(
        //     client =>
        //     {
        //         // Set the base address of the named client.
        //         client.BaseAddress = new Uri("https://api.mercadopago.com/");
        //     });
         }
    }
}
