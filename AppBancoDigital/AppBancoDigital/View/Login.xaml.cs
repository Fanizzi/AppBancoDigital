using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            app_logo.Source = ImageSource.FromResource("AppBancoDigital.View.app_logo.png");
            duvida.Source = ImageSource.FromResource("AppBancoDigital.View.icon_duvida.png");
        }

        private void btn_login_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_esqueci_Clicked(object sender, EventArgs e)
        {

        }
    }
}