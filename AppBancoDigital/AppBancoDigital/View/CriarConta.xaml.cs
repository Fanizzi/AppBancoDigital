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
    public partial class CriarConta : ContentPage
    {
        public CriarConta()
        {
            InitializeComponent();
        }

        private void btn_enviar_Clicked(object sender, EventArgs e)
        {

        }
    }
}