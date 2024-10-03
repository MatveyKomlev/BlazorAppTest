namespace BlazorAppTest.src
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup
    {
        internal void ConfigureServices(IServiceCollection services)
        {
            string config = "Server=localhost;Port=5432;Database=ИмяБазыДанных;Username=ЛогинУчетнойЗаписи;Password=ПарольУчетнойЗаписи;Integrated Security=true;Pooling=true;Include Error Detail=true";
            services.AddDbContextFactory<PurchaseContext>(options => options.UseSqlServer(config, option => option.CommandTimeout(60)).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTrackingWithIdentityResolution));


            throw new NotImplementedException();
        }
    }
}
