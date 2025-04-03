using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;
using Avalonia.VisualTree;

namespace CherylUI.Controls;

public partial class InteractiveContainer : UserControl
{
    public InteractiveContainer()
    {
        InitializeComponent();
        this.Loaded += InteractiveContainer_Loaded;
    }

    private void InteractiveContainer_Loaded(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        TopLevel? T = TopLevel.GetTopLevel(this);
        if (TopLevel.GetTopLevel(this) is { } toplevel)
        {
            toplevel.BackRequested += T_BackRequested;
        }
    }

    private void T_BackRequested(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MobileNavigation mobileNavigation = MobileNavigation.GetMobileStackInstance();
        if (mobileNavigation.Pages.Count == 0) //if page count is 0 let default back button behaviour happen
            return;
        MobileNavigation.Pop();
        e.Handled = true;
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    public static readonly StyledProperty<bool> ShowAtBottomProperty = AvaloniaProperty.Register<InteractiveContainer, bool>(nameof(InteractiveContainer), defaultValue: false);

    public bool ShowAtBottom
    {
        get { return GetValue(ShowAtBottomProperty); }
        set
        {
            
            SetValue(ShowAtBottomProperty, value );
        }
    }
    
    public static readonly StyledProperty<bool> IsDialogOpenProperty = AvaloniaProperty.Register<InteractiveContainer, bool>(nameof(InteractiveContainer), defaultValue: false);

    public bool IsDialogOpen
    {
        get { return GetValue(IsDialogOpenProperty); }
        set
        {
            
            SetValue(IsDialogOpenProperty, value );
        }
    }
    
    public static readonly StyledProperty<bool> IsToastOpenProperty = AvaloniaProperty.Register<InteractiveContainer, bool>(nameof(InteractiveContainer), defaultValue: false);

    public bool IsToastOpen
    {
        get { return GetValue(IsToastOpenProperty); }
        set
        {
            
            SetValue(IsToastOpenProperty, value );
        }
    }
    
    public static readonly StyledProperty<Control> DialogContentProperty = AvaloniaProperty.Register<InteractiveContainer, Control>(nameof(InteractiveContainer), defaultValue: new Grid());

    public Control DialogContent
    {
        get { return GetValue(DialogContentProperty); }
        set
        {
            
            SetValue(DialogContentProperty, value );
        }
    }
    
    public static readonly StyledProperty<Control> ToastContentProperty = AvaloniaProperty.Register<InteractiveContainer, Control>(nameof(InteractiveContainer), defaultValue: new Grid());

    public Control ToastContent
    {
        get { return GetValue(ToastContentProperty); }
        set
        {
            
            SetValue(ToastContentProperty, value );
        }
    }



    private static InteractiveContainer GetInteractiveContainerInstance()
    {
        InteractiveContainer container = null;
        try
        {
            container = ((ISingleViewApplicationLifetime)Application.Current.ApplicationLifetime).MainView.GetVisualDescendants().OfType<InteractiveContainer>().First();
                
        }
        catch (Exception exc)
        {
            
            try
            {
                container = ((IClassicDesktopStyleApplicationLifetime)Application.Current.ApplicationLifetime).MainWindow.GetVisualDescendants().OfType<InteractiveContainer>().First();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "You are trying to use a InteractiveContainer functionality without declaring one !");
            }
                
        }

        return container;
    }

    
    public static void ShowToast(Control Message, int seconds)
    {
        var container = GetInteractiveContainerInstance();

        container.ToastContent = Message;
        container.IsToastOpen = true;

            
        Task.Run((() =>
        {
            Thread.Sleep(seconds * 1000);
            Dispatcher.UIThread.InvokeAsync(() =>
            {
                container.IsToastOpen = false;
            });
        }));
    }

    public static void CloseDialog()
    {
        GetInteractiveContainerInstance().IsDialogOpen = false;
    }

    public static void WaitUntilDialogIsClosed()
    {
        InteractiveContainer container = null;

        Dispatcher.UIThread.InvokeAsync(() =>
        {
            container = GetInteractiveContainerInstance();
        });
        bool flag = true;

        do
        {
            Dispatcher.UIThread.InvokeAsync(() =>
            {
                flag = container.IsDialogOpen;
            });
            
            Thread.Sleep(200);
        } while (flag);
           
    }


    
    public static void ShowDialog(Control content, bool showAtBottom = false)
    {
        var container = GetInteractiveContainerInstance();

        container.IsDialogOpen = true;
        container.DialogContent = content;
        container.ShowAtBottom = showAtBottom;
    }
}