using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
            DisplayAlert("Create", "frmPublicarProduto_Appearing", "OK");
            CarregarCodigos(sender, e);
        }

        private void CarregarCodigos(object sender, EventArgs e)
        {
            //HttpClient clienteHTTP = new HttpClient();
            //string json = await clienteHTTP.GetStringAsync("http://dell-pc:8091/api/tblClientes");
            //List<Cliente> clientePicker = JsonConvert.DeserializeObject<List<Cliente>>(json);
            //foreach (var codigo in clientePicker)
            //{
            //    CODIGO.Items.Add(codigo.cod.ToString());
            //}
            DisplayAlert("CarregarCodigos", "Appearing_CarregarCodigos", "OK");
        }
    }
}