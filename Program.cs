using System;


namespace SEM14_JP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom1, nom2;
            while (true)
            {
                Console.Write("Ingrese el primer nombre: ");
                nom1 = Console.ReadLine().Trim();
                if (!string.IsNullOrWhiteSpace(nom1)) break;
                else Console.WriteLine("No se permiten espacios en blanco.\n");


            }

            while (true)
            {
                Console.Write("Ingrese el segundo nombre: ");
                nom2 = Console.ReadLine().Trim();
                if (!string.IsNullOrWhiteSpace(nom2)) break;
                else Console.WriteLine("No se permiten espacios en blanco.\n");


            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Cantidad de cáracter nombre1: " + nom1.Length);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Cantidad de cáracter nombre2: " + nom2.Length);
            Console.ResetColor();
            Console.WriteLine("Nombre1 en mayús: " + nom1.ToUpper());
            Console.WriteLine("Nombre2 en minús: " + nom2.ToLower());



            if (nom1.CompareTo(nom2) == 0) Console.WriteLine("Nombres son iguales");
            else Console.WriteLine("Nombres no son iguales");

            if (nom1.Contains(nom2)) Console.WriteLine("Si existe 'an'");
            else Console.WriteLine("No existe 'an'");

            if (nom1.IndexOf("a") != -1) Console.WriteLine("La primera posición de 'a' es " + nom1.IndexOf("a"));
            else Console.WriteLine("No existe 'a'");

            if (nom2.LastIndexOf("a") != -1) Console.WriteLine("La última posición de 'a' es " + nom2.LastIndexOf("a"));
            else Console.WriteLine("No existe 'a'");


            Console.WriteLine("Insertando UPN al inicio: " + nom1.Insert(0, "UPN"));
            Console.WriteLine("Insertando SISTEMAS a lo último: " + nom2.Insert(nom2.Length,"SISTEMAS"));

            if (nom2.Length > 5) Console.WriteLine("Eliminando desde la quinta prosición: " + nom2.Remove(5));
            else Console.WriteLine("No hay quinta posición");

            if (nom1.Contains("a")) Console.WriteLine("Reemplazando la 'a' con '@': " + nom1.Replace("a", "@"));
            else Console.WriteLine("No existe 'a'");

            if (nom1.Contains("a"))
            {
                string[] partes = nom1.Split('a');
                for (int i = 0; i < partes.Length; i++)
                    Console.Write(partes[i] + " ->");
            }
            else Console.WriteLine("No existe 'a'");

            if (nom2.Length > 4) Console.WriteLine("Subcadena: " + nom2.Substring(4));
            else Console.WriteLine("No tiene almenos 4 carácteres");

            char[] nom=nom1.ToCharArray();
            for (int i = 0; i < nom.Length; i++)
                Console.Write(nom[i]);

            for (int i=nom.Length-1;i>=0; i--)
                Console.Write(nom[i]);

            Array.Sort(nom);
            string ordenado=new string(nom);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("\nOrdenado: " + ordenado);
            Console.ResetColor();
            Console.ReadKey();

        }
    }
}
