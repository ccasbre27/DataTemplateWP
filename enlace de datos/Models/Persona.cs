using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enlace_de_Datos
{
    
    public class Persona : NotifyEnabledObject
    {
        public string nombre;
        public string pais;
       

        public string Nombre
        {
            get { return nombre; }
            set 
            {
                nombre = value;
                // no recibe parámetros ya que el parámetro es [CallerMemberName], ver clase base
                OnPropertyChanged(); // se le envía el nombre de la propiedad que está siendo cambiada, este está en la clase base de la que hereda
            }
        }

       public string Pais
        {
            get { return pais; }
            set 
            { 
                pais = value;
                OnPropertyChanged();
            }
        }

       public override string ToString()
       {
           return string.Format("{0} de {1}", Nombre, Pais);
       }

                
    }
}
