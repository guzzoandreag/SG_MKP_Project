using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SG_MKP_App.Model;
using SG_MKP_App.View.frmCadastrarProduto;

namespace SG_MKP_App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class frmCadastrarProduto_PRO_DESCRICAO : ContentPage
    {
        public frmCadastrarProduto_PRO_DESCRICAO()
        {
            InitializeComponent();
        }

        private void EntryPRO_DESCRICAO_Focused(object sender, FocusEventArgs e)
        {
            EntryPRO_DESCRICAO.Text = "";
        }

        private void EntryPRO_DESCRICAO_Unfocused(System.Object sender, Xamarin.Forms.FocusEventArgs e)
        {
            if (EntryPRO_DESCRICAO.Text.Length == 0)
            {
                EntryPRO_DESCRICAO.Text = "Ex: BATATA FRITA 1KG";
            }
            else
            {

            }

        }
    }
}