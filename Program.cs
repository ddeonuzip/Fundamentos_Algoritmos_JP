using System;


namespace proy1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ARREGLOS BIDIMENSIONAL



            //DECFLARAMOS NUESTRO ARREGLO BIDIMENSIONAL
            //tres columnas y diez filas
            string[,] arregloEstudiante1 = new string[10, 3];

            //DECLARAMOS EL ARREGLO BIDIMENSIONAL Y SUS VALORES


            string[,] arregloEstudiante2 = { { "EST01", "PEPITO", "ISC" }, { "EST02","JUANITA","NUT" }, { "EST03", "LUCHITO", "ISC" },{ "EST04", "LEO", "PSIC" }, { "EST05", "FLORCITA", "PSIC" } };

            //MOSTRAMOS E PANTALLA EL INDEX F1, INDEX C1
            //Console.WriteLine("fila 1/columna 1: " + arregloEstudiante2[1, 1]);

            Console.WriteLine("CÓDIGO   ESTUDIANTE  CARRERA");

            //RRECOREMOS TODO EL ARREGLO BIDIMENSIONAL
            for (int i = 0; i<arregloEstudiante2.GetLength(0); i++)
            {
                Console.Write("\nfila " + i);

                for (int j = 0; j < arregloEstudiante2.GetLength(1); j++)
                {
                    Console.Write(" "+arregloEstudiante2[1,j]+" ");
                }
                //HACEMOS UN SLATO DE LINEA
                Console.WriteLine();   
            }


        }
    }
}
