using Maui.MicroFrontend;
using Maui.MicroFrontend.ViewModels;
using Module.Abstractions;

namespace Module.Home;

public class HomeModuleRegister : IModuleRegister
{
    public MauiAppBuilder RegisterModule(MauiAppBuilder builder)
    {
        Routing.RegisterRoute("MainPage", typeof(MainPage));

        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<MainPageViewModel>();
        return builder;
    }
}
