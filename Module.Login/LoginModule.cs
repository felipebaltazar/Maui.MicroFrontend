using Module.Abstractions;

namespace Module.Login;

public class LoginModule : IModuleRegister
{
    public MauiAppBuilder RegisterModule(MauiAppBuilder builder)
    {
        return builder;
    }
}
