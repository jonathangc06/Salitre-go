namespace Salitre_go;

public partial class menu : ContentPage
{
    public menu()
    {
        InitializeComponent();
    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new lista_atracciones());
    }
    private async void OnButtonItinerarioClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Itinerario());
    }

    private async void OnButtonMapaClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegistrarAtraccion());
    }

    private async void OnButtonMiCuentaClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Perfil());
    }

    private async void OnButtonCarritoClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Itinerario());
    }

}

