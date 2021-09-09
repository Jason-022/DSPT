using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        public List<Persona> formulario = new List<Persona>();

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Persona Empleado = new Persona();
            DateTime fechahoy = DateTime.Now;

            Empleado.Nombre = TxtNombre.Text;
            Empleado.Cargo = TxtCargo.Text;
            Empleado.Sueldo = Convert.ToDouble(TxtSueldo.Text);
            TimeSpan hoy = fechahoy - Convert.ToDateTime(TxtFecha.Text);
            Empleado.Edad = hoy.Days / 365;
            formulario.Add(Empleado);

            


            


            

            
            Data.ItemsSource = null;
            Data.ItemsSource = formulario;
            

        }

    }
}
