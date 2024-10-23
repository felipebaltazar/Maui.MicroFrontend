using Module.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Login.Views;

public class PartialView : ContentView, IPartialHomeView
{
    public PartialView()
    {
        var stack = new StackLayout()
        {
            Orientation = StackOrientation.Vertical,
            HorizontalOptions = LayoutOptions.CenterAndExpand,
        };

        stack.Children.Add(new Label()
        {
            Text = "Authenticated user: Felipe",
            VerticalTextAlignment = TextAlignment.Center,
            HorizontalTextAlignment = TextAlignment.Center,
            TextColor = Colors.Black,
        });

        stack.Children.Add(new Label()
        {
            Text = "View from login module",
            VerticalTextAlignment = TextAlignment.Center,
            HorizontalTextAlignment = TextAlignment.Center,
            TextColor = Colors.Black,
        });

        Content = new Frame()
        {
            Padding = 0,
            Content = stack
        };
    }
}
