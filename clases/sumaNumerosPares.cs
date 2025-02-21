using System;

namespace MPG1
{

class SumaDeNumerosPares
{
    public static void sumaPares()
    {
        Console.WriteLine("--- Suma de Números Pares ---");
        int sumaPares = CalcularSumaPares();
        Console.WriteLine($"La suma de los números pares ingresados es: {sumaPares}");
    }

    // Función para calcular la suma de los números pares ingresados por el usuario
    static int CalcularSumaPares()
    {
        int suma = 0;
        int numero;

        Console.WriteLine("Ingrese números enteros (0 para terminar):");
        while ((numero = SolicitarNumero()) != 0)
        {
            if (EsPar(numero))
            {
                suma += numero;
            }
        }
        return suma;
    }

    // Función para solicitar un número al usuario
    static int SolicitarNumero()
    {
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Número no válido. Intente de nuevo:");
        }
        return numero;
    }

    // Función para verificar si un número es par
    static bool EsPar(int numero)
    {
        return numero % 2 == 0;
    }
}
}