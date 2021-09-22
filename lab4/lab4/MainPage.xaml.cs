using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace lab4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Page1());
            };
            item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new TabbedPage1());
            };
            item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new CarouselPage1());
            };
            item5.Clicked += async (sender, e) =>
            {
                await Navigation.PushModalAsync(new ModalPage1());
            };
            item6.Clicked += async (sender, e) =>
            {
                var answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
                Debug.WriteLine("Answer:" + answer);
            };


        }
    }
}
