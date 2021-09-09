using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Persona
    {
        private string nombre;
        private string cargo;
        private int edad;
        private double sueldo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
    }
}
