
using Android.Content.Res;

namespace Salitre_go
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OneButtonLogIn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new menu());
        }
        private async void OneButtonForgot(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Recuperar_contraseña());
        }
    }

}