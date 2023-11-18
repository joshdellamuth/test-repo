//This provides a container for your application that benefits 
//from a single place to describe the visual structure of 
//your app. Also includes a naviation service with deep 
//linking support. ROUTES GO IN HERE
using GoalsApp.Views;

namespace GoalsApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		//REGISTER ROUTES HERE
		Routing.RegisterRoute("TaskPage", typeof(GoalsApp.Views.MakeShiftTaskPage));

        //REGISTER ROUTES HERE
        Routing.RegisterRoute("TaskPage", typeof(GoalsApp.Views.MakeShiftTaskPage));

        //REGISTER ROUTES HERE
        Routing.RegisterRoute("UIExperiments", typeof(GoalsApp.Views.UIExperiments));

        //REGISTER ROUTES HERE
        Routing.RegisterRoute("UIExperiments2", typeof(GoalsApp.Views.UIExperiments2));
    }
}
