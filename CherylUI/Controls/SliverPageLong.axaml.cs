using System.Globalization;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace CherylUI.Controls;

public partial class SliverPageLong : UserControl
    {
        public SliverPageLong()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        
        public static readonly StyledProperty<string> HeaderProperty =
            AvaloniaProperty.Register<SliverPageLong, string>(nameof(Header), defaultValue: "Header");

        public string Header
        {
            get { return GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value ); }
        }

        private void GoBack(object? sender, RoutedEventArgs e)
        {
            MobileNavigation.Pop();
        }
    }
    
    public class OffsetToHeightConverterLong : IValueConverter
    {
        public static readonly OffsetToHeightConverterLong Instance = new OffsetToHeightConverterLong();

        public object? Convert( object? value, Type targetType, object? parameter, CultureInfo culture )
        {

            double Offset =  ((Vector)value).Y ;

      
            double Height = 370 - (Offset);

            if (Height < 100)
                return 100;
            else
                return Height;

        }

        public object ConvertBack( object? value, Type targetType, object? parameter, CultureInfo culture )
        {
            throw new NotSupportedException();
        }
    }

public class OffsetToOpacityConverterLong : IValueConverter
{
    public static readonly OffsetToOpacityConverterLong Instance = new OffsetToOpacityConverterLong();

    public object? Convert( object? value, Type targetType, object? parameter, CultureInfo culture )
    {
        double Offset =  ((Vector)value).Y ;

         

        double opacity =  (180 - Offset) / 180;

        if (opacity < 0)
            return 0;

        return opacity;
    }

    public object ConvertBack( object? value, Type targetType, object? parameter, CultureInfo culture )
    {
        throw new NotSupportedException();
    }
}
    

public class OffsetToInvertOpacityConverterLong : IValueConverter
{
    public static readonly OffsetToInvertOpacityConverterLong Instance = new OffsetToInvertOpacityConverterLong();

    public object? Convert( object? value, Type targetType, object? parameter, CultureInfo culture )
    {
        double Offset =  ((Vector)value).Y ;

         

        double opacity = 0.2 - ( (220 - Offset) / 220 );

        if (opacity < 0)
            return 0;
        
        if (opacity > 1)
            return 1;

        return opacity;
    }

    public object ConvertBack( object? value, Type targetType, object? parameter, CultureInfo culture )
    {
        throw new NotSupportedException();
    }
}

  

   

  