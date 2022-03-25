using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JanaJerkic_Feb2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Glavna : ContentPage
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Greška", "Molimo da izvršite kreiranje profila prije prijave...", "OK");
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Registracija());
        }
    }
}