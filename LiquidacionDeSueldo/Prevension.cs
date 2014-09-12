using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquidacionDeSueldo
{
    class Prevension
    {
        Calculos c = new Calculos();
        Condicion con = new Condicion();
        Capturas cap = new Capturas();
        MensajesPrograma m = new MensajesPrograma();

        public double restaCapital;
        public double restaCuprum;
        public double restaHabitad;
        public double restaPlanVital;
        public double restaProvida;
        public double restaModelo;
        public double Mes1;
        public double SueldoMes;
        public string nombre;
        public string apellido;
        public int rut;
        public int meses;
        public int años;
        public void EleccionPrevision(int Eleccion)
        {

            switch (Eleccion)
            {
                case 1://Prevencion Capital

                    restaCapital = c.calculoCapital(Mes1);
                    m.MenuEleccionSistemaSalud();
                    int SistemaSalud = cap.CapturaEnteros();
                    SueldoMes = con.condicionSistemaSalud(SistemaSalud, restaCapital);


                    break;
                case 2://Prevencion Modelo

                    restaModelo = c.calculoModelo(Mes1);
                    m.MenuEleccionSistemaSalud();
                    int OpcionSistemaSalud6 = cap.CapturaEnteros();
                    SueldoMes = con.condicionSistemaSalud(OpcionSistemaSalud6, restaModelo);



                    break;
                case 3:  //Prevencion Habitat

                    restaHabitad = c.calculoHabitat(Mes1);
                    m.MenuEleccionSistemaSalud();
                    int OpcionSistemaSalud3 = cap.CapturaEnteros();
                    SueldoMes = con.condicionSistemaSalud(OpcionSistemaSalud3, restaHabitad);

                    break;

                case 4:  //Prevension Plan Vital

                    restaPlanVital = c.calculoPlanVital(Mes1);
                    m.MenuEleccionSistemaSalud();
                    int OpcionSistemaSalud4 = cap.CapturaEnteros();
                    SueldoMes = con.condicionSistemaSalud(OpcionSistemaSalud4, restaPlanVital);

                    break;
                case 5:   //Prevension Cuprum

                    restaCuprum = c.calculoCuprum(Mes1);
                    m.MenuEleccionSistemaSalud();
                    int SistemaSalud2 = cap.CapturaEnteros();
                    SueldoMes = con.condicionSistemaSalud(SistemaSalud2, restaCapital);


                    break;
                case 6:    //Prevencion Provida

                    restaProvida = c.calculoProvida(Mes1);
                    m.MenuEleccionSistemaSalud();
                    int OpcionSistemaSalud5 = cap.CapturaEnteros();
                    SueldoMes = con.condicionSistemaSalud(OpcionSistemaSalud5, restaProvida);


                    break;

                default:
                    Console.WriteLine("ingrese una opcion correcta");
                    break;
            }
        }
    }
}
