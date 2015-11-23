using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Enlace_de_Datos
{
    public class MyCommand : ICommand
    {
        Action action;
        // Action es un delegado 
        public MyCommand(Action paction)
        {
            action = paction;
        }
        bool ICommand.CanExecute(object parameter)
        {
            return true;
        }

        event EventHandler ICommand.CanExecuteChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        void ICommand.Execute(object parameter)
        {
            action();
        }
    }
}
