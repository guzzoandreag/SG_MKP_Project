using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SG_MKP_App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class frmCadastrarProduto_PRO_CONDICAOPRODUTO : ContentPage
    {
        public frmCadastrarProduto_PRO_CONDICAOPRODUTO()
        {
            InitializeComponent();
        }

        private void EntryPRO_CONDICAOPRODUTO_Focused(object sender, FocusEventArgs e)
        {
            EntryPRO_CONDICAOPRODUTO.Text = "";
        }

        private void EntryPRO_CONDICAOPRODUTO_Unfocused(object sender, FocusEventArgs e)
        {
            if (EntryPRO_CONDICAOPRODUTO.Text.Length == 0)
            {
                EntryPRO_CONDICAOPRODUTO.Text = "Ex : Novo / Semi-Novo / Usado";
            }
        }
    }
}