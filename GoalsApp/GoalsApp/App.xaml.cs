//This file is where your application begins it's life. When you create 
//a Maui app, a subclass of the Application class is created (App) and 
//you can initialize your application and set the MainPage
namespace GoalsApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
