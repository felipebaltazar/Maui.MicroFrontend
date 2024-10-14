using Module.Abstractions;

namespace Module.Home;

public class HomeModule : IModuleRegister
{
    public MauiAppBuilder RegisterModule(MauiAppBuilder builder)
    {

        return builder;
    }
}
