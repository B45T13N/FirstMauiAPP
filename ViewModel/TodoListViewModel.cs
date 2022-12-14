namespace AppTest.ViewModel;

public partial class TodoListViewModel : BaseViewModel
{
    public ObservableCollection<Todo> Todos { get; set; } = new();

    public TodoListViewModel() 
    {
        Title = "Todos";
    }
}
