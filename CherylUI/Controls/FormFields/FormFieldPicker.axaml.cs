using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Xaml;

namespace CherylUI.Controls.FormFields;

public partial class FormFieldPicker : UserControl
{
    public FormFieldPicker()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    
    public static readonly StyledProperty<ObservableCollection<string>> ItemsProperty =
        AvaloniaProperty.Register<FormFieldPicker, ObservableCollection<string>>(nameof(Items), defaultValue: new ObservableCollection<string>());

    public ObservableCollection<string> Items
    {
        get { return GetValue(ItemsProperty); }
        set { SetValue(ItemsProperty, value ); }
    }
    
    public static readonly DirectProperty<FormFieldPicker, string> SelectedItemProperty =
        AvaloniaProperty.RegisterDirect<FormFieldPicker, string>(
            nameof(SelectedItem),
            o => o.SelectedItem,
            (o, v) => o.SelectedItem = v, "", BindingMode.TwoWay);

    private string _SelectedItem = "";

    public string SelectedItem
    {
        get { return _SelectedItem; }
        set { SetAndRaise(SelectedItemProperty, ref _SelectedItem, value); }
    }

     
    public static readonly StyledProperty<string> DialogTitleProperty = AvaloniaProperty.Register<FormFieldPicker, string>(nameof(DialogTitle), defaultValue: "DialogTitle");

    public string DialogTitle
    {
        get { return GetValue(DialogTitleProperty); }
        set
        {
            
            SetValue(DialogTitleProperty, value );
        }
    }
    
    public static readonly StyledProperty<string> DialogSubTitleProperty = AvaloniaProperty.Register<FormFieldPicker, string>(nameof(DialogSubTitle), defaultValue: "DialogSubTitle");

    public string DialogSubTitle
    {
        get { return GetValue(DialogSubTitleProperty); }
        set
        {
            
            SetValue(DialogSubTitleProperty, value );
        }
    }
    
    public static readonly StyledProperty<string> TitleProperty = AvaloniaProperty.Register<FormFieldPicker, string>(nameof(Title), defaultValue: "Title");

    public string Title
    {
        get { return GetValue(TitleProperty); }
        set
        {
            
            SetValue(TitleProperty, value );
        }
    }
}