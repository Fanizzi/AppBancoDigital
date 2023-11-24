using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AreaUsuario : ContentPage
    {
        public AreaUsuario()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            app_logo.Source = ImageSource.FromResource("AppBancoDigital.View.app_logo.png");
            search.Source = ImageSource.FromResource("AppBancoDigital.View.searchicon.png");
            btnPix.Source = ImageSource.FromResource("AppBancoDigital.Images.icone-pix.png");
            btnMeuCartao.Source = ImageSource.FromResource("AppBancoDigital.Images.credit-card-regular.png");
            btnInvestirPoupanca.Source = ImageSource.FromResource("AppBancoDigital.Images.chart-line-solid.png");
            btnRecarga.Source = ImageSource.FromResource("AppBancoDigital.Images.mobile-screen-button-solid.png");
            btnMeuPorquinho.Source = ImageSource.FromResource("AppBancoDigital.Images.piggy-bank-solid.png");
            btnInvestir.Source = ImageSource.FromResource("AppBancoDigital.Images.bitcoin.png");
            banner.Source = ImageSource.FromResource("AppBancoDigital.Images.banner-area-usuario.jpg");
            btnEye.Source = ImageSource.FromResource("AppBancoDigital.Images.eye.png");
            btnClosedEye.Source = ImageSource.FromResource("AppBancoDigital.Images.close-eye.png");
            duvida.Source = ImageSource.FromResource("AppBancoDigital.View.icon_duvida.png");
        }

        private void btnPix_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.PixArea());
        }

        private void btnMeuCartao_Clicked(object sender, EventArgs e)
        {

        }

        private void btnInvestirPoupanca_Clicked(object sender, EventArgs e)
        {

        }

        private void btnRecarga_Clicked(object sender, EventArgs e)
        {

        }

        private void btnMeuPorquinho_Clicked(object sender, EventArgs e)
        {

        }

        private void btnInvestir_Clicked(object sender, EventArgs e)
        {

        }

        private void btnEye_Clicked(object sender, EventArgs e)
        {

        }
        private void btnVerExtrato_Clicked(object sender, EventArgs e)
        {

        }

        private void onClickHideBalance_Tapped(object sender, EventArgs e)
        {
            btnClosedEye.IsVisible = true;
            btnEye.IsVisible = false;
            


            lbl_balance.Text = "R$ ****";


        }
        private void onClickShowBalance_Tapped(object sender, EventArgs e)
        {
            btnClosedEye.IsVisible = false;
            btnEye.IsVisible = true;

            lbl_balance.Text = "R$ 1000,00";
        }

        private async void duvida_Clicked(object sender, EventArgs e)
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