using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinBasic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App2 : ContentPage
    {
        public App2()
        {
            InitializeComponent();
            CreateButton();
        }

        public void CreateButton()
        {
            int dem = 0;
            Grid grid = new Grid
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Center
            };
            for (var i = 0; i < 4; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });
                for (var j = 0; j < 4; j++)
                {
                    grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
                    Button button = new Button
                    {
                        Text = dem++.ToString(),
                        WidthRequest = 80,
                        HeightRequest = 80,
                        FontSize = 10
                        //CommandParameter = new Random().Next(1, 17).ToString()
                    };
                    grid.Children.Add(button, j, i);
                    button.Clicked += new System.EventHandler(btnClick);
                }
                dem += i;
            }
            Content = new StackLayout
            {
                Children = { grid }
            };
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DisplayAlert("1", "1", new Random().Next(1, 17).ToString());
        }
    }
}