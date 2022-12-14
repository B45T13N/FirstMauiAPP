namespace AppTest.View;

public partial class AddTodo : ContentView
{
    public string inputText;

	public AddTodo()
	{
		InitializeComponent();
	}

    private void OnClickAddButton(object sender, EventArgs e)
    {
        inputText = TodoInput.Text;


        SemanticScreenReader.Announce(TodoInput.Text);
    }
}