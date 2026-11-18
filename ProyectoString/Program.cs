namespace ProyectoString;

class Program
{
    static void Main()
    {
        string? opcion;
        do
        {
            Console.WriteLine();
            Console.WriteLine("===== OPERACIONES CON STRINGS =====");
            Console.WriteLine("1. ¿Es palíndromo?");
            Console.WriteLine("2. Todo en mayúsculas y en minúsculas");
            Console.WriteLine("3. Número de ocurrencias de una letra");
            Console.WriteLine("4. Repetir dos strings N veces");
            Console.WriteLine("5. Duplicar cada letra (NBA -> NNBBAA)");
            Console.WriteLine("6. Borrar del primero las apariciones del segundo");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                    case "1": EsPalindromo(); break;
                    case "2": MayusculasMinusculas(); break;
                    case "3": ContarOcurrencias(); break;
                    case "4": RepetirDosStrings(); break;
                    case "5": DuplicarLetras(); break;
                    case "6": BorrarApariciones(); break;
                    case "0": Console.WriteLine("¡Hasta luego!"); break;
                    default: Console.WriteLine("Opción no válida."); break;
            }
        } while (opcion != "0");
    }

    // TODO: ¿Es palíndromo?
    static void EsPalindromo()
    {
        Console.WriteLine("Pendiente de implementar.");
    }

    // TODO: Todo en mayúsculas y en minúsculas
    static void MayusculasMinusculas()
    {
        Console.WriteLine("Pendiente de implementar.");
    }

    // TODO: Número de ocurrencias de una letra
    static void ContarOcurrencias()
    {
        Console.WriteLine("Pendiente de implementar.");
    }

    // TODO: Repetir dos strings N veces
    static void RepetirDosStrings()
    {
        Console.WriteLine("Pendiente de implementar.");
    }

    // TODO: Duplicar cada letra (NBA -> NNBBAA)
    static void DuplicarLetras()
    {
        Console.WriteLine("Pendiente de implementar.");
    }

    // TODO: Borrar del primero las apariciones del segundo
    static void BorrarApariciones()
    {
        Console.WriteLine("Pendiente de implementar.");
    }
}
