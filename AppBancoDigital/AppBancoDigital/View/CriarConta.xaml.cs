using AppBancoDigital.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBancoDigital.Model;

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
            act_carregando.IsRunning = true;
            act_carregando.IsVisible = true;

            DataServiceCorrentista.Cadastrar(new Correntista()
            {
                Nome = user_name.Text,
                Senha = user_password.Text,
                CPF = user_cpf.Text,
                Data_nasc = ParseDate(user_dataNasc.Text),
            });
        }

        private void btn_voltarLogin_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Login());
        }

        private static string ParseDate(string date)
        { // 10/10/2001

            // ["10", "10", "2001"]
            string[] date_array = date.Split('/');

            // "2001-10-10"
            return string.Join("-", date_array.Reverse());
        }
    }
}