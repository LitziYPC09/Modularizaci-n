using System;

namespace MPG1
{

class ValidacionDeContraseña
{
    public static void validacionContraseña()
    {
        Console.WriteLine("--- Validación de Contraseña ---");
        string contraseñaCorrecta = "1234";
        string contraseñaIngresada;

        do
        {
            contraseñaIngresada = SolicitarContraseña();
        } 
        while (!ValidarContraseña(contraseñaIngresada, contraseñaCorrecta));

        Console.WriteLine("Acceso concedido. ¡Bienvenido!");
    }

    // Función para solicitar la contraseña al usuario
    static string SolicitarContraseña()
    {
        Console.Write("Ingrese la contraseña: ");
        return Console.ReadLine() ?? string.Empty;
    }

    // Función para validar la contraseña ingresada
    static bool ValidarContraseña(string ingresada, string correcta)
    {
        if (ingresada == correcta)
        {
            return true;
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta. Intente de nuevo.");
            return false;
        }
    }
}
}
