

namespace Algoritmos.P3
{
    using System;

    class StartP3
    {
        public static void Matriz()
        {
            try
            {
                Console.WriteLine("\n ****** Analizador de Matrices Bidimensionales ******");

                int filas = 0;
                int columnas = 0;

                while (true)
                {
                    Console.Write("\n Ingrese el numero de filas: ");
                    if (int.TryParse(Console.ReadLine(), out filas))
                        break;

                    else
                    {
                        Console.Write("\n Numero de filas no valido, por favor ingresa un numero valido");
                    }
                }

                while (true)
                {
                    Console.Write(" Ingrese el numero de columnas: ");
                    if (int.TryParse(Console.ReadLine(), out columnas))
                        break;
                    else
                    {
                        Console.Write("\n Numero de columnas no valido, por favor ingresa un numero valido");
                    }
                }

                int[,] matriz = new int[filas, columnas];

                Console.WriteLine("\n Ingrese los valores de la matriz: \n");
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {

                        int num;
                        while (true)
                        {
                            Console.Write($" Fila {i + 1}, Columna {j + 1}: ");

                            if (int.TryParse(Console.ReadLine(), out num))
                            {
                                matriz[i, j] = num;
                                break;
                            }
                            else
                                Console.WriteLine("\n Valor no valido, por favor solo ingresa valores validos\n");
                        }
                    }
                }

                Console.WriteLine("\n ****** Matriz Ingresada ******\n");
                MostrarMatriz(matriz, filas, columnas);

                int maximo = matriz[0, 0];
                int minimo = matriz[0, 0];
                int filaMax = 0, columnaMax = 0;
                int filaMin = 0, columnaMin = 0;

                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        if (matriz[i, j] > maximo)
                        {
                            maximo = matriz[i, j];
                            filaMax = i;
                            columnaMax = j;
                        }

                        if (matriz[i, j] < minimo)
                        {
                            minimo = matriz[i, j];
                            filaMin = i;
                            columnaMin = j;
                        }
                    }
                }


                Console.WriteLine("\n ****** Resultados del Analisis ****** \n");
                Console.WriteLine($" Valor maximo: {maximo} Pocision: Fila {filaMax + 1}, Columna {columnaMax + 1}");
                Console.WriteLine($" Valor minimo: {minimo} Pocision: Fila {filaMin + 1}, Columna {columnaMin + 1}");

                Console.WriteLine("\n Preciona una tecla para ir atras...");
                Console.ReadKey();
            } catch (Exception ex)
            {
                Console.WriteLine($"\n Error: {ex.Message}\n");
                Console.ReadKey();
            }
        }

        static void MostrarMatriz(int[,] matriz, int filas, int columnas)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j],5}"); 
                }
                Console.WriteLine();
            }
        }
    }
}
