using System;
namespace MPG1
{

class ContadorDeVocales
{
    public static void ContadorVocales()
    {
        Console.WriteLine("--- Contador de Vocales ---");

        string frase = SolicitarFrase();
        int cantidadVocales = ContarVocales(frase);
        
        MostrarResultado(cantidadVocales);
    }

    // Solicita una frase al usuario y valida la entrada
    static string SolicitarFrase()
    {
        string frase;
        do
        {
            Console.Write("Ingrese una frase: ");
            frase = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(frase))
            {
                Console.WriteLine("La entrada no puede estar vacía. Intente de nuevo.");
            }
        } while (string.IsNullOrEmpty(frase));

        return frase;
    }

    // Cuenta el número de vocales en una cadena de texto
    static int ContarVocales(string texto)
    {
        int contador = 0;
        texto = texto.ToLower();

        foreach (char caracter in texto)
        {
            if (EsVocal(caracter))
            {
                contador++;
            }
        }
        return contador;
    }

    // Verifica si un carácter es una vocal
    static bool EsVocal(char caracter)
    {
        return "aeiou".Contains(caracter);
    }

    // Muestra el resultado al usuario
    static void MostrarResultado(int cantidadVocales)
    {
        Console.WriteLine($"La frase ingresada contiene {cantidadVocales} vocal(es).");
    }
}
 }