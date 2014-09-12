using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquidacionDeSueldo
{
    class Capturas
    {
        public  int CapturaEnteros()
        {
            int entero = 0;
            entero = Convert.ToInt32(Console.ReadLine());
            return entero;
        }

        public  string CapturaLetrasCaracteres()
        {
            string caracter;
            caracter = Console.ReadLine();
            return caracter;
        }

        public  double CapturaDecimales()
        {
            double decimales = 0;
            decimales = Convert.ToDouble(Console.ReadLine());
            return decimales;
        }
    }
}
