using System;

namespace MPG1
{

class ConversionDeTemperatura
{
    public static void ConversionTemperatura()
    {
        Console.WriteLine("--- Conversión de Temperatura ---");
        int opcion;
        do
        {
            MostrarMenu();
            opcion = SolicitarOpcion();
            ProcesarOpcion(opcion);
        } while (opcion != 3);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\nSeleccione una opción:");
        Console.WriteLine("1. Convertir Celsius a Fahrenheit");
        Console.WriteLine("2. Convertir Fahrenheit a Celsius");
        Console.WriteLine("3. Salir");
    }

    static int SolicitarOpcion()
    {
        int opcion;
        while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3)
        {
            Console.WriteLine("Opción no válida. Intente de nuevo.");
        }
        return opcion;
    }

    static void ProcesarOpcion(int opcion)
    {
        if (opcion == 1)
        {
            double celsius = SolicitarTemperatura("Ingrese la temperatura en Celsius: ");
            double fahrenheit = CelsiusAFahrenheit(celsius);
            Console.WriteLine($"{celsius}°C equivale a {fahrenheit}°F");
        }
        else if (opcion == 2)
        {
            double fahrenheit = SolicitarTemperatura("Ingrese la temperatura en Fahrenheit: ");
            double celsius = FahrenheitACelsius(fahrenheit);
            Console.WriteLine($"{fahrenheit}°F equivale a {celsius}°C");
        }
        else
        {
            Console.WriteLine("Saliendo del programa...");
        }
    }

    static double SolicitarTemperatura(string mensaje)
    {
        double temperatura;
        Console.Write(mensaje);
        while (!double.TryParse(Console.ReadLine(), out temperatura))
        {
            Console.WriteLine("Valor no válido. Intente de nuevo.");
            Console.Write(mensaje);
        }
        return temperatura;
    }

    static double CelsiusAFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitACelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}
}