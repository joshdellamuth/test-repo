using Microsoft.Maui.Controls;
using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls.Shapes;

namespace GoalsApp.Views;

public partial class UIExperiments2 : ContentPage
{
    public UIExperiments2()
    {
        //If all code is done in c#, no need to call initialize component
        //InitializeComponent();

        var label = new Label { Text = "My Tasks", FontFamily = "MontserratExtraBold" };

        //button.Clicked has our object (button) getting clicked
        //+= is used to subscribe to a method 
        //button.Clicked += (s, e) => {
        //    label.Text = "Button clicked!";
        //};

        var border = new Border
        {
            Content = new Expander
            {
                Header = new Label { Text = "Section 1", FontFamily= "MontserratExtraBold" },
                Content = new Label { Text = "Content for section 1" }
            },
            Padding = new Thickness(10),
            StrokeShape = new RoundRectangle
            {
                CornerRadius = new CornerRadius(10,10,10,10)
            },
            Background = new SolidColorBrush(Colors.LightGrey)//,
            //StrokeThickness = 4,

        };
        


        Content = new StackLayout
        {
            Padding = new Thickness(15),
            Children = { label, border }
        };
    }
}