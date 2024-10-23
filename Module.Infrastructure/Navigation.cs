using Module.Abstractions;

namespace Module.Infrastructure;

public class Navigation : INavigationService
{
    public Task GoToPage(string route)
    {
        return Shell.Current.GoToAsync(route);
    }
}
