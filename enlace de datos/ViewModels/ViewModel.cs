using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enlace_de_Datos
{
    public class ViewModel
    {
        private ObservableCollection<Persona> personas;
        

        public ObservableCollection<Persona> Personas
        {
            get
            {
                if (personas == null)
                {
                    personas = new ObservableCollection<Persona>();

                    for (int i = 0; i < 10; i++)
                    {
                        personas.Add(new Persona() { Nombre = "Persona #" + i.ToString(), Pais = Guid.NewGuid().ToString() });
                    }
                }
                return personas;
            }

            set
            {
                personas = value;
            }
        }

        private MyCommand addComand;

        public MyCommand AddCommand
        {
            get 
            { 
                if(addComand == null)
                {
                    addComand = new MyCommand(Add);
                }
                return addComand; 
            }
            set { addComand = value; }
        }

        void Add()
        {
            Personas.Add(new Persona { Nombre = "Carlos", Pais = "Costa Rica" });
        }
        

       
    }
}
