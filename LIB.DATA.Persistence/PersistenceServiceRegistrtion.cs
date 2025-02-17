
using LIB.API.Persistence.Repositories;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PERSISTANCE.Services;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;



namespace LIB.API.Persistence
{
    public static partial class PersistenceServiceRegistrtion
    {
        public static IServiceCollection ConfigurePersistenceService(this IServiceCollection services, IConfiguration configuration)
        {
    
            services.AddScoped<JwtService>();

     

            services.AddHttpClient();


            services.AddHostedService<TcpServerService>();

            return services;
        }
    }
}
