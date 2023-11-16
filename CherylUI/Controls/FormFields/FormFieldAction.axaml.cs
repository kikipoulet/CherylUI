using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace CherylUI.Controls.FormFields;

public partial class FormFieldAction : UserControl
{
    public FormFieldAction()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
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
    
    public static readonly DirectProperty<FormFieldAction, ICommand> CommandProperty =
        AvaloniaProperty.RegisterDirect<FormFieldAction, ICommand>(
            nameof(Command),
            o => o.Command,
            (o, v) => o.Command = v);

    public static readonly DirectProperty<FormFieldAction, object> CommandParameterProperty =
        AvaloniaProperty.RegisterDirect<FormFieldAction, object>(
            nameof(CommandParameter),
            o => o.CommandParameter,
            (o, v) => o.CommandParameter = v);

    private ICommand _myCommand;
    private object _commandParameter;

    public ICommand Command
    {
        get => _myCommand;
        set => SetAndRaise(CommandProperty, ref _myCommand, value);
    }

    public object CommandParameter
    {
        get => _commandParameter;
        set => SetAndRaise(CommandParameterProperty, ref _commandParameter, value);
    }
}