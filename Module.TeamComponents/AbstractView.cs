
namespace Module.TeamComponents;

public class AbstractView<TAbstraction> : ContentView where TAbstraction : IView
{
    public Action<Exception>? OnError { get; set; }
    public Action<object>? SetupViewModel { get; set; }

    public AbstractView()
    {
        _ = Task.Run(InitializeView);
    }

    private async Task InitializeView()
    {
        try
        {
            var moduleViewType = typeof(TAbstraction);

            //We can create a loader to indicate the module is loading
            if (Application.Current?
                .Handler?
                .MauiContext?
                .Services.GetService(moduleViewType) is not View moduleView)
            {
                MainThread.BeginInvokeOnMainThread(() => OnError?.Invoke(new Exception("ModuleView not found")));
                return;
            }

            MainThread.BeginInvokeOnMainThread(() =>
            {
                SetupViewModel?.Invoke(moduleView.BindingContext);
                Content = moduleView;
            });
        }
        catch (Exception ex)
        {
            //We can create a template in case of errors
            MainThread.BeginInvokeOnMainThread(() => OnError?.Invoke(ex));
        }
    }
}
