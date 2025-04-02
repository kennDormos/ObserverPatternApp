using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternApp.Sujeto;

namespace ObserverPatternApp.Observador
{
    // La interfaz ISubject define los métodos para adjuntar, eliminar y notificar observadores.
    public interface ISubject
    {
        void Attach(IObserver observer);  // Registra un observador
        void Detach(IObserver observer);  // Elimina un observador
        void Notify();  // Notifica a todos los observadores
    }
}
    