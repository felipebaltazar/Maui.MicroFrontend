using Maui.MicroFrontend.ViewModels;

namespace Maui.MicroFrontend.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel();
    }
}