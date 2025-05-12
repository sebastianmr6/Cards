using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace maui_cards.Converters
{
    public class ImageSourceConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is string imagePath && !string.IsNullOrWhiteSpace(imagePath))
            {
                try
                {
                    // Primero intentamos cargar la imagen desde el sistema de archivos
                    var imageSource = ImageSource.FromFile(imagePath);
                    return imageSource;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al cargar la imagen {imagePath}: {ex.Message}");
                    // En caso de error, devolvemos la imagen predeterminada
                    return "dotnet_bot.png";
                }
            }
            
            // Si no hay path o está vacío, devolvemos la imagen predeterminada
            return "dotnet_bot.png";
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            // No necesitamos conversión inversa para este caso
            throw new NotImplementedException();
        }
    }
}
