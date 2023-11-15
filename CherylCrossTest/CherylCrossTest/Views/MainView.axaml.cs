using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using CherylUI.Controls;

namespace CherylCrossTest.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        var b = new Button()
        {
            Content = new TextBlock()
            {
                Text = "isse", Margin = new Thickness(20, 8)
            }
        };

        b.Click += (o, args) => 
        {

            InteractiveContainer.CloseDialog();
        };
        
        InteractiveContainer.ShowDialog(b);
    }

    private void GoToSettings(object? sender, RoutedEventArgs e)
    {
        MobileNavigation.Push(new SettingsPage());
    }

    private void GoToAlarm(object? sender, RoutedEventArgs e)
    {
        MobileNavigation.Push(new ClockPage());
    }

    private void GoToLoginPage(object? sender, RoutedEventArgs e)
    {
        MobileNavigation.Push(new LoginPage());
    }
}