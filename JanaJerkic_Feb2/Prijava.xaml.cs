using JanaJerkic_Feb2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JanaJerkic_Feb2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Prijava : ContentPage
    {
        public User registrovanikorisnik;
        public Prijava(User _user)
        {
            InitializeComponent();
            registrovanikorisnik = _user;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (registrovanikorisnik.email == email.Text && registrovanikorisnik.sifra == sifra.Text)
            {
                /*var location = await Geolocation.GetLastKnownLocationAsync();
                if (location == null)
                {
                    location = await Geolocation.GetLocationAsync(new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(20)));
                }

                registrovanikorisnik.geoDuzina = location.Latitude;
                registrovanikorisnik.geoSirina = location.Longitude;
                */
                await Navigation.PushModalAsync(new RedVoznje(registrovanikorisnik));
            }
            else
            {
                await DisplayAlert("Pogrešni pristupni podaci", "Porvjerite email i/ili šifru!", "OK");
            }
        }
    }
}