using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquidacionDeSueldo
{
    class Condicion
    {
        public  double condicionSistemaSalud(double datomenu, double TotalMomentaneo)
        {
            double resultado = 0;

            if (datomenu == 1)
            {
                resultado = (TotalMomentaneo * 7 / 100 * (-1)) - TotalMomentaneo;

            }
            else if (datomenu == 2)
            {
                resultado = TotalMomentaneo - 24000;
            }
            return resultado;
        } 
    }
}
