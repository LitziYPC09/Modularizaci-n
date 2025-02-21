using System;
namespace MPG1
{

class TablaDeMultiplicar
{
    public static void tablaMultiplicar()
    {
        Console.WriteLine("--- Tabla de Multiplicar ---");

        int numero = SolicitarNumero();
        int[] tabla = GenerarTablaMultiplicar(numero);

        MostrarTabla(numero, tabla);
    }

    // Función para solicitar un número entero válido al usuario
    static int SolicitarNumero()
    {
        int numero;
        Console.Write("Ingrese un número entero: ");
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Número no válido. Intente de nuevo.");
            Console.Write("Ingrese un número entero: ");
        }
        return numero;
    }

    // Función para generar la tabla de multiplicar de un número
    static int[] GenerarTablaMultiplicar(int numero)
    {
        int[] tabla = new int[10];
        for (int i = 0; i < 10; i++)
        {
            tabla[i] = numero * (i + 1);
        }
        return tabla;
    }

    // Función para mostrar la tabla de multiplicar
    static void MostrarTabla(int numero, int[] tabla)
    {
        Console.WriteLine($"\nTabla de multiplicar del {numero}:");
        for (int i = 0; i < tabla.Length; i++)
        {
            Console.WriteLine($"{numero} x {i + 1} = {tabla[i]}");
        }
    }
}
}