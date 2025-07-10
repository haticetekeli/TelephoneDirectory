using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TelephoneDirectory.DataAccess.TelephoneDirectoryDbContexts;

namespace TelephoneDirectory.DataAccess
{
   public static class ServiceRegistration
    {

        public static void DataAccessRegistration(this IServiceCollection services , IConfiguration configuration)
        {
            var connectionString = configuration.GetSection("PostgreSql").Value;

            services.AddDbContext<TelephoneDirectoryDbContext>
                (x =>
                {
                    x.UseNpgsql(connectionString, opt =>
                    {
                        opt.CommandTimeout(120); 
                    });
                    x.EnableSensitiveDataLogging();
                });
           
               services.TryAddScoped<DbContext, TelephoneDirectoryDbContext>(); 

        }
    }
}
