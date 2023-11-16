using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Xaml;

namespace CherylUI.Controls.FormFields;

public partial class FormFieldSwitch : UserControl
{
    public FormFieldSwitch()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
     
    public static readonly DirectProperty<FormFieldSwitch, bool> IsCheckedProperty =
        AvaloniaProperty.RegisterDirect<FormFieldSwitch, bool>(
            nameof(IsChecked),
            o => o.IsChecked,
            (o, v) => o.IsChecked = v, false, BindingMode.TwoWay);

    private bool _IsChecked = false;

    public bool IsChecked
    {
        get { return _IsChecked; }
        set { SetAndRaise(IsCheckedProperty, ref _IsChecked, value); }
    }

     
    public static readonly StyledProperty<string> TitleProperty = AvaloniaProperty.Register<FormFieldSwitch, string>(nameof(Title), defaultValue: "Title");

    public string Title
    {
        get { return GetValue(TitleProperty); }
        set
        {
            
            SetValue(TitleProperty, value );
        }
    }

}