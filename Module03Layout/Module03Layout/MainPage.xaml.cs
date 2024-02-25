using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module03Layout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public async void Open_StackLayoutPage(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayoutPage());
        }
        public async void Open_AbsoluteLayoutPage(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayoutPage());
        }
        public async void Open_RelativeLayoutPage(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RelativeLayoutPage());
        }
        public async void Open_GridLayoutPage(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridPage());
        }
    }
}
