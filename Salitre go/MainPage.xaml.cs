
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
            // Navega a la SegundaPágina
            await Navigation.PushAsync(new menu());
        }
    }

}