using System; // Importa el espacio de nombres System, que contiene clases básicas como Console.
using MPG1; // Importa el espacio de nombres MPG1, que contiene las clases que se utilizarán en el menú.

bool exit = false; // Variable para controlar la salida del bucle while.

while (!exit) // Bucle que se ejecuta mientras exit sea false.
{
    // Muestra el menú de opciones al usuario.
    Console.WriteLine("---Seleccione una opción---");
    Console.WriteLine("1. Calculadora Básica");
    Console.WriteLine("2. Validación de Contraseña");
    Console.WriteLine("3. Número Primo");
    Console.WriteLine("4. Suma de Números Pares");
    Console.WriteLine("5. Conversión de Temperatura");
    Console.WriteLine("6. Contador de Vocales");
    Console.WriteLine("7. Cálculo de Factorial");
    Console.WriteLine("8. Juego de Adivinanza");
    Console.WriteLine("9. Paso por Referencia");
    Console.WriteLine("10. Tabla de Multiplicar");
    Console.WriteLine("0. Salir");
    Console.Write("Ingrese su opción: ");

    // Lee la opción ingresada por el usuario.
    string opcion = Console.ReadLine() ?? string.Empty;

    try
    {
        // Evalúa la opción ingresada y llama al método correspondiente.
        switch (opcion)
        {
            case "1":
                CalculadoraBasica.calculadoraBasica(); // Llama al método calculadoraBasica de la clase CalculadoraBasica.
                break;
            case "2":
                ValidacionDeContraseña.validacionContraseña(); 
                break;
            case "3":
                NumeroPrimo.numeroPrimo(); 
                break;
            case "4":
                SumaDeNumerosPares.sumaPares(); 
                break;
            case "5":
                ConversionDeTemperatura.ConversionTemperatura();
                break;
            case "6":
                ContadorDeVocales.ContadorVocales(); 
                break;
            case "7":
                CalculoDeFactorial.calculoFactorial(); 
                break;
            case "8":
                JuegoDeAdivinanza.JuegoAdivinanza();
                break;
            case "9":
                PasoReferencia.pasoPorReferencia(); 
                break;
            case "10":
                TablaDeMultiplicar.tablaMultiplicar(); 
                break;
            case "0":
                exit = true; // Cambia exit a true para salir del bucle while.
                break;
            default:
                Console.WriteLine("Opción no válida. Intente de nuevo."); // Muestra un mensaje si la opción ingresada no es válida.
                break;
        }
    }
    catch (Exception ex)
    {
        // Captura cualquier excepción que ocurra y muestra un mensaje de error.
        Console.WriteLine($"An error occurred: {ex.Message}");
    }

    Console.WriteLine(); // Imprime una línea en blanco para separar las iteraciones del bucle.
}