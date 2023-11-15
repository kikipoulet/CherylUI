using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace CherylCrossTest.Views;

public partial class LoginPage : UserControl
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}