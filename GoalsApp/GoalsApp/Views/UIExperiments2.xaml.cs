using Microsoft.Maui.Controls;

namespace GoalsApp.Views;

public partial class UIExperiments2 : ContentPage
{
	public UIExperiments2()
	{
        //If all code is done in c#, no need to call initialize component
        //InitializeComponent();

        var button = new Button { Text = "Click me!" };
        var label = new Label { Text = "Hello, World!" };

        button.Clicked += (s, e) => {
            label.Text = "Button clicked!";
        };

        Content = new StackLayout
        {
            Children = { button, label }
        };
    }
}