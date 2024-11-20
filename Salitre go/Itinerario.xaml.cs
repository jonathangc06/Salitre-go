using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Salitre_go
{
    public partial class Itinerario : ContentPage
    {
        public Itinerario()
        {
            InitializeComponent();
            BindingContext = new ItinerarioViewModel();
        }
    }

    public class ItinerarioViewModel
    {
        
        public ObservableCollection<LugarHorario> Lugares { get; set; }

        
        public ICommand AgregarLugarCommand { get; }

        public ItinerarioViewModel()
        {
            
            Lugares = new ObservableCollection<LugarHorario>
            {
                new LugarHorario { Hora = "9:00 AM", Lugar = "Parque Acuático" },
                new LugarHorario { Hora = "10:00 AM", Lugar = "Montaña Rusa Extrema" },
                new LugarHorario { Hora = "11:00 AM", Lugar = "Casa del Terror" }
            };

            
            AgregarLugarCommand = new Command(AgregarLugar);
        }

        /
        private void AgregarLugar()
        {
            Lugares.Add(new LugarHorario { Hora = "", Lugar = "" });
        }
    }

    
    public class LugarHorario
    {
        public string Hora { get; set; }
        public string Lugar { get; set; }
    }
}
