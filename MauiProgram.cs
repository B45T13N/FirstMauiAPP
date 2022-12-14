using AppTest.View;
using AppTest.ViewModel;

namespace AppTest;

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

		builder.Services.AddSingleton<TodoListViewModel>();
		builder.Services.AddSingleton<MainPage>();
		
		builder.Services.AddSingleton<AddTodoViewModel>();
		builder.Services.AddSingleton<AddTodoPage>();

        return builder.Build();
	}
}
