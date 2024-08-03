using ConsoleApp17;

class Program
{
    static void Main(string[] args)
    {
        List<Numeros> listaNumeros = new List<Numeros>();
        bool menu = true;
        int opcion;

        while (menu)
        {
            Console.Clear();
            Console.WriteLine("1. Ingresar números");
            Console.WriteLine("2. Mostrar números");
            Console.WriteLine("3. Sumar números");
            Console.WriteLine("4. Restar números");
            Console.WriteLine("5. Multiplicar números");
            Console.WriteLine("6. Dividir números");
            Console.WriteLine("7. Mostrar todas las operaciones");
            Console.WriteLine("8. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Numeros.IngresarNumeros(listaNumeros);
                    break;
                case 2:
                    Console.Clear();
                    Numeros.MostrarNumeros(listaNumeros);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Numeros.SumarNumeros(listaNumeros);
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Numeros.RestarNumeros(listaNumeros);
                    Console.ReadKey();
                    break;
                case 5:
                    Console.Clear();
                    Numeros.MultiplicarNumeros(listaNumeros);
                    Console.ReadKey();
                    break;
                case 6:
                    Console.Clear();
                    Numeros.DividirNumeros(listaNumeros);
                    Console.ReadKey();
                    break;
                case 7:
                    Console.Clear();
                    Numeros.MostrarOperaciones(listaNumeros);
                    Console.ReadKey();
                    break;
                case 8:
                    menu = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}