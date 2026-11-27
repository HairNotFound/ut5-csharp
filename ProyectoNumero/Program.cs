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

    // Escribe el mensaje, lee lo que teclea el usuario y lo devuelve como número
    static long LeerEntero(string mensaje)
    {
        Console.Write(mensaje);
        return long.Parse(Console.ReadLine()!);
    }

    // ¿Es primo?
    static void EsPrimo()
    {
        long n = LeerEntero("Escribe un número: ");
        bool primo = true;
        if (n <= 1) primo = false;
        for (long d = 2; d * d <= n; d++)
        {
            if (n % d == 0)
            {
                primo = false;
            }
        }
        if (primo) Console.WriteLine($"{n} es primo");
        else Console.WriteLine($"{n} no es primo");
    }

    // Calcular el factorial
    static void CalcularFactorial()
    {
        long n = LeerEntero("Escribe un número: ");
        if (n < 0)
        {
            Console.WriteLine("No existe el factorial de un número negativo");
            return;
        }
        if (n > 20)
        {
            Console.WriteLine("El número es demasiado grande (como mucho 20)");
            return;
        }
        long resultado = 1;
        for (long i = 2; i <= n; i++)
        {
            resultado = resultado * i;
        }
        Console.WriteLine($"{n}! = {resultado}");
    }

    // Segundos a horas, minutos y segundos
    static void SegundosAHorasMinutos()
    {
        long segundos = LeerEntero("Escribe los segundos: ");
        long horas = segundos / 3600;
        long minutos = (segundos % 3600) / 60;
        long resto = segundos % 60;
        Console.WriteLine($"{horas} h, {minutos} min y {resto} s");
    }

    // Primeros 15 números de la serie de Pell
    static void SeriePell()
    {
        long antes = 0;
        long anterior = 1;
        Console.Write($"{antes}, {anterior}");
        for (int i = 0; i < 13; i++)
        {
            long siguiente = 2 * anterior + antes;
            Console.Write($", {siguiente}");
            antes = anterior;
            anterior = siguiente;
        }
        Console.WriteLine();
    }

    // ¿Es número de Armstrong?
    static void EsArmstrong()
    {
        long n = LeerEntero("Escribe un número: ");

        // Cuento las cifras sobre una copia, porque el bucle la va destruyendo
        long copia = n;
        int cifras = 0;
        do
        {
            cifras++;
            copia = copia / 10;
        } while (copia > 0);

        // Sumo cada cifra elevada al número de cifras
        double suma = 0;
        copia = n;
        while (copia > 0)
        {
            long cifra = copia % 10;
            suma = suma + Math.Pow(cifra, cifras);
            copia = copia / 10;
        }

        if (suma == n) Console.WriteLine($"{n} sí es un número de Armstrong");
        else Console.WriteLine($"{n} no es un número de Armstrong");
    }

    // ¿Tiene todos sus dígitos diferentes?
    static void DigitosDiferentes()
    {
        long n = LeerEntero("Escribe un número: ");
        string t = n.ToString();
        bool diferentes = true;
        for (int i = 0; i < t.Length; i++)
        {
            for (int j = i + 1; j < t.Length; j++)
            {
                if (t[i] == t[j])
                {
                    diferentes = false;
                }
            }
        }
        if (diferentes) Console.WriteLine($"{n} tiene todos sus dígitos diferentes");
        else Console.WriteLine($"{n} no tiene todos sus dígitos diferentes");
    }
}
