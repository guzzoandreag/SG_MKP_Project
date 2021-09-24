using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Android.Content;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SG_MKP_App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class frmCadastrarProduto_PRO_IMAGEM_1 : ContentPage
    {
        public frmCadastrarProduto_PRO_IMAGEM_1()
        {
            InitializeComponent();
        }

        private async void TirarFoto(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("Nenhuma Câmera", ":( Nenuma Câmera disponível.", "OK");
                return;
            }

            //var armazenamento = new StoreCameraMediaOptions()
            //{
            //    SaveToAlbum = true,
            //    Name = "MinhaFoto.jpg"
            //};
            //var foto = await CrossMedia.Current.TakePhotoAsync(armazenamento);

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

        private async void SelecionarImagem(object sender, EventArgs e)
        {
            if (CrossMedia.Current.IsTakePhotoSupported)
            {
                var imagem = await CrossMedia.Current.PickPhotoAsync();
                if (imagem != null)
                {
                    ImagePRO_IMAGEM_1.Source = ImageSource.FromStream(() =>
                    {
                        var stream = imagem.GetStream();
                        imagem.Dispose();
                        return stream;
                    });
                }
            }
        }

        //private async Task GetCameraPhotoAsync()
        //{
        //    var media = CrossMedia.Current;
        //
        //    var file = await media.TakePhotoAsync(new StoreCameraMediaOptions
        //    {
        //        Name = "NomeDaSuaFoto"
        //    });
        //    ImagePRO_IMAGEM_1.Source = file.Path; // Retorna o caminho da imagem.
        //}

        //private async Task GetPhotoAsync(Image PImage)
        //{
        //    var media = CrossMedia.Current;
        //
        //    var file = await media.PickPhotoAsync();
        //
        //    PImage.Source = file.Path; // Retorna o caminho da imagem.
        //}

        private void ButtonBuscarImagemGaleria_Clicked(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;
            SelecionarImagem(sender, e);
            //await GetPhotoAsync(ImagePRO_IMAGEM_1);
            (sender as Button).IsEnabled = true;
        }

        private void ButtonTirarFotoCamera_Clicked(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;
            TirarFoto(sender, e);
            //await GetCameraPhotoAsync();
            (sender as Button).IsEnabled = true;
        }
    }
}