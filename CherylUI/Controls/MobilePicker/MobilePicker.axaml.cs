using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace CherylUI.Controls.MobilePicker;

public partial class MobilePicker : UserControl
{
    public MobilePicker()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    

    private string _subtitle;
    public string SubTitle
    {
        get => _subtitle;
        set => SetAndRaise(SubTitleProperty, ref _subtitle, value );
    }
    public static readonly DirectProperty<MobilePicker, string> SubTitleProperty =
        AvaloniaProperty.RegisterDirect<MobilePicker, string>(
            nameof(SubTitle),
            o => o.SubTitle,
            (o, v) => o.SubTitle = v,
            defaultBindingMode: BindingMode.TwoWay,
            enableDataValidation: true);

    
    private string _title;
    public string Title
    {
        get => _title;
        set => SetAndRaise(TitleProperty, ref _title, value );
    }
    public static readonly DirectProperty<MobilePicker, string> TitleProperty =
        AvaloniaProperty.RegisterDirect<MobilePicker, string>(
            nameof(Title),
            o => o.Title,
            (o, v) => o.Title = v,
            defaultBindingMode: BindingMode.TwoWay,
            enableDataValidation: true);
    
    private string _selectedItem;
    public string SelectedItem
    {
        get => _selectedItem;
        set => SetAndRaise(SelectedItemProperty, ref _selectedItem, value );
    }
    public static readonly DirectProperty<MobilePicker, string> SelectedItemProperty =
        AvaloniaProperty.RegisterDirect<MobilePicker, string>(
            nameof(SelectedItem),
            o => o.SelectedItem,
            (o, v) => o.SelectedItem = v,
            defaultBindingMode: BindingMode.TwoWay,
            enableDataValidation: true);
    
    
    public static readonly StyledProperty<ObservableCollection<string>> ItemsProperty =
        AvaloniaProperty.Register<MobilePicker, ObservableCollection<string>>(nameof(Items), defaultValue: new ObservableCollection<string>());

    public ObservableCollection<string> Items
    {
        get { return GetValue(ItemsProperty); }
        set { SetValue(ItemsProperty, value ); }
    }

    private void OpenPopup(object sender, RoutedEventArgs e)
    {
        var control = new MobilePickerPopUp();

        var vm = ((MobilePickerPopUpVM)control.DataContext);
        vm.Items = Items;
        vm.SelectedItem = SelectedItem;
        vm.Title = Title;
        vm.SubTitle = SubTitle;
        vm.mobilePicker = this;

        
        control.Width = PopupWidth;
        control.FindControl<Border>("rootBorder").RenderTransform = PopupScale;
        
        InteractiveContainer.ShowDialog(control , true);
 
       
    }
    
            
    public static readonly StyledProperty<ScaleTransform> PopupScaleProperty = AvaloniaProperty.Register<MobilePicker, ScaleTransform>(nameof(MobilePicker), defaultValue: new ScaleTransform());

    public ScaleTransform PopupScale
    {
        get { return GetValue(PopupScaleProperty); }
        set
        {
            
            SetValue(PopupScaleProperty, value );
        }
    }
    

    
    public static readonly StyledProperty<int> PopupWidthProperty = AvaloniaProperty.Register<MobilePicker, int>(nameof(MobilePicker), defaultValue: 300);

    public int PopupWidth
    {
        get { return GetValue(PopupWidthProperty); }
        set
        {
            
            SetValue(PopupWidthProperty, value );
        }
    }

}