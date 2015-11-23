using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Enlace_de_Datos
{
    
    public class CountryToColorConverter : IValueConverter
    {
        /*
     * permite cambiar el color de un text según un valor que se ele nvié
     * 
     */
        object IValueConverter.Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
 	        // value valor de enlace de datos del objeto fuente a color destino
            if (value == null)
            {
                return null;
            }
            else 
            {
                var country = value.ToString().ToLower();

                SolidColorBrush ColorResultado = new SolidColorBrush(Colors.White);

                switch(country)
                {

                    case "uruguay":
                    case "argentina":
                        ColorResultado = new SolidColorBrush(Colors.Blue);
                        break;

                    case "méxico":
                        ColorResultado = new SolidColorBrush(Colors.Green);
                        break;

                    case "venezuela":
                        ColorResultado = new SolidColorBrush(Colors.Yellow);
                        break;
                }

                return ColorResultado;
            }
            
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
 	        throw new NotImplementedException();
        }

    }
}
