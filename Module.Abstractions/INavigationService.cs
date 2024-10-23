namespace Module.Abstractions;

public interface INavigationService
{
    Task GoToPage(string route);
}
