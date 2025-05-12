using maui_cards;

namespace maui_cards.Views;

public partial class CollectionViewPage : ContentPage
{
    public CollectionViewPage()
    {
        InitializeComponent();

        collectionView.ItemsSource = GetCards();
    }

    private List<Card> GetCards()
    {
        // Inicializa la lista de cards con ejemplos
        return new List<Card>
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
            },
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
                NombreComun = "Tigre de Bengala",
                NombreCientifico = "Panthera tigris tigris",
                Fecha = new DateTime(2025, 5, 20),
                ImagenPath = "dotnet_bot.png",
                SyncStatus = false
            },
            new Card
            {
                NombreComun = "Quetzal",
                NombreCientifico = "Pharomachrus mocinno",
                Fecha = new DateTime(2025, 5, 25),
                ImagenPath = "dotnet_bot.png",
                SyncStatus = true
            },
            new Card
            {
                NombreComun = "Ajolote",
                NombreCientifico = "Ambystoma mexicanum",
                Fecha = new DateTime(2025, 5, 30),
                ImagenPath = "dotnet_bot.png",
                SyncStatus = true
            },
            new Card
            {
                NombreComun = "Tortuga Laúd",
                NombreCientifico = "Dermochelys coriacea",
                Fecha = new DateTime(2025, 6, 1),
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
            },
            new Card
            {
                NombreComun = "Tortuga de Carey",
                NombreCientifico = "Eretmochelys imbricata",
                Fecha = new DateTime(2025, 6, 10),
                ImagenPath = "dotnet_bot.png",
                SyncStatus = false
            },
        };
    }
}
