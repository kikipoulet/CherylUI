using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using CherylUI.Controls;

namespace CherylCrossTest.Views;

public partial class ClockPage : UserControl
{
    public ClockPage()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    private void GoBack(object? sender, RoutedEventArgs e)
    {
        MobileNavigation.Pop();
    }
    
}