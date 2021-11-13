using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SG_MKP_App.Model;

using Plugin.Media;
using Plugin.Media.Abstractions;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;

namespace SG_MKP_App.View.frmCadastrarProduto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class frmCadastrarProduto_CarouselPage : CarouselPage
    {
        PRODUTO Produto;
        public frmCadastrarProduto_CarouselPage()
        {
            InitializeComponent();
            Produto = new PRODUTO();
        }

        //  -- frmCadastrarProduto_PRO_DESCRICAO --
        private void EntryPRO_DESCRICAO_Focused(object sender, FocusEventArgs e)
        {
            if (EntryPRO_DESCRICAO.Text == "Ex : BATATA FRITA 1KG")
            {
                EntryPRO_DESCRICAO.Text = "";
            }            
        }

        private void EntryPRO_DESCRICAO_Unfocused(System.Object sender, Xamarin.Forms.FocusEventArgs e)
        {
            if (EntryPRO_DESCRICAO.Text.Length == 0)
            {
                EntryPRO_DESCRICAO.Text = "Ex : BATATA FRITA 1KG";
            }
            else
            {
                Produto.PRO_DESCRICAO = EntryPRO_DESCRICAO.Text;
            }
        }

        //  -- frmCadastrarProduto_PRO_CATEGORIA --
        private void EntryPRO_CATEGORIA_Focused(object sender, FocusEventArgs e)
        {
            if (EntryPRO_CATEGORIA.Text == "Ex : ALIMENTO")
            {
                EntryPRO_CATEGORIA.Text = "";
            }
        }

        private void EntryPRO_CATEGORIA_Unfocused(object sender, FocusEventArgs e)
        {
            if (EntryPRO_CATEGORIA.Text.Length == 0)
            {
                EntryPRO_CATEGORIA.Text = "Ex : ALIMENTO";
            }
            else
            {
                Produto.PRO_CATEGORIA = EntryPRO_CATEGORIA.Text;
            }
        }

        //  -- frmCadastrarProduto_PRO_VALORVENDA --
        private void EntryPRO_VALORVENDA_Focused(object sender, FocusEventArgs e)
        {
            if (EntryPRO_VALORVENDA.Text == "Ex : 9,90")
            {
                EntryPRO_VALORVENDA.Text = "";
            }
        }

        private void EntryPRO_VALORVENDA_Unfocused(object sender, FocusEventArgs e)
        {
            if (EntryPRO_VALORVENDA.Text.Length == 0)
            {
                EntryPRO_VALORVENDA.Text = "Ex : 9,90";
            }
            else
            {
                Produto.PRO_VALORVENDA = Convert.ToDouble(EntryPRO_VALORVENDA.Text);
            }
        }

        //  -- frmCadastrarProduto_PRO_IMAGEM_1 --
        private async void PRO_IMAGEM_1TirarFoto(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("Nenhuma Câmera", ":( Nenuma Câmera disponível.", "OK");
                return;
            }

            var foto = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,
                RotateImage = true,
                AllowCropping = true,
                Name = "photo1.jpg",
                SaveToAlbum = false,
                DefaultCamera = CameraDevice.Rear,
            });

            if (foto == null)
                return;

            ImagePRO_IMAGEM_1.Source = ImageSource.FromStream(() =>
            {
                var stream = foto.GetStream();
                foto.Dispose();
                return stream;
            });
        }

        private async void PRO_IMAGEM_1SelecionarImagem(object sender, EventArgs e)
        {
            if (CrossMedia.Current.IsTakePhotoSupported)
            {
                var imagem = await CrossMedia.Current.PickPhotoAsync();
                if (imagem != null)
                {
                    ImagePRO_IMAGEM_1.Source = ImageSource.FromStream(() =>
                    {
                        var stream = imagem.GetStream();
                        return stream;
                    });
                    using (var memoryStream = new MemoryStream())
                    {
                        imagem.GetStream().CopyTo(memoryStream);
                        imagem.Dispose();
                        Produto.PRO_IMAGEM_1 = memoryStream.ToArray();
                    }
                }
                else
                {
                    Produto.PRO_IMAGEM_1 = null;
                }
            }
        }

        private void ButtonPRO_IMAGEM_1BuscarImagemGaleria_Clicked(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;
            PRO_IMAGEM_1SelecionarImagem(sender, e);
            (sender as Button).IsEnabled = true;
        }

        private void ButtonPRO_IMAGEM_1TirarFotoCamera_Clicked(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;
            PRO_IMAGEM_1TirarFoto(sender, e);
            (sender as Button).IsEnabled = true;
        }

        //  -- frmCadastrarProduto_PRO_IMAGEM_2 --
        private async void ButtonPRO_IMAGEM_2TirarFoto(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("Nenhuma Câmera", ":( Nenuma Câmera disponível.", "OK");
                return;
            }

            var foto = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,
                RotateImage = true,
                AllowCropping = true,
                Name = "photo1.jpg",
                SaveToAlbum = false,
                DefaultCamera = CameraDevice.Rear,
            });

            if (foto == null)
                return;

            ImagePRO_IMAGEM_2.Source = ImageSource.FromStream(() =>
            {
                var stream = foto.GetStream();
                foto.Dispose();
                return stream;
            });
        }

        private async void ButtonPRO_IMAGEM_2SelecionarImagem(object sender, EventArgs e)
        {
            if (CrossMedia.Current.IsTakePhotoSupported)
            {
                var imagem = await CrossMedia.Current.PickPhotoAsync();
                if (imagem != null)
                {
                    ImagePRO_IMAGEM_2.Source = ImageSource.FromStream(() =>
                    {
                        var stream = imagem.GetStream();
                        return stream;
                    });
                    using (var memoryStream = new MemoryStream())
                    {
                        imagem.GetStream().CopyTo(memoryStream);
                        imagem.Dispose();
                        Produto.PRO_IMAGEM_2 = memoryStream.ToArray();
                    }
                }
                else
                {
                    Produto.PRO_IMAGEM_2 = null;
                }
            }
        }

        private void ButtonPRO_IMAGEM_2BuscarImagemGaleria_Clicked(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;
            ButtonPRO_IMAGEM_2SelecionarImagem(sender, e);
            (sender as Button).IsEnabled = true;
        }

        private void ButtonPRO_IMAGEM_2TirarFotoCamera_Clicked(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;
            ButtonPRO_IMAGEM_2TirarFoto(sender, e);
            (sender as Button).IsEnabled = true;
        }

        //  -- frmCadastrarProduto_PRO_IMAGEM_3 --
        private async void PRO_IMAGEM_3TirarFoto(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("Nenhuma Câmera", ":( Nenuma Câmera disponível.", "OK");
                return;
            }

            var foto = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,
                RotateImage = true,
                AllowCropping = true,
                Name = "photo1.jpg",
                SaveToAlbum = false,
                DefaultCamera = CameraDevice.Rear,
            });

            if (foto == null)
                return;

            ImagePRO_IMAGEM_3.Source = ImageSource.FromStream(() =>
            {
                var stream = foto.GetStream();
                foto.Dispose();
                return stream;
            });
        }

        private async void PRO_IMAGEM_3SelecionarImagem(object sender, EventArgs e)
        {            
            if (CrossMedia.Current.IsTakePhotoSupported)
            {
                var imagem = await CrossMedia.Current.PickPhotoAsync();
                if (imagem != null)
                {
                    ImagePRO_IMAGEM_3.Source = ImageSource.FromStream(() =>
                    {
                        var stream = imagem.GetStream();
                        return stream;
                    });
                    using (var memoryStream = new MemoryStream())
                    {
                        imagem.GetStream().CopyTo(memoryStream);
                        imagem.Dispose();
                        Produto.PRO_IMAGEM_3 = memoryStream.ToArray();
                    }
                }
                else
                {
                    Produto.PRO_IMAGEM_3 = null;
                }
            }
        }

        private void ButtonPRO_IMAGEM_3BuscarImagemGaleria_Clicked(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;
            PRO_IMAGEM_3SelecionarImagem(sender, e);
            (sender as Button).IsEnabled = true;
        }

        private void ButtonPRO_IMAGEM_3TirarFotoCamera_Clicked(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;
            PRO_IMAGEM_3TirarFoto(sender, e);
            (sender as Button).IsEnabled = true;
        }

        //  -- frmCadastrarProduto_PRO_CONDICAOPRODUTO --
        private void EntryPRO_CONDICAOPRODUTO_Focused(object sender, FocusEventArgs e)
        {
            if (EntryPRO_CONDICAOPRODUTO.Text == "Ex : Novo / Semi-Novo / Usado")
            {
                EntryPRO_CONDICAOPRODUTO.Text = "";
            }
        }

        private void EntryPRO_CONDICAOPRODUTO_Unfocused(object sender, FocusEventArgs e)
        {
            if (EntryPRO_CONDICAOPRODUTO.Text.Length == 0)
            {
                EntryPRO_CONDICAOPRODUTO.Text = "Ex : Novo / Semi-Novo / Usado";
            }
            else
            {
                Produto.PRO_CONDICAOPRODUTO = EntryPRO_CONDICAOPRODUTO.Text;
            }
        }

        //  -- frmCadastrarProduto_PRO_QUANTIDADEDISPONIVEL --
        private void EntryPRO_QUANTIDADEDISPONIVEL_Focused(object sender, FocusEventArgs e)
        {
            if (EntryPRO_QUANTIDADEDISPONIVEL.Text == "Ex : 50")
            {
                EntryPRO_QUANTIDADEDISPONIVEL.Text = "";
            }
        }

        private void EntryPRO_QUANTIDADEDISPONIVEL_Unfocused(object sender, FocusEventArgs e)
        {
            if (EntryPRO_QUANTIDADEDISPONIVEL.Text.Length == 0)
            {
                EntryPRO_QUANTIDADEDISPONIVEL.Text = "Ex : 50";
            }
            else
            {
                Produto.PRO_QUANTIDADEDISPONIVEL = Convert.ToInt32(EntryPRO_QUANTIDADEDISPONIVEL.Text);
            }
        }

        async private void CadastrarProduto_Finalizar()
        {
            try
            {
                HttpClient produtoHTTP = new HttpClient();
                var jsonGravarProdutosAPI = new StringContent(JsonConvert.SerializeObject(Produto), Encoding.UTF8, "application/json");
                var response = await produtoHTTP.PostAsync("http://sg-mkp.somee.com/api/produtos", jsonGravarProdutosAPI);
                //var response = await produtoHTTP.PostAsync("http://10.20.30.104:8090/api/produtos", jsonGravarProdutosAPI);

                if (response.IsSuccessStatusCode)
                {
                    await DisplayAlert("Salvar", "Cadastro realizado com sucesso!", "OK");
                    App.Current.MainPage = new frmMainMenu();
                }
                else
                {
                    await DisplayAlert("Erro", "Falha ao realizar o cadastro!", "OK");
                }
                ButtonFinalizarCadastro.IsEnabled = true;
            }
            catch (Exception e)
            {
                ButtonFinalizarCadastro.IsEnabled = true;
                await DisplayAlert("frmCadastrarProduto_CarouselPage_CadastrarProduto_Finalizar", e.Message, "OK");
            }
        }
        //  -- frmCadastrarProduto_FinalizarCadastro --
        private void ButtonFinalizarCadastro_Clicked(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;
            CadastrarProduto_Finalizar();
        }
    }
}