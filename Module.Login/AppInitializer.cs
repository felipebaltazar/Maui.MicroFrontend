using Maui.MicroFrontend.Views;
using Module.Abstractions;

namespace Module.Login;

public class AppInitializer : IAppInitializer
{
    public ShellContent GetStartShellItem()
    {
        var content = new ShellContent()
        {
            ContentTemplate = new DataTemplate(typeof(LoginPage))
        };

        return content;
    }
}
