using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM13
{
    internal class Program
    {
        string[] NOMBRES = new string[0];
        byte[] EDADES = new byte[0];
        int pos = 0;

        public  int buscar(string nom)
        {
            for (int i=0; i < NOMBRES.Length; i++)
            {

                if (nom == NOMBRES[i]) return i;

            }
            return -1;



        }

        public void modificar()
        {

            Console.Write("Ingrese el nokmbre a modificar: ");
            string nom = Console.ReadLine();

            int index = buscar(nom);

            if (index == -1)
            {

                Console.Write("Ingrese el nuevo nombre: ");
                NOMBRES[index] = Console.ReadLine();
                Console.Write("Ingrese nueva edad: ");
                EDADES[index] = byte.Parse(Console.ReadLine());


            }
            else Console.WriteLine("NO EXISTE");


        }

        public void eliminar()
        {
            Console.Write("Ingrese el nombre a eliminar");
            string nom = Console.ReadLine();

            int index = buscar(nom);

            if (index == -1)
            {
                for (int i = index; i < NOMBRES.Length - 1; i++)
                {
                    NOMBRES[i] = NOMBRES[i + 1];
                    EDADES[i] = EDADES[i + 1];

                }
                Array.Resize(ref EDADES, NOMBRES.Length - 1);
                Array.Resize(ref NOMBRES, NOMBRES.Length - 1);
                pos--;

            }
            else Console.WriteLine("NO EXISTE");
        }

    }
}
