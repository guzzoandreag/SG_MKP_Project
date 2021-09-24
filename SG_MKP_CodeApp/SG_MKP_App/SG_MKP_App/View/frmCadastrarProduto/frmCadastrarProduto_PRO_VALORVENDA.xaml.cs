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
    public partial class frmCadastrarProduto_PRO_VALORVENDA : ContentPage
    {
        public frmCadastrarProduto_PRO_VALORVENDA()
        {
            InitializeComponent();
        }

        private void EntryPRO_VALORVENDA_Focused(object sender, FocusEventArgs e)
        {
            EntryPRO_VALORVENDA.Text = "";
        }
    }
}