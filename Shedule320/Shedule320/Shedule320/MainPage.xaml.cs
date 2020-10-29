using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Shedule320
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public async void btMonday_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1("monday"));
        }

        public async void btTuesday_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1("tuesday"));
        }
        public async void btWednesday_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1("wednesday"));
        }
        public async void btThursday1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1("thursday_one"));
        }
        public async void btThursday2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1("thursday_two"));
        }
        public async void btFriday_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1("friday"));
        }
        public async void btSaturday_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1("saturday"));
        }
    }
}
