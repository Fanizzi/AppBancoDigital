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
        }

        private void btnPix_Clicked(object sender, EventArgs e)
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