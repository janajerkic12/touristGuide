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
    public partial class CijenaVoznje : ContentPage
    {
        public CijenaVoznje(User _user, AutobuskaStanica destinacija, int odrasli, int djeca, int penzioneri)
        {
            InitializeComponent();

            grad.Text = $"{destinacija.Grad}, Bosna i Hercegovina";
            Fotografija.Source = destinacija.Fotografija;
            cijenaOdrasli.Text ="Odrasli: " + $"{odrasli} x "+ $"{destinacija.CijenaPoKM} = " + odrasli * destinacija.CijenaPoKM + " KM";
            cijenaDjeca.Text = "Djeca(70%): " + $"{djeca} x " + $"{destinacija.CijenaPoKM*0.7} = " + djeca * destinacija.CijenaPoKM * 0.7 + " KM";
            cijenaPenzioneri.Text = "Penzioneri()50%: " + $"{penzioneri} x " + $"{destinacija.CijenaPoKM*0.5} = " + penzioneri * destinacija.CijenaPoKM * 0.5 + ",00 KM";

            ukupno.Text = odrasli * destinacija.CijenaPoKM + djeca * destinacija.CijenaPoKM * 0.7 + destinacija.CijenaPoKM * 0.5 + " ";

            /*Location Odredište = new Location(destinacija.Latitude, destinacija.Longitude);
            double _udaljenost = Location.CalculateDistance(_user.Latitude, _user.Longitude, Odredište, DistanceUnits.Kilometers);

            udaljenost.Text = Math.Round(_udaljenost, 2).ToString() + " km";
            cijena.Text = Math.Round((_udaljenost * destinacija.CijenaPoKM), 0).ToString() + " KM";*/
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Kupovina izvrsena", "Vaša karta je plaćena. Zahvaljujemo što putujete sa nama", "OK");
        }
    }
}