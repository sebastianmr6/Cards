using maui_cards.ViewModels;
using maui_cards;

namespace maui_cards.Views;

public partial class ListPage : ContentPage
{
    public ListPage()
    {
        InitializeComponent();
        BindingContext = new ListViewModel();
    }
    
    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        try
        {
            if (e.CurrentSelection == null || e.CurrentSelection.Count == 0)
                return;
                
            // Obtenemos el CollectionView
            var collectionView = (CollectionView)sender;
            
            // Desactivamos temporalmente el CollectionView para evitar múltiples selecciones
            collectionView.IsEnabled = false;
            
            var selectedCard = e.CurrentSelection[0] as Card;
            if (selectedCard != null)
            {
                // Usamos una operación asíncrona para no bloquear el hilo principal
                await DisplayAlert("Selección", $"Has seleccionado: {selectedCard.NombreComun}", "OK");
            }
            
            // Deseleccionar el item para permitir seleccionar de nuevo
            collectionView.SelectedItem = null;
            
            // Reactivamos el CollectionView después de procesar la selección
            collectionView.IsEnabled = true;
        }
        catch (Exception ex)
        {
            // Registramos cualquier error para diagnóstico
            Console.WriteLine($"Error en OnSelectionChanged: {ex.Message}");
        }
    }
}
