namespace Salitre_go;

public partial class menu : ContentPage
{
    public menu()
    {
        InitializeComponent();
    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new atraccion_info());
    }
}

