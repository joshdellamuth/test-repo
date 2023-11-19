using CommunityToolkit.Maui;
using GoalsApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            // Initialize the .NET MAUI Community Toolkit by adding the below line of code
            .UseMauiCommunityToolkit()
            // After initializing the .NET MAUI Community Toolkit, optionally add additional fonts
            .ConfigureFonts(fonts =>
            {
                //Default fonts 
                //fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                //fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                //Newly added fonts: 
                fonts.AddFont("Montserrat-Regular.ttf", "Montserrat");
                fonts.AddFont("Montserrat-Bold.ttf", "MontserratBold");
                fonts.AddFont("Montserrat-ExtraBold.ttf", "MontserratExtraBold"); //pretty bold, maybe too bold 
                fonts.AddFont("Montserrat-Light.ttf", "MontserratLight");
                fonts.AddFont("Montserrat-Italic.ttf", "MontserratItalic"); 
            });

        // Continue initializing your .NET MAUI App here
        return builder.Build();
    }
}
