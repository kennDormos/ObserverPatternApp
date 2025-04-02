using System;
using System.Collections.Generic;
using ObserverPatternApp.Observador;
using ObserverPatternApp.Sujeto;

// Clase que implementa ISubject y gestiona la temperatura.
public class SujetoTemperatura : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private int temperatura;

    // Cambia la temperatura y notifica a los observadores.
    public void SetTemperatura(int nuevaTemperatura)
    {
        temperatura = nuevaTemperatura;
        Notify();  // Notificar a los observadores
    }

    // Obtiene la temperatura actual.
    public int GetTemperatura()
    {
        return temperatura;
    }

    // Registra un observador.
    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    // Elimina un observador.
    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    // Notifica a todos los observadores.
    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperatura);
        }
    }
}
