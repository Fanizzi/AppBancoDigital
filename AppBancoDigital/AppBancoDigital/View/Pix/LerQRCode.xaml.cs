using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.Pix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LerQRCode : ContentPage
    {
        public LerQRCode()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            btnVoltar.Source = ImageSource.FromResource("AppBancoDigital.Images.left-arrow.png");
            btnDuvida.Source = ImageSource.FromResource("AppBancoDigital.View.icon_duvida.png");
        }

        private void btnVoltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PixArea());
        }

        private async void btnDuvida_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Browser.OpenAsync(new Uri("https://github.com/Fanizzi"), BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}