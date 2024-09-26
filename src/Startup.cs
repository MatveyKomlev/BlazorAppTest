namespace BlazorAppTest.src
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup
    {
        internal void ConfigureServices(IServiceCollection services)
        {
            string config = "Server=(local);Database=YourDatabaseName;Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=true;";
            services.AddDbContextFactory<PurchaseContext>(options => options.UseSqlServer(config, option => option.CommandTimeout(60)).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTrackingWithIdentityResolution));


            throw new NotImplementedException();
        }
    }
}
