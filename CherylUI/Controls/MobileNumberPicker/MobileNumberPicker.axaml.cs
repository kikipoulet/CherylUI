using System.Globalization;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace CherylUI.Controls.MobileNumberPicker;


public partial class MobileNumberPicker : UserControl
{
    public MobileNumberPicker()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    private int _value;
    
    /// <summary>
    /// Gets the current value.
    /// </summary>
    public int Value
    {
        get => _value;
        set => SetAndRaise(ValueProperty, ref _value, value );
    }
    
    /// <summary>
    /// Defines the <see cref="Value"/> property.
    /// </summary>
    public static readonly DirectProperty<MobileNumberPicker, int> ValueProperty =
        AvaloniaProperty.RegisterDirect<MobileNumberPicker, int>(
            nameof(Value),
            o => o.Value,
            (o, v) => o.Value = v,
            defaultBindingMode: BindingMode.TwoWay,
            enableDataValidation: true);
    
    /// <summary>
    /// Gets or sets the minimum allowed value.
    /// </summary>
    public int Minimum
    {
        get { return GetValue(MinimumProperty); }
        set { SetValue(MinimumProperty, value ); }
    }
    
    /// <summary>
    /// Defines the <see cref="Minimum"/> property.
    /// </summary>
    public static readonly StyledProperty<int> MinimumProperty =
        AvaloniaProperty.Register<MobileNumberPicker, int>(nameof(Minimum), defaultValue: 0);
    
    /// <summary>
    /// Gets or sets the maximum allowed value.
    /// </summary>
    public int Maximum
    {
        get { return GetValue(MaximumProperty); }
        set { SetValue(MaximumProperty, value ); }
    }
    
    /// <summary>
    /// Defines the <see cref="Maximum"/> property.
    /// </summary>
    public static readonly StyledProperty<int> MaximumProperty =
        AvaloniaProperty.Register<MobileNumberPicker, int>(nameof(Maximum), defaultValue: 100);
    
    private void OpenPopup(object sender, RoutedEventArgs e)
    {
        var control = new MobileNumberPickerPopup(this);
    
        InteractiveContainer.ShowDialog(control , true);
    }
}


public class IntToStringConverter : IValueConverter
{
    public static readonly IntToStringConverter Instance = new();

    public object? Convert( object? value, Type targetType, object? parameter, CultureInfo culture )
    {
        return value.ToString();
    }

    public object ConvertBack( object? value, Type targetType, object? parameter, CultureInfo culture )
    {
        throw new NotSupportedException();
    }
}