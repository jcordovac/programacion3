using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquidacionDeSueldo
{
    class Program
    {
        
        public static double restaCapital;
        public static double restaCuprum;
        public static double restaHabitad;
        public static double restaPlanVital;
        public static double restaProvida;
        public static double restaModelo;
        public static double Mes1;
        public static double SueldoMes;
        public static string nombre;
        public static string apellido;
        public static int rut;
        public static int meses;
        public static int años;
       
        
        static void Main(string[] args)
        {
            try
            {   

                MensajeInicial();
                IngresoDatos();
                MostrarSueldoMensual();
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("NO se puede Dividir por cero");
                
            }
            catch (System.FormatException)
            {
                Console.WriteLine("NO puede ingresar Letras ni Caracteres");
            }
            

            Console.ReadKey();
        }

      
        public static void MensajeInicial() 
        {
            Console.Write("    Bienvenido al Calculo de su Liquidación de Sueldo    "+"\n");
        }
        public static void MensajeHorasDiasHabiles() 
        {
            Console.Write("Ingrese Horas Trabajadas en la Semana : "); 
        }
        public static void MensajeHorasFinDeSemana() 
        {
            Console.Write("Ingrese Horas Trabajadas Fin De Semana : ");
        }
        public static void MensajeValorHora() 
        {
            Console.Write("Ingrese Valor Hora : ");
        }
        public static void MensajeMes() 
        {
            Console.Write("Ingrese Mes : ");
        }
        public static void MensajeAño()
        {
            Console.Write("Ingrese Año : ");
        }
        public static void MensajeRut()
        {
            Console.Write("Ingrese RUT : ");
        }
        public static void MensajeNombre()
        {
            Console.Write("Ingrese Nombre : ");
        }
        public static void MensajeApellido()
        {
            Console.Write("Ingrese Apellido : ");
        }
        public static void MensajePrevision() 
        {
            Console.Write("Ingrese AFP (Ej: Cumprum, Capital, etc.) : ");
        }
        public static void MensajeSistemaSalud()
        {
            Console.Write("Sistema De Salud (Fonasa,Isapre) : ");
        }
        public static void MensajeAnticipo() 
        {
            Console.Write("Ingrese Anticipo Otorgado : ");
        }
        public static void MensajeDescuento() 
        {
            Console.Write("Ingrese Descuento :");
        }
        public static void MensajeBonos() 
        {
            Console.Write("Ingrese Bono :");
        }

        public static void MenuEleccionSistemaSalud()
        {
            Console.WriteLine(" Seleccione Sistema De salud  " + "\n"
                + "1-. Fonasa " + "\n"
                + "2-. Isapre ");
        }
        public static void MenuEleccionPrevision() 
        {
            Console.WriteLine("Seleccione su Prevension: "+"\n"
                + " 1-. Planvital " + "\n"
                + " 2-. Modelo    " + "\n"
                + " 3-. Habitat   " + "\n"
                + " 4-. Capital   " + "\n"
                + " 5-. Cumprum   " + "\n"
                + " 6-. Provida   " + "\n");
        }



        public static int calculoFinDeSemanas(int HorasFinDe, int totalsemana, int valorHora)
        {
            int Incremento = 0;
            Incremento = (HorasFinDe * 50 / 100 + HorasFinDe) * valorHora + totalsemana;
            return Incremento;
        }

        public static int CalculoBono(int bono, int total)
        {
            int suma = 0;
            suma = bono + total;
            return suma;
        }

        public static int CapturaEnteros()
        {
            int entero = 0;
            entero = Convert.ToInt32(Console.ReadLine());
            return entero;
        }

        public static string CapturaLetrasCaracteres()
        {
            string palabras;
            palabras = Console.ReadLine();
            return palabras;
        }

        public static double CapturaDecimales()
        {
            double decimales = 0;
            decimales = Convert.ToDouble(Console.ReadLine());
            return decimales;
        }

        public static int CalculoDiasHabiles(int ValorHora,int HorasdiasHabiles)
        {
            int total = 0;
            total = ValorHora * HorasdiasHabiles;
            return total;
        }

        
        public static int CalculoAnticipo(int anticipo, int total) 
        {
          int Descuento = 0 ;
          Descuento =   total - anticipo ;
          return Descuento;
        }

        public static int CalculoDescuentos(int Descuento,int total) 
        {
            int restaSueldo = 0;
            restaSueldo =  Descuento - total ;
            return restaSueldo;
        }
        
        public static double calculoPrevicionCapital(double sueldo) 
        { 
            double resta =0;

            resta = (sueldo * 11.44 / 100) - sueldo;

            return resta;
        
        }

        public static double calculoPrevicionCuprum(double sueldo)
        {
            double resta = 0;

            resta = (sueldo * 11.48 / 100) - sueldo;

            return resta;

        }

        public static double condicionSistemaSalud(double datomenu, double TotalMomentaneo)
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

        public static double calculoPrevicionHabitat(double sueldo)
        {
            double resta = 0;

            resta = (sueldo * 11.27 / 100) - sueldo;

            return resta;

        }

        public static double calculoPrevicionPlanVital(double sueldo)
        {
            double resta = 0;

            resta = (sueldo * 12.36 / 100) - sueldo;

            return resta;

        }

        public static double calculoPrevicionProvida(double sueldo)
        {
            double resta = 0;

            resta = (Mes1 * 11.54 / 100) - Mes1;

            return resta;

        }

        public static double calculoPrevicionModelo(double sueldo)
        {
            double resta = 0;

            resta = (Mes1 * 10.77 / 100) - Mes1;

            return resta;

        }
        
        
     
        public static void CondicionMes(int Mes) 
        {
            if (Mes >=1 && Mes <=12)
            {
                //terminar de hacer 
            }
        }



        public static void  IngresoDatos() 
        {
            
            MensajeNombre();
            nombre = CapturaLetrasCaracteres();
            MensajeApellido();
            apellido = CapturaLetrasCaracteres();
            MensajeRut();
            rut = CapturaEnteros();
            MensajeMes();
            meses = CapturaEnteros();
            MensajeAño();
            años = CapturaEnteros();
            Mes1 = calculosCapturasSueldo();
            MenuEleccionPrevision();
            int prevision = CapturaEnteros();
            EleccionPrevision(prevision);
            System.Console.Clear();
            
            

            

            //MensajeHorasDiasHabiles();
            //int diasHabiles = CapturaEnteros();
            //MensajeHorasFinDeSemana();
            //int FinDeSemana = CapturaEnteros();
            //MensajeValorHora();
            //int ValorHora = CapturaEnteros();
            //MensajeBonos();
            //int bonos = CapturaEnteros();
            //MensajeDescuento();
            //int descuento = CapturaEnteros();
            //MensajeAnticipo();
            //int anticipo = CapturaEnteros();




            //int total = CalculoDiasHabiles(ValorHora, diasHabiles);
            //int totalFinde = calculoFinDeSemanas(total);
            //int resto = CalculoAnticipo(totalFinde, anticipo);
            //int totalbono = CalculoBono(bonos, resto);
            //int descuentomes = CalculoDescuentos(descuento, totalbono);

            //return descuentomes;
        }
        public static double calculosCapturasSueldo() 
        {
          //  double p;
         //double.TryParse(CapturaEnteros().ToString(), out p);
           
            MensajeHorasDiasHabiles();
            int diasHabiles = CapturaEnteros();
            MensajeHorasFinDeSemana();
            int FinDeSemana = CapturaEnteros();
            MensajeValorHora();
            int ValorHora = CapturaEnteros();
            MensajeBonos();
            int bonos = CapturaEnteros();
            MensajeDescuento();
            int descuento = CapturaEnteros();
            MensajeAnticipo();
            int anticipo = CapturaEnteros();
            
            //entrea de valroes a sus funciones.

            int totalDiasHabiles = CalculoDiasHabiles(ValorHora, diasHabiles);
            int totalFinde = calculoFinDeSemanas(FinDeSemana,totalDiasHabiles ,ValorHora);
            int resto = CalculoAnticipo(totalFinde, anticipo);
            int totalbono = CalculoBono(bonos, resto);
            int descuentomes = CalculoDescuentos(descuento, totalbono);
            

            return descuentomes;
        }

        public static void MostrarSueldoMensual() 
        {
            Console.WriteLine("                       Liquidación de Sueldo                          "+"\n"+"\n");
            Console.WriteLine("            Datos Personales               ");
            Console.WriteLine("Nombre       = ............." + nombre + "\n"
                             +"Apellido     = ............." + apellido + "\n"
                             +"RUT          = ............." + rut     + "\n"
                             +"Fecha        = ............." + meses+"/"+años + "\n"
                             +"Sueldo Total = .........." + SueldoMes 
                             );
            Console.WriteLine("                 Descuentos y Haberes             ");
        }
       
        public static void EleccionPrevision(int Eleccion )
        {
           
                switch (Eleccion)
                {
                    case 1://Prevencion Capital
                   
                        restaCapital = calculoPrevicionCapital(Mes1);
                        MenuEleccionSistemaSalud();
                        int SistemaSalud = CapturaEnteros();
                        SueldoMes = condicionSistemaSalud(SistemaSalud, restaCapital);
                        //Console.WriteLine("su sueldo es " + SueldoMes);

                        break;
                    case 2://Prevencion Modelo
                        
                        restaModelo = calculoPrevicionModelo(Mes1);
                        MenuEleccionSistemaSalud();
                        int OpcionSistemaSalud6 = CapturaEnteros();
                        SueldoMes = condicionSistemaSalud(OpcionSistemaSalud6, restaModelo);
                      
                        //Console.WriteLine("su sueldo es " + SueldoMes);

                        break;
                    case 3:  //Prevencion Habitat
                        
                        restaHabitad = calculoPrevicionHabitat(Mes1);
                        MenuEleccionSistemaSalud();
                        int OpcionSistemaSalud3 = CapturaEnteros();
                        SueldoMes = condicionSistemaSalud(OpcionSistemaSalud3, restaHabitad);
                        //Console.WriteLine("su sueldo es " + SueldoMes);
                        break;

                    case 4:  //Prevension Plan Vital
                        
                        restaPlanVital = calculoPrevicionPlanVital(Mes1);
                        MenuEleccionSistemaSalud();
                        int OpcionSistemaSalud4 = CapturaEnteros();
                        SueldoMes = condicionSistemaSalud(OpcionSistemaSalud4, restaPlanVital);
                  
                        //Console.WriteLine("su sueldo es " + SueldoMes);
                        break;
                    case 5:   //Prevension Cuprum
                        
                        restaCuprum = calculoPrevicionCuprum(Mes1);
                        MenuEleccionSistemaSalud();
                        int SistemaSalud2 = CapturaEnteros();
                        SueldoMes = condicionSistemaSalud(SistemaSalud2, restaCapital);
                   
                        //Console.WriteLine("su sueldo es " + SueldoMes);
                        break;
                    case 6:    //Prevencion Provida
                
                        restaProvida = calculoPrevicionProvida(Mes1);
                        MenuEleccionSistemaSalud();
                        int OpcionSistemaSalud5 = CapturaEnteros();
                        SueldoMes = condicionSistemaSalud(OpcionSistemaSalud5, restaProvida);
                    
                        //Console.WriteLine("su sueldo es " + SueldoMes);
                        break;

                    default:
                        Console.WriteLine("ingrese una opcion correcta");
                        break;
                }
            
        }

    }
}
