using Microsoft.Extensions.Logging;
using SplitBillApp.Services;
using SplitBillApp.ViewModels;
using SplitBillApp.Views;

namespace SplitBillApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();

		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Mulish-Bold.ttf", "MulishBold");
				fonts.AddFont("Mulish-Italic.ttf", "MulishItalic");
				fonts.AddFont("Mulish-Light.ttf", "MulishLight"); 
				fonts.AddFont("Mulish-Medium.ttf", "MulishMedium");
                fonts.AddFont("Mulish-Regular.ttf", "MulishRegular");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<PeopleService>();
        builder.Services.AddSingleton<RecentPaymentsService>();
		builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<MainView>();

        return builder.Build();
	}
}