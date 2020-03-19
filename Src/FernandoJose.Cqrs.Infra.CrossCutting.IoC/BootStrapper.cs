using FernandoJose.Cqrs.Domain.Commands;
using FernandoJose.Cqrs.Domain.Handles;
using FernandoJose.Cqrs.Domain.Interfaces.Commands;
using FernandoJose.Cqrs.Domain.Interfaces.Handles;
using FernandoJose.Cqrs.Domain.Interfaces.Repositories;
using FernandoJose.Cqrs.Infra.Data.Dapper.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Data.SqlClient;

namespace FernandoJose.Cqrs.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Repository
            services.AddScoped<IDbConnection>(x => new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=teste_webmotors;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
            services.AddTransient<IAnuncioRepository, AnuncioRepository>();

            // Command
            services.AddTransient<IRequestCommand, AnuncioAdicionarCommand>();

            // Handler
            services.AddTransient<AnuncioHandler, AnuncioHandler>();
        }
    }
}
