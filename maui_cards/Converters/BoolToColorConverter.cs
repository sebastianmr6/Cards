using System.Globalization;
using Microsoft.Maui.Controls;

namespace maui_cards.Converters
{
    public class BoolToColorConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is bool syncStatus)
            {
                // Si está sincronizado (true) devuelve SyncColor, de lo contrario NoSyncColor
                return syncStatus 
                    ? Application.Current?.Resources["SyncColor"] ?? Colors.Green
                    : Application.Current?.Resources["NoSyncColor"] ?? Colors.Red;
            }

            // En caso de error o valor no booleano, devuelve el color NoSyncColor
            return Application.Current?.Resources["NoSyncColor"] ?? Colors.Gray;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            // No necesitamos la conversión inversa para este caso
            throw new NotImplementedException();
        }
    }
}
