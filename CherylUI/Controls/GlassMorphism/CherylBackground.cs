using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Avalonia.Threading;

namespace CherylUI.Controls.GlassMorphism;

public class CherylBackground: Image, IDisposable
{
    private const int ImageWidth = 100;
    private const int ImageHeight = 100;
    private const float AnimFps = 5;

    private readonly WriteableBitmap _bmp = new(new PixelSize(ImageWidth, ImageHeight), new Vector(96, 96),
        PixelFormats.Bgra8888);

    /// <summary>
    /// Quickly and easily assign a generator either for testing, or in future allow dev-defined generators...
    /// </summary>
    private readonly FastNoiseBackgroundRenderer _renderer = new FastNoiseBackgroundRenderer();


    
    public CherylBackground()
    {
        Source = _bmp;
        Stretch = Stretch.UniformToFill;

    }

    public override void EndInit()
    {
        base.EndInit();

        Application.Current.ActualThemeVariantChanged += (sender, args) =>
        {
            _renderer.UpdateValues(Application.Current.ActualThemeVariant);
            _renderer.Render(_bmp);
        };
        
        _renderer.UpdateValues(Application.Current.ActualThemeVariant);
        _renderer.Render(_bmp);

    }



    public void Dispose()
    {
        _bmp.Dispose();
    }
}