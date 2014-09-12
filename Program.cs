using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquidacionDeSueldo
{
    class Program 
    {
        Calculos c = new Calculos();
        Prevension p = new Prevension();
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
       
        
         void Main(string[] args)
        {
            try
            {   

                m.MensajeInicial();
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

     
        public   void  IngresoDatos() 
        {
            
            m.MensajeNombre();
            nombre = cap.CapturaLetrasCaracteres();
            m.MensajeApellido();
            apellido = cap.CapturaLetrasCaracteres();
            m.MensajeRut();
            rut = cap.CapturaEnteros();
            m.MensajeMes();
            meses = cap.CapturaEnteros();
            m.MensajeAño();
            años = cap.CapturaEnteros();
            Mes1 = c.calculosCapturasSueldo();
            m.MenuEleccionPrevision();
            int prevision = cap.CapturaEnteros();
            p.EleccionPrevision(prevision);
            System.Console.Clear();
             }
 
        public  void MostrarSueldoMensual() 
        {
         string nombre;
         string apellido;
         int rut;
         int meses;
         int sueldoMes;
         int años;
            Console.WriteLine("                       Liquidación de Sueldo                          "+"\n"+"\n");
            Console.WriteLine("            Datos Personales               ");
            Console.WriteLine("Nombre       = ............." + nombre + "\n"
                             +"Apellido     = ............." + apellido + "\n"
                             +"RUT          = ............." + rut     + "\n"
                             +"Fecha        = ............." + meses+"/"+años + "\n"
                             +"Sueldo Total = .........." + sueldoMes   
                             );
            Console.WriteLine("                 Descuentos y Haberes              ");
        }
       
      
        }   
}



