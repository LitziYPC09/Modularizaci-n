using System;


namespace MPG1
{
    class PasoReferencia
    {
        public static void pasoPorReferencia()
        {
            Console.WriteLine("--- Intercambio de Valores ---");

            int num1 = SolicitarNumero("Ingrese el primer número: ");
            int num2 = SolicitarNumero("Ingrese el segundo número: ");

            Console.WriteLine($"\nValores originales: num1 = {num1}, num2 = {num2}");

            Intercambiar(ref num1, ref num2);

            Console.WriteLine($"Valores intercambiados: num1 = {num1}, num2 = {num2}");
        }

        // Función para solicitar un número entero al usuario
        static int SolicitarNumero(string mensaje)
        {
            int numero;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Número no válido. Intente de nuevo.");
                Console.Write(mensaje);
            }
            return numero;
        }

        // Función para intercambiar dos números usando parámetros por referencia
        static void Intercambiar(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
class PasoPorReferencia
{
    static void Main()
    {
        Console.WriteLine("=== Intercambio de Valores ===");

        int num1 = SolicitarNumero("Ingrese el primer número: ");
        int num2 = SolicitarNumero("Ingrese el segundo número: ");

        Console.WriteLine($"\nValores originales: num1 = {num1}, num2 = {num2}");

        Intercambiar(ref num1, ref num2);

        Console.WriteLine($"Valores intercambiados: num1 = {num1}, num2 = {num2}");
    }

    // Función para solicitar un número entero al usuario
    static int SolicitarNumero(string mensaje)
    {
        int numero;
        Console.Write(mensaje);
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Número no válido. Intente de nuevo.");
            Console.Write(mensaje);
        }
        return numero;
    }

    // Función para intercambiar dos números usando parámetros por referencia
    static void Intercambiar(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
