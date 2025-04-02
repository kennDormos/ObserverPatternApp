using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternApp.Sujeto
{
    // La interfaz IObserver define el método Update() que será llamado por el sujeto.
    public interface IObserver
    {
        void Update(int temperatura);
    }

}
