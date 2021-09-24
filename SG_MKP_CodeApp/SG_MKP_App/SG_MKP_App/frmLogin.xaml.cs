﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using Newtonsoft.Json;
using SG_MKP_App.Model;
using System.Net.Http;
using SG_MKP_App.View;
using SG_MKP_App.View.frmMainMenu_MasterDetailPage;

namespace SG_MKP_App
{
    public partial class frmLogin : ContentPage
    {
        USUARIO usuario;
        public frmLogin()
        {
            InitializeComponent();
            LabelEsqueceuSenha_Clicked();
            usuario = new USUARIO();
        }

        private void EntrySenha_Focused(object sender, FocusEventArgs e)
        {
            if (e.IsFocused)
            {
                EntrySenha.IsPassword = true;
                EntrySenha.Text = "";
            }
        }

        private void EntryUsuario_Focused(object sender, FocusEventArgs e)
        {
            if (e.IsFocused)
            {
                EntryUsuario.Text = "";
            }
        }

        private void EntrySenha_Unfocused(object sender, FocusEventArgs e)
        {
            if (EntrySenha.Text.Length < 1)
            {
                EntrySenha.IsPassword = false;
                EntrySenha.Text = "Senha";
            }
        }

        private void EntryUsuario_Unfocused(object sender, FocusEventArgs e)
        {
            if (EntryUsuario.Text.Length < 1)
            {
                EntryUsuario.Text = "Digite Email, CPF, CNPJ, Telefone";
            }
        }

        private void ButtonCadUsuario_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Teste", "ButtonCadUsuario_Clicked", "OK");
        }

        private void LabelEsqueceuSenha_Clicked()
        {
            LabelEsqueceuSenha.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    DisplayAlert("Teste", "EsqueceuSenha_LabelEvent", "OK");
                })
            });
        }

        private void SwitchTema_Toggled(object sender, ToggledEventArgs e)
        {
            //
        }
        async private void ValidarUsuario_Entrar(string usuario, string senha)
        {
            //usuario = "guzzoandre.ag@outlook.com";
            //senha = "Ag*99345038";
            try
            {
                App.Current.MainPage = new frmMainMenu();

            //    HttpClient usuarioHTTP = new HttpClient();
            //    string json = await usuarioHTTP.GetStringAsync("http://10.20.30.107:8090/api/USUARIOS");
            //   List<USUARIO> usuario_validar = JsonConvert.DeserializeObject<List<USUARIO>>(json);
            //    foreach (var item in usuario_validar)
            //    {
            //        if (item.USU_USUARIO == usuario)
            //        {
            //            if (item.USU_SENHA == senha)
            //            {
            //                App.Current.MainPage = new frmMainMenu();
            //
            //                //await Navigation.PushModalAsync(new frmMainMenu());
            //                //DisplayAlert("Teste","Usuario: " + item.USU_USUARIO + "\n\n" + "Senha: " + item.USU_SENHA , "OK");
            //            }
            //            else
            //            {
            //                await DisplayAlert("Teste", "Senha Incorreta !.", "OK");
            //            }
            //        }
            //    }
            }
            catch (Exception e)
            {
                ButtonEntrar.IsEnabled = true;
                await DisplayAlert("frmLogin_ValidarUsuario_Entrar",e.Message, "OK");
            }
        }

        private void ButtonEntrar_Clicked(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;
            ValidarUsuario_Entrar(EntryUsuario.Text, EntrySenha.Text);
            (sender as Button).IsEnabled = true;
        }
    }
}
