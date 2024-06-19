using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace cantaritosA
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseSkiaSharp()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Lora-Italic-VariableFont_wght.ttf", "Lora");
                    fonts.AddFont("Sedan-Italic.ttf", "Sedan");
                    fonts.AddFont("OpenSans-Regular.ttf", "Regular");
                    fonts.AddFont("Lato-Black.ttf", "Lato");
                    fonts.AddFont("Lato-BlackItalic.ttf", "BlackItalic");
                    fonts.AddFont("Cursiva.ttf", "Cursiva");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
