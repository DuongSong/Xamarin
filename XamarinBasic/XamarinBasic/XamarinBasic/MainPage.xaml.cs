using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinBasic
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();
        }

        private void BtnApp1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new App1());
        }

        private void BtnApp2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new App2());
        }
    }
}
