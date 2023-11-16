namespace GoalsApp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    async void GoToTaskPage(object sender, EventArgs e)
    {
        // Navigate to the TaskPage
        await Shell.Current.GoToAsync("TaskPage");
    }

}

