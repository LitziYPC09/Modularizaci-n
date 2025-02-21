using System;

namespace MPG1 
{

class CalculadoraBasica
{
    public static void calculadoraBasica()
    {
        // Muestra el título de la calculadora
        Console.WriteLine("--Calculadora Básica--\n");
        
        // Lee el primer número ingresado por el usuario
        double numero1 = LeerNumero("Ingrese el primer número: ");
        // Lee el segundo número ingresado por el usuario
        double numero2 = LeerNumero("Ingrese el segundo número: ");

        // Muestra las opciones de operaciones disponibles
        Console.WriteLine("\n--Seleccione una operación:--");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        
        // Lee y valida la opción ingresada por el usuario
        int opcion = LeerOpcion();
        // Realiza la operación seleccionada y obtiene el resultado
        double resultado = RealizarOperacion(opcion, numero1, numero2);

        // Muestra el resultado de la operación
        Console.WriteLine($"\nEl resultado es: {resultado}");
    }

    // Método para leer y validar un número ingresado por el usuario
    static double LeerNumero(string mensaje)
    {
        double numero;
        Console.Write(mensaje);
        while (!double.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Número no válido. Intente de nuevo.");
            Console.Write(mensaje);
        }
        return numero;
    }

    // Método para leer y validar la opción de operación ingresada por el usuario
    static int LeerOpcion()
    {
        int opcion;
        while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
        {
            Console.WriteLine("Opción no válida. Intente de nuevo.");
        }
        return opcion;
    }

    // Método para realizar la operación seleccionada
    static double RealizarOperacion(int opcion, double num1, double num2)
    {
        switch (opcion)
        {
            case 1: return Sumar(num1, num2); // Suma
            case 2: return Restar(num1, num2); // Resta
            case 3: return Multiplicar(num1, num2); // Multiplicación
            case 4: return Dividir(num1, num2); // División
            default: return 0;
        }
    }

    // Método para sumar dos números
    static double Sumar(double num1, double num2) => num1 + num2;
    // Método para restar dos números
    static double Restar(double num1, double num2) => num1 - num2;
    // Método para multiplicar dos números
    static double Multiplicar(double num1, double num2) => num1 * num2;
    // Método para dividir dos números
    static double Dividir(double num1, double num2) => num2 != 0 ? num1 / num2 : throw new DivideByZeroException("No se puede dividir por cero.");
}
}
