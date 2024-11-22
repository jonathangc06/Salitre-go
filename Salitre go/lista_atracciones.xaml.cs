using System.Collections.ObjectModel;

namespace Salitre_go;

public partial class lista_atracciones : ContentPage
{
    public ObservableCollection<Atraccion> Atracciones { get; set; }

    public lista_atracciones()
    {
        InitializeComponent();

        // datos dle listas
        Atracciones = new ObservableCollection<Atraccion>
        {
            new Atraccion("Montaña Rusa", "atraccionimagen.png", "Una montaña rusa emocionante con giros y vueltas.", "Operativa", "Montaña Rusa", "Altura mínima: 120 cm"),
            new Atraccion("Carrusel", "carrusel.png", "Un carrusel clásico para todas las edades.", "Operativa", "Familiar", "No apto para embarazadas"),
            new Atraccion("Casa del Terror", "castillo_terror.jpg", "Atracción para los más valientes, llena de sorpresas escalofriantes.", "Mantenimiento", "Terror", "Solo para mayores de 18 años")
        };

        AtraccionesList.ItemsSource = Atracciones;
    }

    private async void OnAtraccionSelected(object sender, SelectionChangedEventArgs e)
    {
        
            await Navigation.PushAsync(new atraccion_info());
        

        ((CollectionView)sender).SelectedItem = null;
    }
}

