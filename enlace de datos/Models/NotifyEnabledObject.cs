using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Enlace_de_Datos
{
    /*
     * La interfaz INotifyPropertyChanged tiene que implementarse para que se pueda usar el mode one way o two way 
     * lo mejor es tener una clase base que implemente la interfaz y las hijas hereden de ésta como en este caso
     */
    public class NotifyEnabledObject : INotifyPropertyChanged
    {
        // el [CallerMemberName] permite saber desde que propiedad se le está llamando
        protected virtual void OnPropertyChanged([CallerMemberName]string pPropertyName = null)
        {
            if(PropertyChanged != null)
            {
                // PropertyChangedEventArgs recibe el nombre de la propiedad que está siendo cambiada
                PropertyChanged(this, new PropertyChangedEventArgs(pPropertyName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged; // est lo tenemos que disparar cuando haya ocurrido un cambio
    }
}
