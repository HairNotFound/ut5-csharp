namespace ProyectoArray;

class Program
{
    static void Main()
    {
        string? opcion;
        do
        {
            Console.WriteLine();
            Console.WriteLine("===== OPERACIONES CON ARRAYS =====");
            Console.WriteLine("1. Calcular máximo");
            Console.WriteLine("2. Calcular mínimo");
            Console.WriteLine("3. Calcular la mediana");
            Console.WriteLine("4. Calcular la media");
            Console.WriteLine("5. Ordenar de menor a mayor");
            Console.WriteLine("6. Calcular la desviación típica");
            Console.WriteLine("7. Binarizar en base a un número n");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                    case "1": CalcularMaximo(); break;
                    case "2": CalcularMinimo(); break;
                    case "3": CalcularMediana(); break;
                    case "4": CalcularMedia(); break;
                    case "5": OrdenarArray(); break;
                    case "6": CalcularDesviacionTipica(); break;
                    case "7": BinarizarArray(); break;
                    case "0": Console.WriteLine("¡Hasta luego!"); break;
                    default: Console.WriteLine("Opción no válida."); break;
            }
        } while (opcion != "0");
    }

    // Pide por teclado cuántos números hay y los lee uno a uno
    static int[] LeerArray()
    {
        Console.Write("¿Cuántos números vas a escribir? ");
        int cantidad = int.Parse(Console.ReadLine()!);
        int[] numeros = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine()!);
        }
        return numeros;
    }

    // TODO: Calcular máximo
    static void CalcularMaximo()
    {
        Console.WriteLine("Pendiente de implementar.");
    }

    // TODO: Calcular mínimo
    static void CalcularMinimo()
    {
        Console.WriteLine("Pendiente de implementar.");
    }

    // TODO: Calcular la mediana
    static void CalcularMediana()
    {
        Console.WriteLine("Pendiente de implementar.");
    }

    // TODO: Calcular la media
    static void CalcularMedia()
    {
        Console.WriteLine("Pendiente de implementar.");
    }

    // TODO: Ordenar de menor a mayor
    static void OrdenarArray()
    {
        Console.WriteLine("Pendiente de implementar.");
    }

    // TODO: Calcular la desviación típica
    static void CalcularDesviacionTipica()
    {
        Console.WriteLine("Pendiente de implementar.");
    }

    // TODO: Binarizar en base a un número n
    static void BinarizarArray()
    {
        Console.WriteLine("Pendiente de implementar.");
    }
}
