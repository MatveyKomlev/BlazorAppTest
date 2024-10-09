using BlazorAppTest.src;

namespace BlazorAppTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // ������������ ����� Startup � ��������
            builder.Services.AddSingleton<Startup>();

            var app = builder.Build();

            // �������� ��������� Startup �� ��������
            var startup = app.Services.GetRequiredService<Startup>();

            // �������� ����� ConfigureServices, ��������� IServiceCollection
            startup.ConfigureServices(builder.Services);

            app.Run();

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        }
    }
}
