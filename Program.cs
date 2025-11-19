using System;


namespace tareaJP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ingrese un número con decimales");
            //decimal cantidad=decimal.Parse(Console.ReadLine());

            //if (cantidad > 3) Console.WriteLine("Error");
            //else Console.WriteLine("Cantidad correctamente ingresada");


           
            string entrada;

            
            Console.WriteLine("Ingrese decimal");
            entrada = Console.ReadLine();

            if (entrada.Contains("."))
            {
                string[] x = entrada.Split('.');
                if (x[0].Length == 1 && x[1].Length == 2)
                {
                    Console.WriteLine("Muy bien");

                }
                else Console.WriteLine("No cumple");
            }
            else Console.Write("Tiene que ser decimal");

            Console.ReadKey();




        }
    }
}
