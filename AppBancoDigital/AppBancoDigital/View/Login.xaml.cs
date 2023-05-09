﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

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
            string cpf_digitado = user_login.Text;
            string senha_digitada = user_password.Text;

            string cpf_cadastrado = "123.456.789-10";
            string senha_cadastrada = "teste";

            if (cpf_digitado == cpf_cadastrado && senha_digitada == senha_cadastrada)
            {
                App.Current.Properties.Add("usuario_logado", cpf_digitado);
                App.Current.MainPage = new NavigationPage(new AreaUsuario());
            }
            else
            {
                DisplayAlert("Erro", "Dados incorretos!", "OK");
            }
           
        }

        private void btn_esqueci_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.EsqueciSenha());
        }

        private async void duvida_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Browser.OpenAsync(new Uri("https://github.com/Fanizzi"), BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                // An unexpected error occured. No browser may be installed on the device.
            }
        }

        private void btn_criarConta_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.CriarConta());
        }
    }
}