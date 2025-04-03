using Android.App;
using Android.Content.PM;
using Avalonia.Android;

namespace CherylCrossTest.Android;

[Activity(Label = "CherylCrossTest.Android", Theme = "@style/MyTheme.NoActionBar", Icon = "@drawable/icon",
    MainLauncher = true, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
public class MainActivity : AvaloniaMainActivity<App>
{
}