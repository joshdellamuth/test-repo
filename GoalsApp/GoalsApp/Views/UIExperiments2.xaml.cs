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

        var label = new Label { Text = "My Tasks", FontFamily = "Montserrat", FontSize = 30 };
        var label1 = new Label { Text = "My Tasks", FontFamily = "MontserratBold", FontSize = 30 };
        var label2 = new Label { Text = "My Tasks", FontFamily = "MontserratExtraBold", FontSize = 30 };
        var label3 = new Label { Text = "My Tasks", FontFamily = "MontserratLight", FontSize = 30 };
        var label4 = new Label { Text = "My Tasks", FontFamily = "MontserratItalic", FontSize = 30 };

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
            Padding = new Thickness(30),
            Children = { label, label1, label2, label3, label4, border }
        };
    }
}