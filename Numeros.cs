using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Numeros
    {
        public int Numero { get; set; }

        public Numeros(int numero)
        {
            Numero = numero;
        }

        public static void IngresarNumeros(List<Numeros> listaNumeros)
        {
            try
            {
                Console.WriteLine("Ingrese un número:");
                int numero = Convert.ToInt32(Console.ReadLine());
                Numeros numero1 = new Numeros(numero);
                listaNumeros.Add(numero1);
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor, ingrese un número entero.");
            }
        }

        public static void MostrarNumeros(List<Numeros> listaNumeros)
        {
            Console.WriteLine("Lista de números:");
            foreach (Numeros numero in listaNumeros)
            {
                Console.WriteLine(numero.Numero);
            }
        }

        public static void SumarNumeros(List<Numeros> listaNumeros)
        {
            int suma = 0;
            foreach (Numeros numero in listaNumeros)
            {
                suma += numero.Numero;
            }
            Console.WriteLine($"La suma de los números es: {suma}");
        }

        public static void RestarNumeros(List<Numeros> listaNumeros)
        {
            if (listaNumeros.Count > 0)
            {
                int resta = listaNumeros[0].Numero;
                for (int i = 1; i < listaNumeros.Count; i++)
                {
                    resta -= listaNumeros[i].Numero;
                }
                Console.WriteLine($"La resta de los números es: {resta}");
            }
            else
            {
                Console.WriteLine("No hay números en la lista para restar.");
            }
        }

        public static void MultiplicarNumeros(List<Numeros> listaNumeros)
        {
            int multiplicacion = 1;
            foreach (Numeros numero in listaNumeros)
            {
                multiplicacion *= numero.Numero;
            }
            Console.WriteLine($"La multiplicación de los números es: {multiplicacion}");
        }

        public static void DividirNumeros(List<Numeros> listaNumeros)
        {
            if (listaNumeros.Count > 0)
            {
                float division = listaNumeros[0].Numero;
                for (int i = 1; i < listaNumeros.Count; i++)
                {
                    if (listaNumeros[i].Numero != 0)
                    {
                        division /= listaNumeros[i].Numero;
                    }
                    else
                    {
                        Console.WriteLine("resultado indefinido.");
                        return;
                    }
                }
                Console.WriteLine($"La división de los números es: {division}");
            }
            else
            {
                Console.WriteLine("No hay números en la lista para dividir.");
            }
        }

        public static void MostrarOperaciones(List<Numeros> listaNumeros)
        {
            SumarNumeros(listaNumeros);
            RestarNumeros(listaNumeros);
            MultiplicarNumeros(listaNumeros);
            DividirNumeros(listaNumeros);
        }
    }
}