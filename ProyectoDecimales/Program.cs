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

    // Ecuación de segundo grado ax² + bx + c = 0 con x = (-b ± √d) / 2a, donde d = b² - 4ac
    static void EcuacionSegundoGrado()
    {
        double a = LeerDecimal("a: ");
        double b = LeerDecimal("b: ");
        double c = LeerDecimal("c: ");

        if (a == 0)
        {
            Console.WriteLine("No es de segundo grado (a no puede ser 0).");
            return;
        }

        double d = b * b - 4 * a * c;   // el discriminante

        if (d < 0)
        {
            // Discriminante negativo: la raíz de un número negativo no existe en los reales
            Console.WriteLine($"No tiene solución real (el discriminante es {d}, negativo).");
        }
        else if (d == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Una solución: x = {x}");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine($"Dos soluciones: x1 = {x1}, x2 = {x2}");
        }
    }
}
