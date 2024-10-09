namespace BlazorAppTest.src
{
    using FluentAssertions.Common;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup
    {
        internal void ConfigureServices(IServiceCollection services)
        {
            string config = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=BD_Blazor;Integrated Security=true;Pooling=true;Include Error Detail=true";
            services.AddDbContextFactory<PurchaseContext>(options => options.UseSqlServer(config, option => option.CommandTimeout(60)).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTrackingWithIdentityResolution));
            services.AddDbContext<OperationalAccountingDbContext>(services.AddDbContext<OperationalAccountingDbContext>(options => options.UseNpgsql(Configuration.GetConnectionString("PostgresOA"))));
            
            throw new NotImplementedException();

        }

    }
}
