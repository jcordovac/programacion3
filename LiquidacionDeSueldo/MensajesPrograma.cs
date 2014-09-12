using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquidacionDeSueldo
{
    class MensajesPrograma
    {
        public void MensajeInicial()
        {
            Console.Write("    Bienvenido al Calculo de su Liquidación de Sueldo    " + "\n");
        }
        public void MensajeHorasDiasHabiles()
        {
            Console.Write("Ingrese Horas Trabajadas en la Semana: ");
        }
        public void MensajeHorasFinDeSemana()
        {
            Console.Write("Ingrese Horas Trabajadas Fin De Semana: ");
        }
        public void MensajeValorHora()
        {
            Console.Write("Ingrese Valor Hora: ");
        }
        public void MensajeMes()
        {
            Console.Write("Ingrese Mes: ");
        }
        public void MensajeAño()
        {
            Console.Write("Ingrese Año: ");
        }
        public void MensajeRut()
        {
            Console.Write("Ingrese RUT: ");
        }
        public void MensajeNombre()
        {
            Console.Write("Ingrese Nombre: ");
        }
        public void MensajeApellido()
        {
            Console.Write("Ingrese Apellido: ");
        }
        public void MensajePrevision()
        {
            Console.Write("Ingrese AFP (Ej: Cumprum, Capital, etc.): ");
        }
        public void MensajeSistemaSalud()
        {
            Console.Write("Sistema De Salud (Fonasa,Isapre): ");
        }
        public void MensajeAnticipo()
        {
            Console.Write("Ingrese Anticipo Otorgado: ");
        }
        public void MensajeDescuento()
        {
            Console.Write("Ingrese Descuento: ");
        }
        public void MensajeBonos()
        {
            Console.Write("Ingrese Bono: ");
        }

        public void MenuEleccionSistemaSalud()
        {
            Console.WriteLine(" Seleccione Sistema De salud  " + "\n"
                + "1-. Fonasa " + "\n"
                + "2-. Isapre ");
        }
        public void MenuEleccionPrevision()
        {
            Console.WriteLine("Seleccione Prevension: " + "\n"
                + " 1-. Planvital " + "\n"
                + " 2-. Modelo    " + "\n"
                + " 3-. Habitat   " + "\n"
                + " 4-. Capital   " + "\n"
                + " 5-. Cumprum   " + "\n"
                + " 6-. Provida   " + "\n");
        }
    }
}
