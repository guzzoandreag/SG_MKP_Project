using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SG_MKP_App.Model;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace SG_MKP_App.View.frmPublicarProdutos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class frmPublicarProduto : ContentPage
    {
        public frmPublicarProduto()
        {
            InitializeComponent();
            this.Appearing += frmPublicarProduto_Appearing;
        }
        // Create do Formulario
        private void frmPublicarProduto_Appearing(object sender, EventArgs e)
        {
            //DisplayAlert("Create", "frmPublicarProduto_Appearing", "OK");
            CarregarCodigos(sender, e);
        }

        private async void CarregarCodigos(object sender, EventArgs e)
        {
            HttpClient produtoHTTP = new HttpClient();
            //string jsonProdutosAPI = await produtoHTTP.GetStringAsync("http://sg-mkp.somee.com/api/produtos");
            string jsonProdutosAPI = await produtoHTTP.GetStringAsync("http://10.20.30.104:8090/api/produtos");
            List<PRODUTO> produtosList = JsonConvert.DeserializeObject<List<PRODUTO>>(jsonProdutosAPI);

            //List<PRODUTO> produtos = new List<PRODUTO>()
            //{
            //    new PRODUTO { PRO_CODIGO = 100 , PRO_DESCRICAO = "POP IT", PRO_IMAGEM_1 = null },
            //    new PRODUTO { PRO_CODIGO = 101 , PRO_DESCRICAO = "POP IT", PRO_IMAGEM_1 = null },
            //    new PRODUTO { PRO_CODIGO = 102 , PRO_DESCRICAO = "POP IT", PRO_IMAGEM_1 = null },
            //    new PRODUTO { PRO_CODIGO = 103 , PRO_DESCRICAO = "POP IT", PRO_IMAGEM_1 = null },
            //    new PRODUTO { PRO_CODIGO = 104 , PRO_DESCRICAO = "POP IT", PRO_IMAGEM_1 = null },
            //    new PRODUTO { PRO_CODIGO = 105 , PRO_DESCRICAO = "POP IT", PRO_IMAGEM_1 = null },
            //    new PRODUTO { PRO_CODIGO = 106 , PRO_DESCRICAO = "POP IT", PRO_IMAGEM_1 = null },
            //    new PRODUTO { PRO_CODIGO = 107 , PRO_DESCRICAO = "POP IT", PRO_IMAGEM_1 = null },
            //    new PRODUTO { PRO_CODIGO = 108 , PRO_DESCRICAO = "POP IT", PRO_IMAGEM_1 = null }
            //};
            ListaProdutos.ItemsSource = produtosList;
            //DisplayAlert("CarregarCodigos", "Appearing_CarregarCodigos", "OK");
        }

        private void ButtonPublicarProdutos_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Publicação", "Produtos selecionados publicados com Sucesso !!", "OK");
            App.Current.MainPage = new frmMainMenu();
        }
    }
}