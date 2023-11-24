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
    public partial class PixArea : ContentPage
    {
        public PixArea()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            btnPagarQR.Source = ImageSource.FromResource("AppBancoDigital.Images.qr-code.png");
            btnPagarChave.Source = ImageSource.FromResource("AppBancoDigital.Images.pix-chave.png");
            btnPagarCopyPaste.Source = ImageSource.FromResource("AppBancoDigital.Images.pix-copyandpaste.png");
            btnVoltar.Source = ImageSource.FromResource("AppBancoDigital.Images.left-arrow.png");
            btnDuvida.Source = ImageSource.FromResource("AppBancoDigital.View.icon_duvida.png");
        }

        private void btn_PagarQR_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.MostrarQRCode());
        }

        private void btn_PagarChave_Clicked(object sender, EventArgs e)
        {
            
        }

        private void btn_PagarCopyPaste_Clicked(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AreaUsuario());
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