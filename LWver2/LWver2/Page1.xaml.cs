using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LWver2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void BreakfastFirstButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2(1));
        }

        private async void LunchFirstButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2(2));
        }

        private async void DinnerFistButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2(3));
        }

        private async void SnacksFirstButton_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new Page2(4));
        }

    }
}