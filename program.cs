using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Menú de Opciones:");
            Console.WriteLine("1. Sumar números pares hasta 75");
            Console.WriteLine("2. Encontrar el número más grande en una lista");
            Console.WriteLine("3. Tabla de multiplicar con suma");
            Console.WriteLine("4. Salir");
            Console.Write("Ingrese su elección (1-4): ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        SumarNumerosPares();
                        break;
                    case 2:
                        EncontrarNumeroMasGrande();
                        break;
                    case 3:
                        TablaMultiplicarConSuma();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Intente nuevamente.");
            }

        } while (choice != 4);
    }

    static void SumarNumerosPares()
    {
        int suma = 0;
        for (int i = 2; i <= 75; i += 2)
        {
            suma += i;
        }
        Console.WriteLine("La suma de los números pares hasta 75 es: " + suma);
    }

    static void EncontrarNumeroMasGrande()
    {
        List<int> numeros = new List<int> { 7, 12, 4, 23, 56, 45, 9, 67, 89 };
        int max = numeros[0];

        foreach (int num in numeros)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine("El número más grande en la lista es: " + max);
    }

    static void TablaMultiplicarConSuma()
    {
        Console.Write("Ingrese un número para generar su tabla de multiplicar: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Tabla de multiplicar de " + n + " con suma:");

            for (int i = 1; i <= 12; i++)
            {
                int resultado = (n * i) + 2;
                Console.WriteLine(n + " x " + i + " = " + resultado);
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Intente nuevamente.");
        }
    }
}
