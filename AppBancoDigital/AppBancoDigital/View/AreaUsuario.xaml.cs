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
            app_logo.Source = ImageSource.FromResource("AppBancoDigital.View.app_logo.png");
        }
    }
}