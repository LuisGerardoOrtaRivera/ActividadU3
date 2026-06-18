using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormU3
{
    internal class ConversorDivisas
    {
        private double _tipoCambio;

        // CONSTRUCTOR: El "detalle" de inicializar el estado del objeto
        public ConversorDivisas()
        {
            _tipoCambio = 20.50;
        }

        // SOBRECARGA DE MÉTODOS: Mismo nombre, cambian los parámetros
        // Versión A: Procesa un valor de tipo entero (Int)
        public double CalcularTotal(int cantidad)
        {
            return cantidad * _tipoCambio;
        }

        // Versión B: Procesa un valor de tipo decimal (Double)
        public double CalcularTotal(double cantidad)
        {
            return cantidad * _tipoCambio;
        }
    }
}
