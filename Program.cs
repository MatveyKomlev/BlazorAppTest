using BlazorAppTest.src;

namespace BlazorAppTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Регистрируем класс Startup в сервисах
            builder.Services.AddSingleton<Startup>();

            var app = builder.Build();

            // Получаем экземпляр Startup из сервисов
            var startup = app.Services.GetRequiredService<Startup>();

            // Вызываем метод ConfigureServices, передавая IServiceCollection
            startup.ConfigureServices(builder.Services);

            app.Run();

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        }
    }
}
