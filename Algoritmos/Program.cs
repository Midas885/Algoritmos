
using Algoritmos;
using Algoritmos.P1;
using Algoritmos.P2;
using Algoritmos.P3;

internal class Program
{
    public static void Main(string[] args)
    {
        bool salir = false;
        while (!salir)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\n ********** Practicas sobre Estructura de Datos Estatica **********\n");
                Console.WriteLine("\t1. Problema 1: Simulacion de baraja de cartas");
                Console.WriteLine("\t2. Problema 2: Simulacion de gestion de estudiantes");
                Console.WriteLine("\t3. Problema 3: Crear matrices bidimensional");
                Console.WriteLine("\t4. Salir\n");

                Console.Write("\t Seleccione una opcion: ");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        StartP1.Crupier();
                        break;
                    case "2":
                        Console.Clear();
                        StartP2.Gestor();
                        break;
                    case "3":
                        Console.Clear();
                        StartP3.Matriz();
                        break;
                    case "4":
                        Console.WriteLine("\n Fin");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("\n Opcion no valida");
                        break;


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n Error: {ex.Message}\n");
            }
        }
    }
}


