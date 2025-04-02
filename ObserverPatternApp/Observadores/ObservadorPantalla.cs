using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObserverPatternApp.Sujeto;

namespace ObserverPatternApp
{
    
        
    // Observador que actualiza un TextBox cuando cambia la temperatura.
    public class ObservadorPantalla : IObserver
    {
        private TextBox textBox;

        // Constructor que recibe el control TextBox para actualizarlo.
        public ObservadorPantalla(TextBox textBox)
        {
            this.textBox = textBox;
        }

        // Método Update que se llama cuando el sujeto cambia.
        public void Update(int temperatura)
        {
            textBox.Text = $"Temperatura: {temperatura}°C";
        }
    }

}
