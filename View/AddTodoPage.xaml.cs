using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System.Threading;

namespace AppTest.View;

public partial class AddTodoPage : ContentPage
{

	public AddTodoPage()
	{
		InitializeComponent();
	}

	private async void AddTodo(object sender, EventArgs e)
	{
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        string text = "Todo added successfully!";
		ToastDuration duration = ToastDuration.Short;
		double fontSize = 14;

        var toast = Toast.Make(text, duration, fontSize);

        await toast.Show(cancellationTokenSource.Token);
        TodoInputText.Text = string.Empty;

	}
}