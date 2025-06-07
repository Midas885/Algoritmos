

namespace Algoritmos.P1
{
    class StartP1
    {
        public static void Crupier()
        {
            try
            {
                Mazo mazo = new Mazo();

                Console.WriteLine("\n ****** Mazo Inicial ******\n");
                mazo.MostrarMazo();

                Console.WriteLine("\n ****** Mazo Barajado ******\n");
                mazo.Barajar();
                mazo.MostrarMazo();

                Console.Write("\n Ingrese el numero de cartas a repartir: ");
                int n;
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine($"\n ****** Repartir {n} Cartas ******\n");

                    List<Carta> mano = mazo.Repartir(n);
                    foreach (var carta in mano)
                    {
                        Thread.Sleep(100);
                        Console.WriteLine($"    {carta}");
                    }

                    Console.WriteLine($"\n Cartas restantes en el mazo: {mazo.CartasRestantes()}");
                    Console.WriteLine("\n Preciona una tecla para ir atras...");
                    Console.ReadKey();
                }
                else Console.WriteLine("\n Numero no valido, por favor ingrese un numero valido");
                

                
            } catch (Exception ex)
            {
                Console.WriteLine($" Error: {ex.Message}");
            }
        }
    }
}
