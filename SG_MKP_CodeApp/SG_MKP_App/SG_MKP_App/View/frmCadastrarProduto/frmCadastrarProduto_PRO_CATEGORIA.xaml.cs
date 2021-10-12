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
    public partial class frmCadastrarProduto_PRO_CATEGORIA : ContentPage
    {
        public frmCadastrarProduto_PRO_CATEGORIA()
        {
            InitializeComponent();
        }

        private void EntryPRO_CATEGORIA_Focused(object sender, FocusEventArgs e)
        {
            EntryPRO_CATEGORIA.Text = "";
        }

        private void EntryPRO_CATEGORIA_Unfocused(object sender, FocusEventArgs e)
        {
            if (EntryPRO_CATEGORIA.Text.Length == 0)
            {
                EntryPRO_CATEGORIA.Text = "Ex : ALIMENTO";
            }
        }
    }
}