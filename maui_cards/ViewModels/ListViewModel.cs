using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace maui_cards.ViewModels
{
    public class ListViewModel
    {
        public ObservableCollection<Card> Cards { get; private set; }

        public ListViewModel()
        {
            // Inicializa la lista de cards con datos de ejemplo
            Cards = new ObservableCollection<Card>();
            
            try
            {
                LoadCards();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar las cards: {ex.Message}");
            }
        }
        
        private void LoadCards()
        {
            // Inicializa la lista de cards con ejemplos
            var cardsList = new ObservableCollection<Card>
            {
                new Card
                {
                    NombreComun = "Águila Real",
                    NombreCientifico = "Aquila chrysaetos",
                    Fecha = new DateTime(2025, 5, 1),
                    ImagenPath = "dotnet_bot.png",
                    SyncStatus = true
                },
                new Card
                {
                    NombreComun = "Jaguar",
                    NombreCientifico = "Panthera onca",
                    Fecha = new DateTime(2025, 5, 5),
                    ImagenPath = "dotnet_bot.png",
                    SyncStatus = false
                },
                new Card
                {
                    NombreComun = "Ballena Azul",
                    NombreCientifico = "Balaenoptera musculus",
                    Fecha = new DateTime(2025, 5, 10),
                    ImagenPath = "dotnet_bot.png",
                    SyncStatus = true
                }
                ,
                new Card
                {
                    NombreComun = "Lobo Mexicano",
                    NombreCientifico = "Canis lupus baileyi",
                    Fecha = new DateTime(2025, 5, 15),
                    ImagenPath = "dotnet_bot.png",
                    SyncStatus = true
                },
                new Card
                {
                    NombreComun = "Quetzal",
                    NombreCientifico = "Pharomachrus mocinno",
                    Fecha = new DateTime(2025, 5, 20),
                    ImagenPath = "dotnet_bot.png",
                    SyncStatus = false
                },
                new Card
                {
                    NombreComun = "Ajolote",
                    NombreCientifico = "Ambystoma mexicanum",
                    Fecha = new DateTime(2025, 5, 25),
                    ImagenPath = "dotnet_bot.png",
                    SyncStatus = true
                },
                new Card
                {
                    NombreComun = "Tortuga Laúd",
                    NombreCientifico = "Dermochelys coriacea",
                    Fecha = new DateTime(2025, 5, 30),
                    ImagenPath = "dotnet_bot.png",
                    SyncStatus = false
                },
                new Card
                {
                    NombreComun = "Mariposa Monarca",
                    NombreCientifico = "Danaus plexippus",
                    Fecha = new DateTime(2025, 6, 5),
                    ImagenPath = "dotnet_bot.png",
                    SyncStatus = true
                }
            };
            
            // Actualizar la colección principal en el hilo de UI
            foreach (var card in cardsList)
            {
                Cards.Add(card);
            }
        }
    }
}
