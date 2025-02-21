using System;

namespace MPG1
{
class CalculoDeFactorial
{
    public static void calculoFactorial()
    {
        Console.WriteLine("--- Cálculo de Factorial ---");

        int numero = SolicitarNumero();
        long factorial = CalcularFactorial(numero);

        MostrarResultado(numero, factorial);
    }

    // Solicita un número entero positivo al usuario
    static int SolicitarNumero()
    {
        int numero;
        do
        {
            Console.Write("Ingrese un número entero positivo: ");
        } while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0);

        return numero;
    }

    // Calcula el factorial de un número usando un ciclo for
    static long CalcularFactorial(int numero)
    {
        long resultado = 1;

        for (int i = 1; i <= numero; i++)
        {
            resultado *= i;
        }

        return resultado;
    }

    // Muestra el resultado del factorial
    static void MostrarResultado(int numero, long factorial)
    {
        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }
}
}