namespace ProyectoNumero;

class Program
{
    static void Main()
    {
        string? opcion;
        do
        {
            Console.WriteLine();
            Console.WriteLine("===== OPERACIONES CON NÚMEROS =====");
            Console.WriteLine("1. ¿Es primo?");
            Console.WriteLine("2. Calcular el factorial");
            Console.WriteLine("3. Segundos a horas, minutos y segundos");
            Console.WriteLine("4. Primeros 15 números de la serie de Pell");
            Console.WriteLine("5. ¿Es número de Armstrong?");
            Console.WriteLine("6. ¿Tiene todos sus dígitos diferentes?");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                    case "1": EsPrimo(); break;
                    case "2": CalcularFactorial(); break;
                    case "3": SegundosAHorasMinutos(); break;
                    case "4": SeriePell(); break;
                    case "5": EsArmstrong(); break;
                    case "6": DigitosDiferentes(); break;
                    case "0": Console.WriteLine("¡Hasta luego!"); break;
                    default: Console.WriteLine("Opción no válida."); break;
            }
        } while (opcion != "0");
    }

    // TODO: ¿Es primo?
    static void EsPrimo()
    {
        Console.WriteLine("Pendiente de implementar.");
    }

    // TODO: Calcular el factorial
    static void CalcularFactorial()
    {
        Console.WriteLine("Pendiente de implementar.");
    }

    // TODO: Segundos a horas, minutos y segundos
    static void SegundosAHorasMinutos()
    {
        Console.WriteLine("Pendiente de implementar.");
    }

    // TODO: Primeros 15 números de la serie de Pell
    static void SeriePell()
    {
        Console.WriteLine("Pendiente de implementar.");
    }

    // TODO: ¿Es número de Armstrong?
    static void EsArmstrong()
    {
        Console.WriteLine("Pendiente de implementar.");
    }

    // TODO: ¿Tiene todos sus dígitos diferentes?
    static void DigitosDiferentes()
    {
        Console.WriteLine("Pendiente de implementar.");
    }
}
