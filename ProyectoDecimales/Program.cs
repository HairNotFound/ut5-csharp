using System.Globalization;

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

    // Lee un número con decimales. Acepta coma (3,7) o punto (3.7) y lo vuelve a pedir si no es válido.
    static double LeerDecimal(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            string texto = (Console.ReadLine() ?? "").Trim().Replace(',', '.');
            if (double.TryParse(texto, NumberStyles.Float, CultureInfo.InvariantCulture, out double numero))
                return numero;
            Console.WriteLine("Eso no es un número válido, inténtalo de nuevo.");
        }
    }

    // Redondear al alza: sube al entero de arriba. 3,2 -> 4 y -3,7 -> -3
    static void RedondearAlAlza()
    {
        double x = LeerDecimal("Escribe un número con decimales: ");
        double resultado = Math.Ceiling(x);
        Console.WriteLine($"{x} redondeado al alza es {resultado}");
    }

    // Eliminar los decimales: corta lo de después de la coma, sin redondear. 3,9 -> 3 y -3,7 -> -3
    static void EliminarDecimales()
    {
        double x = LeerDecimal("Escribe un número con decimales: ");
        double resultado = Math.Truncate(x);
        Console.WriteLine($"{x} sin decimales es {resultado}");
    }

    // TODO: Ecuación de segundo grado
    static void EcuacionSegundoGrado()
    {
        Console.WriteLine("Pendiente de implementar.");
    }
}
