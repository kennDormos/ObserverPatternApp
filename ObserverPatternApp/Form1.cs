using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPatternApp
{
    public partial class Form1: Form
    {
        private SujetoTemperatura sujetoTemperatura;
        public Form1()
        {
            InitializeComponent();
            // Inicializamos el sujeto (temperatura).
            sujetoTemperatura = new SujetoTemperatura();

            // Crear los observadores y adjuntarlos al sujeto
            var observadorPantalla = new ObservadorPantalla(textBoxTemperatura);
            var observadorLabel = new ObservadorLabel(labelTemperatura);

            // Registramos los observadores en el sujeto.
            sujetoTemperatura.Attach(observadorPantalla);
            sujetoTemperatura.Attach(observadorLabel);
            textBoxTemperatura.Text = "Temperatura: 0°C";
            textBoxTemperatura.ReadOnly = true;
            labelTemperatura.Text = "Temperatura Actual: 0°C";


        }

        private void buttonCambiarTemperatura_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int nuevaTemperatura = rand.Next(-10, 40);  // Genera una temperatura aleatoria
            sujetoTemperatura.SetTemperatura(nuevaTemperatura);  // Actualizar y notificar a los observadores

        }
    }
}
