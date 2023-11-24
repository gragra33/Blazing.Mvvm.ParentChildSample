using Blazing.Mvvm.ParentChildSample.ViewModels;

namespace Blazing.Mvvm.ParentChildSample;

public static class ServicesExtension
{
    public static IServiceCollection AddViewModels(this IServiceCollection services)
    {
        services.AddTransient<HomeViewModel>();
        services.AddTransient<ChildViewModel>();

        return services;
    }
}