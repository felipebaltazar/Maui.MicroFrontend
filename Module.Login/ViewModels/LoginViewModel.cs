using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace Maui.MicroFrontend.ViewModels;

public class LoginViewModel : ObservableObject
{
    public ICommand LoginCommand => new Command(() =>
    {
        Shell.Current.GoToAsync("//MainPage");
    });
}
