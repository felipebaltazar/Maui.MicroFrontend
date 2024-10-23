using CommunityToolkit.Mvvm.ComponentModel;
using Module.Abstractions;
using System.Windows.Input;

namespace Maui.MicroFrontend.ViewModels;

public class LoginViewModel : ObservableObject
{
    private readonly INavigationService _navigationService;

    public LoginViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
    }

    public ICommand LoginCommand => new Command(() =>
    {
        _navigationService.GoToPage("MainPage");
    });
}
