using Maui.MicroFrontend.ViewModels;
using Maui.MicroFrontend.Views;
using Module.Abstractions;
using Module.Login.Views;

namespace Module.Login;

public class LoginModuleRegister : IModuleRegister
{
    public MauiAppBuilder RegisterModule(MauiAppBuilder builder)
    {
        Routing.RegisterRoute("LoginPage", typeof(LoginPage));
        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<LoginViewModel>();

        builder.Services.AddTransient<IPartialHomeView, PartialView>();

        builder.Services.AddSingleton<IAppInitializer, AppInitializer>();

        return builder;
    }
}
