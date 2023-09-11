using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static decimal NotaFinal { get; private set; }

        static void Main(string[] args)
        {

            Console.WriteLine("\n*****Calculadora de promedio universtario*****");

            //Solicitando al estudiante que ingrese las notas del primer computo
            Console.WriteLine("\nIngrese las notas del primer computo");
            Console.WriteLine("Ingrese la nota de laboratorio 1:");
            double Lab1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIngrese la nota del parcial 1:");
            double Parc1 = Convert.ToDouble(Console.ReadLine());


            //Solicitando al estudiante que ingrese las notas del segundo computo
            Console.WriteLine("\nIngrese las notas del segundo computo");
            Console.WriteLine("Ingrese la nota de laboratorio 2:");
            double Lab2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIngrese la nota del parcial 2:");
            double Parc2 = Convert.ToDouble(Console.ReadLine());


            //Solicitando al estudiante que ingrese las notas del tercer computo
            Console.WriteLine("\nIngrese las notas del tercer computo");
            Console.WriteLine("Ingrese la nota de laboratorio 3:");
            double Lab3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIngrese la nota del parcial 3:");
            double Parc3 = Convert.ToDouble(Console.ReadLine());

            //Calcular el promedio
            double promedioLab = (Lab1 + Lab2 + Lab3) * 0.60;
            double promedioParc = (Parc1 + Parc2 + Parc3) * 0.4;
            double notaFinal = (promedioLab / 3) + (promedioParc /3);


            Console.WriteLine("\nSu nota  final fue: " + Math.Round(NotaFinal, 1));

            // Comparacion de la nota  final
            if (NotaFinal >= 7)
            {
                Console.WriteLine("\nUsted paso la materia con exelente nota.\n");
            }

            else if (NotaFinal >= 6)
            {
                Console.WriteLine("\nUsted paso la materia con baja nota\n");
            }

            else
            {
                Console.WriteLine("\nUusted saco una nota menor que 6, reprobo la materia\n");
            } 

            Console.ReadKey();
        }
    }
}

