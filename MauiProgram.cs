using Microsoft.Extensions.Logging;


namespace AplicatieProiectMobil;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .ConfigureEssentials(essentials =>

            { essentials.UseMapServiceToken("8jwkUNVums9z11nheIVp~BzwMQdpxRduzKIwKB2GG1A~Alpxdm9U4bq_Yeh7ouQQ9x4uMJdoWSjGLXFbsFM9Gk_F6qWIuCfGgLT8U7fBtFuT"); });

#if DEBUG
        object value = builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}