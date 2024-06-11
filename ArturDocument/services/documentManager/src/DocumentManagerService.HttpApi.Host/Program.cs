using DocumentManagerService.DDD;
using DocumentManagerService.Domain;
using DocumentManagerService.Dapper;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        ConfigureServices(builder.Services);

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
    private static void ConfigureServices(IServiceCollection services)
    {
        ConfigureDapper(services);
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }
    private static void ConfigureDapper(IServiceCollection services)
    {
        services.AddScoped<IDapperDbContext, DapperDbContext>();
        services.AddTransient<IContractRepository, ContractRepository>();
    }
}
