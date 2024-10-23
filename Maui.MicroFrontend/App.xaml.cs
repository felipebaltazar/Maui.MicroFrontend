using Module.Abstractions;

namespace Maui.MicroFrontend;

public partial class App : Application
{
    public App(IAppInitializer appInitializer)
    {
        InitializeComponent();

        MainPage = new AppShell(appInitializer);
    }
}
