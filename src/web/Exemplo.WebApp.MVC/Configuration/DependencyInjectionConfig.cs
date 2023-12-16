using Exemplo.WebApp.MVC.Services;

namespace Exemplo.WebApp.MVC.Configuration;

public static class DependencyInjectionConfig
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddHttpClient<IAutenticacaoService, AutenticacaoService>();
    }
}