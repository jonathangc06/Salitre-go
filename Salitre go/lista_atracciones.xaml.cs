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
            new Atraccion("Monta�a Rusa", "atraccionimagen.png", "Una monta�a rusa emocionante con giros y vueltas.", "Operativa", "Monta�a Rusa", "Altura m�nima: 120 cm"),
            new Atraccion("Carrusel", "carrusel.png", "Un carrusel cl�sico para todas las edades.", "Operativa", "Familiar", "No apto para embarazadas"),
            new Atraccion("Casa del Terror", "castillo_terror.jpg", "Atracci�n para los m�s valientes, llena de sorpresas escalofriantes.", "Mantenimiento", "Terror", "Solo para mayores de 18 a�os")
        };

        AtraccionesList.ItemsSource = Atracciones;
    }

    private async void OnAtraccionSelected(object sender, SelectionChangedEventArgs e)
    {
        
            await Navigation.PushAsync(new atraccion_info());
        

        ((CollectionView)sender).SelectedItem = null;
    }
}

