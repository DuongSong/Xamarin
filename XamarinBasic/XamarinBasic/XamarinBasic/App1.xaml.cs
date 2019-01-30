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
	public partial class App1 : ContentPage
	{
		public App1 ()
		{
			InitializeComponent ();
		}

        static string boom = new Random().Next(1, 5).ToString();
        static int score = 0;
        static int maxScore = 10;
        private void btn_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text == boom )
            {
                DisplayAlert("Bom Explored", "Game Over", "Retry");
                boom = new Random().Next(1, 5).ToString();
                score = 0;
            }
            else
            {
                score++;
                boom = new Random().Next(1, 5).ToString();
            }
            lbScore.Text = score.ToString();
            if (score == maxScore)
            {
                DisplayAlert("Notify", "You win", "Retry");
                score = 0;
                boom = new Random().Next(1, 5).ToString();
            }
        }
    }
}