using System.Linq;
using Android.App;
using Android.Content.PM;
using Avalonia.Android;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.VisualTree;
using CherylUI.Controls;

namespace CherylCrossTest.Android;

[Activity(Label = "CherylCrossTest.Android", Theme = "@style/MyTheme.NoActionBar", Icon = "@drawable/icon",
    MainLauncher = true, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
public class MainActivity : AvaloniaMainActivity<App>
{
    public override void OnBackPressed()
    {

        MobileNavigation navControl = ((ISingleViewApplicationLifetime)CherylCrossTest.App.Current.ApplicationLifetime).MainView.GetVisualDescendants().OfType<MobileNavigation>().First();

        navControl.PopPage();

    }
}