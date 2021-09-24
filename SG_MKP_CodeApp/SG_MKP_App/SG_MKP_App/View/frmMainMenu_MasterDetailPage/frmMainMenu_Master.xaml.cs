using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SG_MKP_App.View.frmMainMenu_MasterDetailPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class frmMainMenu_Master : ContentPage
    {
        public frmMainMenu_Master()
        {
            InitializeComponent();
        }

        private void ButtonMeusDados_Clicked(object sender, EventArgs e)
        {
            //
        }

        private void ButtonConfiguracoes_Clicked(object sender, EventArgs e)
        {
            //
        }

        private void ButtonSair_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new frmLogin();
            //Navigation.PushModalAsync(new frmLogin());
        }
    }
}