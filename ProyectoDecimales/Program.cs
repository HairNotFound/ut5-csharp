namespace ProyectoDecimales;

class Program
{
    static void Main()
    {
        string? opcion;
        do
        {
            Console.WriteLine();
            Console.WriteLine("===== OPERACIONES CON DECIMALES =====");
            Console.WriteLine("1. Redondear al alza");
            Console.WriteLine("2. Eliminar los decimales");
            Console.WriteLine("3. Ecuación de segundo grado");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                    case "1": RedondearAlAlza(); break;
                    case "2": EliminarDecimales(); break;
                    case "3": EcuacionSegundoGrado(); break;
                    case "0": Console.WriteLine("¡Hasta luego!"); break;
                    default: Console.WriteLine("Opción no válida."); break;
            }
        } while (opcion != "0");
    }

    // TODO: Redondear al alza
    static void RedondearAlAlza()
    {
        Console.WriteLine("Pendiente de implementar.");
    }

    // TODO: Eliminar los decimales
    static void EliminarDecimales()
    {
        Console.WriteLine("Pendiente de implementar.");
    }

    // TODO: Ecuación de segundo grado
    static void EcuacionSegundoGrado()
    {
        Console.WriteLine("Pendiente de implementar.");
    }
}
