using StageFive.Services.Calc;
using StageFive.Services.Product;
using StageFive.Services.Test;
using StageFive.Services.House;

namespace StageFive.Extensions;

public static class RegisterServices
{
    public static IServiceCollection AddCustomServices(this IServiceCollection services)
    {
        services.AddControllersWithViews();
        services.AddScoped<IHouseService, HouseService>();
        services.AddScoped<ITestService, TestService>();
        services.AddScoped<ICalcService, CalcService>();
        services.AddScoped<IProductService, ProductService>();
        return services;
        // services.AddTransient();
        // services.AddSingleton();
    }
}
