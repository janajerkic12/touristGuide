using JanaJerkic_Feb2.Models;
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
    public partial class Registracija : ContentPage
    {
        
        public Registracija()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (sifra.Text == potvrdi.Text)
            {
                // Detektovati lokaciju pri registraciji je nelogično (generalno, naš primjer i ne čini neku veliku grešku"), pri svakom Loginu bi bilo logičnije
                //var location = await Geolocation.GetLastKnownLocationAsync();
                //if (location == null)
                //{
                //    location = await Geolocation.GetLocationAsync(new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(20)));
                //}


                User user = new User
                {
                    imePrezime = ime.Text,
                    sifra = sifra.Text,
                    email = email.Text
                };

                await Navigation.PushModalAsync(new Prijava(user));
            }

            else
            {
                await DisplayAlert("Greška", "Šifra i Potvrda šife morajau biti identični!", "OK");
            }
        }
    }
}