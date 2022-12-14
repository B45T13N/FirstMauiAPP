namespace AppTest.View;

public partial class MainPage : ContentPage
{
	TodoListViewModel viewModel;

	public MainPage(TodoListViewModel viewModel)
	{
		InitializeComponent();

		this.viewModel = viewModel;

		BindingContext = viewModel;
	}	
}

