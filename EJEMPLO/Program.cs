using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad, contador, acumulador = 0;
            double promedio;

            for (contador = 1; contador < 26; contador++)
            {
                Console.WriteLine("Ingrese su edad: ");
                edad = int.Parse(Console.ReadLine());
                contador = contador + 1;
                acumulador = acumulador + edad;

            }
            promedio = acumulador / 26;
                Console.WriteLine("La edad promedio es: " + promedio);
          

        }
    }
}
