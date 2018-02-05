using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MuscleTrainingRecords
{
    public class GraphPageCS : ContentPage
    {
        public GraphPageCS()
        {

            Title = "ボディ統計";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Welcome to GraphPage!",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                }
            };
        }
    }
}