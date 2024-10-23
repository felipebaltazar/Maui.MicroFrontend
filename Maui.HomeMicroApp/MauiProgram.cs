using Microsoft.Extensions.Logging;
using Module.Home;
using Module.Infrastructure;

namespace Maui.HomeMicroApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            new InfrastructureModuleRegister()
            .RegisterModule(builder);

            new HomeModuleRegister()
                .RegisterModule(builder);

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
