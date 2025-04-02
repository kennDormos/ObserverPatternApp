using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObserverPatternApp.Sujeto;

namespace ObserverPatternApp
{
    

    // Observador que actualiza un Label cuando cambia la temperatura.
    public class ObservadorLabel : IObserver
    {
        private Label label;

        // Constructor que recibe el control Label para actualizarlo.
        public ObservadorLabel(Label label)
        {
            this.label = label;
        }

        // Método Update que se llama cuando el sujeto cambia.
        public void Update(int temperatura)
        {
            label.Text = $"Temperatura actual: {temperatura}°C";
        }
    }

}
