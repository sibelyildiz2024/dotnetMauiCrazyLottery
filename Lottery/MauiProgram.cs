using Lottery.Service;
using Microsoft.Extensions.Logging;

namespace Lottery
{
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
				});

			builder.Services.AddMauiBlazorWebView();

#if DEBUG
			builder.Services.AddBlazorWebViewDeveloperTools();

			builder.Services.AddBlazorBootstrap();

			var dbPath = Path.Combine(
				Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
				@"CrazyLottery.db");

			builder.Services.AddSingleton<ICrazyNumericLotteryService, CrazyNumericLotteryService>(
				s => ActivatorUtilities.CreateInstance<CrazyNumericLotteryService>(s, dbPath));

			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
