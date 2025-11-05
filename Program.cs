using System;

namespace Posiciones
{
    internal class Program //POSICIONEWS
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            int[] valorNumero = new int[4] { 10, 20, 30, 40 };
            int pos, nuevoNum;
            Console.WriteLine("Número de posiciones actuales: " + valorNumero.Length);
            for (int i = 0; i < valorNumero.Length; i++)
            {
                Console.WriteLine(valorNumero[i]);
            }

            Console.WriteLine("Ingrese posición: ");
            pos=int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nuevo número: ");
            nuevoNum = int.Parse(Console.ReadLine());

            //cambuiar de tamaño al arreglo
            Array.Resize(ref valorNumero, valorNumero.Length+1);
            //valorNumero[4] = valorNumero[3];
            //valorNumero[3] = valorNumero[2];
            //valorNumero[2] = valorNumero[1];
            //valorNumero[1] = nuevoNum;
            //Pero es muy engorroso


            //Pasamos los num a la derecha
            for (int i=(valorNumero.Length-1); i>0; i--)
            {
                if (i == pos - 1)
                {
                    valorNumero[i]=nuevoNum;
                    break;
                }
                else
                {
                    valorNumero[i] = valorNumero[i - 1];
                }
             
            }
            

            for (int i = 0; i < valorNumero.Length; i++)
            {
                Console.WriteLine($"Índice {i}: {valorNumero[i]}");
            }
            Console.WriteLine("Número de posiciones nuevas: "+valorNumero.Length);


            //se usa una estructura repetitiva (no foreach porque tiene probelmas al disminuir)
            //En cambio se puede usar 'for'

            Console.ResetColor();
        }
    }
}

