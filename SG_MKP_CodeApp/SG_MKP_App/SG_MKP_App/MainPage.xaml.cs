using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using Newtonsoft.Json;
using SG_MKP_App.Model;

namespace SG_MKP_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LabelEsqueceuSenha_Clicked();
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

        private void ButtonEntrar_Clicked(object sender, EventArgs e)
        {

        }
    }
}
