using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SG_MKP_App.View.frmCadastrarProduto;

namespace SG_MKP_App.View.frmMainMenu_MasterDetailPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class frmMainMenu_Detail : ContentPage
    {
        public frmMainMenu_Detail()
        {
            InitializeComponent();
        }

        async private void ButtonCadProduto_Clicked(object sender, EventArgs e)
        {
            //CarouselPage frmCadProduto_CarouselPage = new CarouselPage();
            //frmCadProduto_CarouselPage.Title = "Cadastro de Produto";
            //frmCadProduto_CarouselPage.Children.Add(new frmCadastrarProduto_PRO_DESCRICAO());
            //frmCadProduto_CarouselPage.Children.Add(new frmCadastrarProduto_PRO_CATEGORIA());
            //frmCadProduto_CarouselPage.Children.Add(new frmCadastrarProduto_PRO_VALORVENDA());
            //frmCadProduto_CarouselPage.Children.Add(new frmCadastrarProduto_PRO_IMAGEM_1());
            //frmCadProduto_CarouselPage.Children.Add(new frmCadastrarProduto_PRO_IMAGEM_2());
            //frmCadProduto_CarouselPage.Children.Add(new frmCadastrarProduto_PRO_IMAGEM_3());
            //frmCadProduto_CarouselPage.Children.Add(new frmCadastrarProduto_PRO_CONDICAOPRODUTO());
            //frmCadProduto_CarouselPage.Children.Add(new frmCadastrarProduto_PRO_QUANTIDADEDISPONIVEL());
            //await Navigation.PushAsync(new frmCadProduto_CarouselPage);
            await Navigation.PushAsync(new frmCadastrarProduto_CarouselPage());
        }
    }
}