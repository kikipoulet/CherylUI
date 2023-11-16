using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Xaml;

namespace CherylUI.Controls.FormFields;

public partial class FormFieldNumberPicker : UserControl
{
    public FormFieldNumberPicker()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    
    public static readonly DirectProperty<FormFieldNumberPicker, int> MaximumProperty =
        AvaloniaProperty.RegisterDirect<FormFieldNumberPicker, int>(
            nameof(Maximum),
            o => o.Maximum,
            (o, v) => o.Maximum = v, 0, BindingMode.TwoWay);

    private int _Maximum = 0;

    public int Maximum
    {
        get { return _Maximum; }
        set { SetAndRaise(MaximumProperty, ref _Maximum, value); }
    }


    public static readonly DirectProperty<FormFieldNumberPicker, int> MinimumProperty =
        AvaloniaProperty.RegisterDirect<FormFieldNumberPicker, int>(
            nameof(Minimum),
            o => o.Minimum,
            (o, v) => o.Minimum = v, 0, BindingMode.TwoWay);

    private int _Minimum = 0;

    public int Minimum
    {
        get { return _Minimum; }
        set { SetAndRaise(MinimumProperty, ref _Minimum, value); }
    }






    public static readonly DirectProperty<FormFieldNumberPicker, int> ValueProperty =
        AvaloniaProperty.RegisterDirect<FormFieldNumberPicker, int>(
            nameof(Value),
            o => o.Value,
            (o, v) => o.Value = v, 0, BindingMode.TwoWay);

    private int _Value = 0;

    public int Value
    {
        get { return _Value; }
        set { SetAndRaise(ValueProperty, ref _Value, value); }
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