using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipos_de_datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            decimal precio = 0.0m;
            float estatura = 0.0f;
            double promedio = 0.00;
            string nombre = "Deimer";
            bool mayorEdad = false;
            DateTime fecha = DateTime.MinValue;

            Console.WriteLine("EL valor de edad es: {0} ",edad);
            Console.WriteLine("EL valor de precio es: {0:C} ",precio);
            Console.WriteLine("EL valor de estatura es: {0:F2} ", estatura);
            Console.WriteLine("EL valor de promedio es: {0:F2} ", promedio);
            Console.WriteLine("EL valor de nombre es: "+nombre);
            Console.WriteLine("EL valor de mayorEdad es: "+ mayorEdad);
            Console.WriteLine("EL valor de fecha es: "+ fecha.ToShortDateString());
            Console.ReadKey();


            


        }
    }
}
