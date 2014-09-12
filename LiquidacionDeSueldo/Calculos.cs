using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquidacionDeSueldo
{
    class Calculos
      
    {
        MensajesPrograma m = new MensajesPrograma();
        Program p = new Program();
        int mes = 0;
        public  int calculoFinDeSemanas(int HorasFinDe, int totalsemana, int valorHora)
        {
            int Incremento = 0;
            Incremento = (HorasFinDe * 50 / 100 + HorasFinDe) * valorHora + totalsemana;
            return Incremento;
        }

        public  int CalculoBono(int bono, int total)
        {
            int suma = 0;
            suma = bono + total;
            return suma;
        }

        public  int CalculoDiasHabiles(int ValorHora, int HorasdiasHabiles)
        {
            int total = 0;
            total = ValorHora * HorasdiasHabiles;
            return total;
        }


        public  int CalculoAnticipo(int anticipo, int total)
        {
            int Descuento = 0;
            Descuento = total - anticipo;
            return Descuento;
        }

        public  int CalculoDescuentos(int Descuento, int total)
        {
            int restaSueldo = 0;
            restaSueldo = Descuento - total;
            return restaSueldo;
        }

        public  double calculoCapital(double sueldo)
        {
            double resta = 0;

            resta = (sueldo * 11.44 / 100) - sueldo;

            return resta;

        }

        public  double calculoCuprum(double sueldo)
        {
            double resta = 0;

            resta = (sueldo * 11.48 / 100) - sueldo;

            return resta;

        }
        public  double calculoHabitat(double sueldo)
        {
            double resta = 0;

            resta = (sueldo * 11.27 / 100) - sueldo;

            return resta;

        }

        public  double calculoPlanVital(double sueldo)
        {
            double resta = 0;

            resta = (sueldo * 12.36 / 100) - sueldo;

            return resta;

        }

        public  double calculoProvida(double sueldo)
        {
            double resta = 0;

            resta = (mes * 11.54 / 100) - mes;

            return resta;

        }

        public  double calculoModelo(double sueldo)
        {
            double resta = 0;

            resta = (mes * 10.77 / 100) - mes;

            return resta;

        }
        public double calculosCapturasSueldo()
        {


            m.MensajeHorasDiasHabiles();
            int diasHabiles = CapturaEnteros();
            m.MensajeHorasFinDeSemana();
            int FinDeSemana = CapturaEnteros();
            m.MensajeValorHora();
            int ValorHora = CapturaEnteros();
            m.MensajeBonos();
            int bonos = CapturaEnteros();
            m.MensajeDescuento();
            int descuento = CapturaEnteros();
            m.MensajeAnticipo();
            int anticipo = CapturaEnteros();


            int totalDiasHabiles = CalculoDiasHabiles(ValorHora, diasHabiles);
            int totalFinde = calculoFinDeSemanas(FinDeSemana, totalDiasHabiles, ValorHora);
            int resto = CalculoAnticipo(totalFinde, anticipo);
            int totalbono = CalculoBono(bonos, resto);
            int descuentomes = CalculoDescuentos(descuento, totalbono);


            return descuentomes;
        }

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
