﻿using JanaJerkic_Feb2.Models;
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
    public partial class RedVoznje : ContentPage
    {
        public User registrovanikorisnik;
        public IList<AutobuskaStanica> voznje { get; set; }
        
        public RedVoznje(User _user)
        {
            InitializeComponent();
            registrovanikorisnik = _user;

            voznje = new List<AutobuskaStanica>();

            voznje.Add(new AutobuskaStanica { Id = 1, Grad = "Jajce", KratkiOpis = "Duis vestibulum elit vel neque pharetra vulputate. Quisque scelerisque nisi urna. Duis rutrum non risus in imperdiet.", Fotografija = "jajce.jpg", DugiOpis = "+-------------+---------------------+---------+---------+\n| Broj linije |       Relacija      | Polazak | Dolazak |\n+-------------+---------------------+---------+---------+\n| 720         | Čapljina – Sarajevo | 06.09   | 08:35   |\n+-------------+---------------------+---------+---------+\n| 723         | Sarajevo – Čapljina | 07:15   | 09:37   |\n+-------------+---------------------+---------+---------+\n| 722         | Čapljina – Sarajevo | 16:42   | 19:04   |\n+-------------+---------------------+---------+---------+\n| 721         | Sarajevo – Čapljina | 16:49   | 19:15   |\n+-------------+---------------------+---------+---------+\n| 2400        | Konjic – Sarajevo   | 05:25   | 06:51   |\n+-------------+---------------------+---------+---------+\n| 2401        | Sarajevo – Konjic   | 15:48   | 17:14   |\n+-------------+---------------------+---------+---------+", CijenaPoKM = 1.0, Longitude = 17.27059, Latitude = 44.34203 });

            voznje.Add(new AutobuskaStanica { Id = 2, Grad = "BanjaLuka", KratkiOpis = "Duis vestibulum elit vel neque pharetra vulputate. Quisque scelerisque nisi urna. Duis rutrum non risus in imperdiet.", Fotografija = "banjaluka.png", DugiOpis = "+-------------+---------------------+---------+---------+\n| Broj linije |       Relacija      | Polazak | Dolazak |\n+-------------+---------------------+---------+---------+\n| 720         | Čapljina – Sarajevo | 06.09   | 08:35   |\n+-------------+---------------------+---------+---------+\n| 723         | Sarajevo – Čapljina | 07:15   | 09:37   |\n+-------------+---------------------+---------+---------+\n| 722         | Čapljina – Sarajevo | 16:42   | 19:04   |\n+-------------+---------------------+---------+---------+\n| 721         | Sarajevo – Čapljina | 16:49   | 19:15   |\n+-------------+---------------------+---------+---------+\n| 2400        | Konjic – Sarajevo   | 05:25   | 06:51   |\n+-------------+---------------------+---------+---------+\n| 2401        | Sarajevo – Konjic   | 15:48   | 17:14   |\n+-------------+---------------------+---------+---------+", CijenaPoKM = 1.0, Longitude = 17.191000, Latitude = 44.772182 });

            voznje.Add(new AutobuskaStanica { Id = 3, Grad = "Travnik", KratkiOpis = "Duis vestibulum elit vel neque pharetra vulputate. Quisque scelerisque nisi urna. Duis rutrum non risus in imperdiet.", Fotografija = "travnik.jpg", DugiOpis = "+-------------+---------------------+---------+---------+\n| Broj linije |       Relacija      | Polazak | Dolazak |\n+-------------+---------------------+---------+---------+\n| 720         | Čapljina – Sarajevo | 06.09   | 08:35   |\n+-------------+---------------------+---------+---------+\n| 723         | Sarajevo – Čapljina | 07:15   | 09:37   |\n+-------------+---------------------+---------+---------+\n| 722         | Čapljina – Sarajevo | 16:42   | 19:04   |\n+-------------+---------------------+---------+---------+\n| 721         | Sarajevo – Čapljina | 16:49   | 19:15   |\n+-------------+---------------------+---------+---------+\n| 2400        | Konjic – Sarajevo   | 05:25   | 06:51   |\n+-------------+---------------------+---------+---------+\n| 2401        | Sarajevo – Konjic   | 15:48   | 17:14   |\n+-------------+---------------------+---------+---------+", CijenaPoKM = 1.0, Longitude = 17.66583, Latitude = 44.22637 });

            voznje.Add(new AutobuskaStanica { Id = 4, Grad = "Sarajevo", KratkiOpis = "Duis vestibulum elit vel neque pharetra vulputate. Quisque scelerisque nisi urna. Duis rutrum non risus in imperdiet.", Fotografija = "sarajevo.jpg", DugiOpis = "+-------------+---------------------+---------+---------+\n| Broj linije |       Relacija      | Polazak | Dolazak |\n+-------------+---------------------+---------+---------+\n| 720         | Čapljina – Sarajevo | 06.09   | 08:35   |\n+-------------+---------------------+---------+---------+\n| 723         | Sarajevo – Čapljina | 07:15   | 09:37   |\n+-------------+---------------------+---------+---------+\n| 722         | Čapljina – Sarajevo | 16:42   | 19:04   |\n+-------------+---------------------+---------+---------+\n| 721         | Sarajevo – Čapljina | 16:49   | 19:15   |\n+-------------+---------------------+---------+---------+\n| 2400        | Konjic – Sarajevo   | 05:25   | 06:51   |\n+-------------+---------------------+---------+---------+\n| 2401        | Sarajevo – Konjic   | 15:48   | 17:14   |\n+-------------+---------------------+---------+---------+", CijenaPoKM = 1.0, Longitude = 18.413029, Latitude = 43.856430 });

            voznje.Add(new AutobuskaStanica { Id = 5, Grad = "Bihać", KratkiOpis = "Duis vestibulum elit vel neque pharetra vulputate. Quisque scelerisque nisi urna. Duis rutrum non risus in imperdiet.", Fotografija = "bihac.jpg", DugiOpis = "+-------------+---------------------+---------+---------+\n| Broj linije |       Relacija      | Polazak | Dolazak |\n+-------------+---------------------+---------+---------+\n| 720         | Čapljina – Sarajevo | 06.09   | 08:35   |\n+-------------+---------------------+---------+---------+\n| 723         | Sarajevo – Čapljina | 07:15   | 09:37   |\n+-------------+---------------------+---------+---------+\n| 722         | Čapljina – Sarajevo | 16:42   | 19:04   |\n+-------------+---------------------+---------+---------+\n| 721         | Sarajevo – Čapljina | 16:49   | 19:15   |\n+-------------+---------------------+---------+---------+\n| 2400        | Konjic – Sarajevo   | 05:25   | 06:51   |\n+-------------+---------------------+---------+---------+\n| 2401        | Sarajevo – Konjic   | 15:48   | 17:14   |\n+-------------+---------------------+---------+---------+", CijenaPoKM = 1.0, Longitude = 15.868565, Latitude = 44.811962 });

            BindingContext = this;
        }

        private async void ListView_ItemTapped_1(object sender, ItemTappedEventArgs e)
        {
            var myListView = (ListView)sender;
            var odabranaRuta = (AutobuskaStanica)myListView.SelectedItem;
            var BrOdraslih = int.Parse(odrasli.Text);
            var BrDjece = int.Parse(djeca.Text);
            var Brpenzionera = int.Parse(penzioneri.Text);
            await Navigation.PushModalAsync(new CijenaVoznje(registrovanikorisnik, odabranaRuta, BrOdraslih, BrDjece, Brpenzionera));
        }
    }
}