using System;

namespace MPG1
{

class NumeroPrimo
{
    public static void numeroPrimo ()
    {
        Console.WriteLine("--- Verificación de Número Primo ---");
        int numero = SolicitarNumero();

        if (EsPrimo(numero))
        {
            Console.WriteLine($"{numero} es un número primo.");
        }
        else
        {
            Console.WriteLine($"{numero} no es un número primo.");
        }
    }

    // Función para solicitar un número al usuario
    static int SolicitarNumero()
    {
        int numero;
        Console.Write("Ingrese un número entero: ");
        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1)
        {
            Console.WriteLine("Número no válido. Intente de nuevo.");
            Console.Write("Ingrese un número entero positivo: ");
        }
        return numero;
    }

    // Función para verificar si un número es primo
    static bool EsPrimo(int numero)
    {
        if (numero < 2) return false;

        //verificar si un número es primo
        for (int i = 2; i <= Math.Sqrt(numero); i++) 
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
}