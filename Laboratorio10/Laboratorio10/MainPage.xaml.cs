using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laboratorio10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Item1.Clicked += OnItem1Clicked;
            Item2.Clicked += OnItem2Clicked;
            Item3.Clicked += OnItem3Clicked;
            Item4.Clicked += OnItem4Clicked;
        }

        private async void OnItem1Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BindingModeDemo());
        }

        private async void OnItem2Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListViewDemo());
        }

        private async void OnItem3Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PickerDemo());
        }

        private async void OnItem4Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewToViewDemo());
        }
    }
}
