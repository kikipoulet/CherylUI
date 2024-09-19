using System.Globalization;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data.Converters;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace CherylUI.Controls;

    public partial class SliverPage : UserControl
    {
        public SliverPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        
        public static readonly StyledProperty<string> HeaderProperty =
            AvaloniaProperty.Register<SliverPage, string>(nameof(Header), defaultValue: "Header");

        public string Header
        {
            get { return GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value ); }
        }
        
        public static readonly StyledProperty<bool> IsBackVisibleProperty =
            AvaloniaProperty.Register<SliverPage, bool>(nameof(IsBackVisible), defaultValue: false);

        public bool IsBackVisible
        {
            get { return GetValue(IsBackVisibleProperty); }
            set { SetValue(IsBackVisibleProperty, value ); }
        }

        private void GoBack(object? sender, RoutedEventArgs e)
        {
            MobileNavigation.Pop();
        }
    }
    
    public class OffsetToHeightConverter : IValueConverter
    {
        public static readonly OffsetToHeightConverter Instance = new OffsetToHeightConverter();

        public object? Convert( object? value, Type targetType, object? parameter, CultureInfo culture )
        {

            double Offset =  ((Vector)value).Y * 0.7;

      
            double Height = 170 - (Offset);

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
    
    public class OffsetToMarginConverter : IValueConverter
    {
        public static readonly OffsetToMarginConverter Instance = new OffsetToMarginConverter();

        public object? Convert( object? value, Type targetType, object? parameter, CultureInfo culture )
        {
            double offset = ((Vector)value).Y * 0.7;

           

            if (offset > 70)
                offset = 70;
            
            

            if(parameter == (object?)true)
                return new Thickness(25 + (offset * 1), 75 - offset, 0 , -10 + (offset / 7));
            else
                return new Thickness(25 , 75 - offset, 0 , -10 + (offset / 7));

        }

        public object ConvertBack( object? value, Type targetType, object? parameter, CultureInfo culture )
        {
            throw new NotSupportedException();
        }
    }

    public class OffsetToMarginScrollConverter : IValueConverter
    {
        public static readonly OffsetToMarginScrollConverter Instance = new OffsetToMarginScrollConverter();

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            double offset = ((Vector)value).Y * 0.7;

            if (offset > 70)
                offset = 70;

            return new Thickness(0, 170, 0, 0);
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }

    public class OffsetToFontSizeConverter : IValueConverter
    {
        public static readonly OffsetToFontSizeConverter Instance = new OffsetToFontSizeConverter();

        public object? Convert( object? value, Type targetType, object? parameter, CultureInfo culture )
        {
            double Offset =  ((Vector)value).Y * 0.7;

         

            double fontsize = 45 - (Offset / 2.5);

            if (fontsize < 25)
                return 25;

            return fontsize;
        }

        public object ConvertBack( object? value, Type targetType, object? parameter, CultureInfo culture )
        {
            throw new NotSupportedException();
        }
    }