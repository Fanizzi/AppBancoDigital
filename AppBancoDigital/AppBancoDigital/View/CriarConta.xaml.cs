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

        private async void btn_enviar_Clicked(object sender, EventArgs e)
        {
            string[] cpf_pontuado = user_cpf.Text.Split('.', '-');
            string cpf_digitado = cpf_pontuado[0] + cpf_pontuado[1] + cpf_pontuado[2] + cpf_pontuado[3];

            act_carregando.IsRunning = true;
            act_carregando.IsVisible = true;

            try
            {
                Model.Correntista c = await DataServiceCorrentista.SaveAsync(new Model.Correntista
                {
                    Nome = user_name.Text,
                    Cpf = cpf_digitado,
                    Data_nasc = user_dataNasc.Date.ToString("yyyy-MM-dd"),
                    Senha = user_password.Text,
                });

                if (c.Id != null)
                {
                    /**
                     * Vá no arquivo App.xaml.cs e veja que declarei uma propriedade chamada
                     * DadosCorrentista, que irá armazenar os dados do correntista após o cadastro ou
                     * login, enquanto ele estiver usando o App.
                     */
                    App.Correntista = c;

                    /**
                     * Navegando para a Tela Inicial após cadastrar e definir os dados do Correntista.
                     */
                    await Navigation.PushAsync(new View.Login());
                }
                else
                    throw new Exception("Ocorreu um erro ao salvar seu cadastro.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
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