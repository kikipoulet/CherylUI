using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;
using CherylCrossTest.ViewModels;
using CherylUI.Controls;

namespace CherylCrossTest.Views;

public partial class SettingsPage : UserControl
{
    public SettingsPage()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void ToggleButton_OnIsCheckedChanged(object? sender, RoutedEventArgs e)
    {
        var t = (ToggleButton)sender;
        if(t.IsChecked == true)
            Application.Current.RequestedThemeVariant = ThemeVariant.Dark;
        else
            Application.Current.RequestedThemeVariant = ThemeVariant.Light;

    }

    private void GoBack(object? sender, RoutedEventArgs e)
    {
        MobileNavigation.Pop();
    }

    private void gotologin(object? sender, RoutedEventArgs e)
    {
        MobileNavigation.Push(new LoginPage());
    }
}