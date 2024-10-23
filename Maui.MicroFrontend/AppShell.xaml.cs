using Module.Abstractions;

namespace Maui.MicroFrontend
{
    public partial class AppShell : Shell
    {
        public AppShell(IAppInitializer appInitializer)
        {
            InitializeComponent();

            var content = appInitializer.GetStartShellItem();
            Items.Add(content);
        }
    }
}
