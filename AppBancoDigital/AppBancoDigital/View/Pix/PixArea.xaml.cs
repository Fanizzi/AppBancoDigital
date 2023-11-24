using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            btn_PagarQR.Source = ImageSource.FromResource("AppBancoDigital.Images.qr-code.png");
            btn_PagarChave.Source = ImageSource.FromResource("AppBancoDigital.Images.pix-chave.png");
            btn_PagarCopyPaste.Source = ImageSource.FromResource("AppBancoDigital.Images.pix-copyandpaste.png");
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
    }
}