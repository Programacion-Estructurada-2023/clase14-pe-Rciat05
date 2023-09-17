class Program
{
    static void Main() // Roberto Carlos Iglesias Álvarez U20230727
    {
        int opciones;
        do
        {
            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.WriteLine("\n\n************************* Eliga una opción *************************");
            Console.ResetColor();


            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("\n1. Sumar números pares hasta 75.");
            Console.ResetColor();


            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("2. Encontrar el número más grande en una lista.");
            Console.ResetColor();


            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("3. Generar tabla de multiplicar y sumar 2.");
            Console.ResetColor();

            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine("4. Salir. ");
            Console.ResetColor();


            Console.Write("\nSu opción es: ");
            
            if (int.TryParse(Console.ReadLine(), out opciones))
            {
                switch (opciones)
                {
                    case 1:
                        SumarNumerosPares();
                        break;
                    case 2:
                        EncontrarNumeroMasGrande();
                        break;
                    case 3:
                        GenerarTablaMultiplicar();
                        break;
                    case 4:
                        Console.ForegroundColor=ConsoleColor.Yellow;
                        Console.WriteLine("\nSalida con exito =)\n");
                        Console.ResetColor();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nValor no valido, por favor ingrese un numero valido.\n");
            }
        } while (opciones != 4);
    }

    static void SumarNumerosPares()
    {
        int suma = 0;
        for (int i = 2; i <= 75; i += 2)
        {
            suma += i;
        }
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("\nLa suma de los números pares hasta 75 es: " + suma);
        Console.ResetColor();
    }

    static void EncontrarNumeroMasGrande()
    {
{
    List<int> numeros = new List<int> { 5, 9, 3, 7, 12, 18, 25, 30, 42 };
    int maximo = int.MinValue;
    foreach (int numero in numeros)
    {
        if (numero > maximo)
        {
            maximo = numero;
        }
    }
    Console.ForegroundColor=ConsoleColor.Blue;
    Console.WriteLine("\nDe la lista [5, 9, 3, 7, 12, 18, 25, 30, 42] el número más grande es: " + maximo);
    Console.ResetColor();
}

    }

    static void GenerarTablaMultiplicar()
    {
        Console.ForegroundColor=ConsoleColor.Green;
        Console.Write("\nIngresa un número para generar la tabla de multiplicar:\n");
        Console.ResetColor();
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine($"\nResultado de multiplicar {n} del 1 al 12 es: ");
            for (int i = 1; i <= 12; i++)
            {
                int resultado = n * i + 2;
                Console.WriteLine($"{n} x {i} + 2 = {resultado}");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número válido.");
        }
    }
}