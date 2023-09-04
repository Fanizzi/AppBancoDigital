using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        private void btnPix_Clicked(object sender, EventArgs e)-
        {

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
    }
}