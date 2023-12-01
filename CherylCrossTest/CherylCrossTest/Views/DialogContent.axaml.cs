using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using CherylUI.Controls;

namespace CherylCrossTest.Views;

public partial class DialogContent : UserControl
{
    public DialogContent()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        InteractiveContainer.CloseDialog();
    }
}