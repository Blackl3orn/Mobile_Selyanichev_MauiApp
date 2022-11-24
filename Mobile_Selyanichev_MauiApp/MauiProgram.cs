using Mobile_Selyanichev_MauiApp.Services;
using Mobile_Selyanichev_MauiApp.ViewModels;

namespace Mobile_Selyanichev_MauiApp;

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
			});

        builder.Services.AddSingleton<CreateProblem>();
		builder.Services.AddSingleton<AddProblemService>();
		builder.Services.AddSingleton<CreateProblemViewModel>();

        builder.Services.AddSingleton<SolveProblem>();
        builder.Services.AddSingleton<GetProblemService>();
        builder.Services.AddSingleton<SolveProblemViewModel>();

        builder.Services.AddSingleton<DoneProblem>();
        builder.Services.AddSingleton<GetDoneProblemService>();
        builder.Services.AddSingleton<DoneProblemViewModel>();

        builder.Services.AddSingleton<SubmitProblemService>();

        return builder.Build();

		
	}
}
