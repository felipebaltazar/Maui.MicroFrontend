using Module.Abstractions;

namespace Module.Infrastructure;

public class InfrastructureModuleRegister : IModuleRegister
{
    public MauiAppBuilder RegisterModule(MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<INavigationService, Navigation>();
        return builder;
    }
}
