using System;
namespace MPG1

{ 

class JuegoDeAdivinanza
{
    public static void JuegoAdivinanza()
    {
        Console.WriteLine("--- Adivina el Número ---");
        JugarAdivinanza();
    }

    // Función principal del juego
    static void JugarAdivinanza()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int intento;

        Console.WriteLine("He pensado en un número entre 1 y 100. ¡Intenta adivinarlo!");

        do
        {
            intento = SolicitarNumero();
            DarPista(intento, numeroSecreto);
        } while (intento != numeroSecreto);

        Console.WriteLine("¡Felicidades! Has adivinado el número.");
    }

    // Función para solicitar un número al usuario
    static int SolicitarNumero()
    {
        int numero;
        Console.Write("Ingrese su intento: ");
        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 100)
        {
            Console.WriteLine("Número no válido. Debe estar entre 1 y 100.");
            Console.Write("Ingrese su intento: ");
        }
        return numero;
    }

    // Función para dar pistas al usuario
    static void DarPista(int intento, int numeroSecreto)
    {
        if (intento < numeroSecreto)
        {
            Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
        }
        else if (intento > numeroSecreto)
        {
            Console.WriteLine("Demasiado alto. Intenta de nuevo.");
        }
    }
}
}