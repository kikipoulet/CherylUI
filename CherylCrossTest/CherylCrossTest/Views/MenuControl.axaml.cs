using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;
using CherylUI.Controls;

namespace CherylCrossTest.Views;

public partial class MenuControl : UserControl
{
    public MenuControl()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
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
    private void ToggleButton_OnIsCheckedChanged(object? sender, RoutedEventArgs e)
    {
        var t = (ToggleButton)sender;
        if(t.IsChecked == true)
            Application.Current.RequestedThemeVariant = ThemeVariant.Dark;
        else
            Application.Current.RequestedThemeVariant = ThemeVariant.Light;

    }
    
}