

namespace Algoritmos.P2
{
    public class StartP2
    {
        public static void Gestor()
        {
            GestorEstudiantes gestor = new GestorEstudiantes();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n ****** Sistema de Gestion de Estudiantes ******\n");
                Console.WriteLine("     1. Agregar Estudiante");
                Console.WriteLine("     2. Modificar Estudiante");
                Console.WriteLine("     3. Eliminar Estudiante");
                Console.WriteLine("     4. Buscar Estudiantes");
                Console.WriteLine("     5. Listar Todos los Estudiantes");
                Console.WriteLine("     6. Salir");

                Console.Write("\n Seleccione una opcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        AgregarEstudiante(gestor);
                        break;
                    case "2":
                        Console.Clear();
                        ModificarEstudiante(gestor);
                        break;
                    case "3":
                        Console.Clear();
                        EliminarEstudiante(gestor);
                        break;
                    case "4":
                        Console.Clear();
                        BuscarEstudiantes(gestor);
                        break;
                    case "5":
                        Console.Clear();
                        gestor.ListarEstudiantes();
                        break;
                    case "6":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("\n Opcion no valida");
                        break;
                }
            }
        }

        static void AgregarEstudiante(GestorEstudiantes gestor)
        {
            Console.WriteLine("\n ****** Agregar Estudiante ******\n");
            Estudiante estudiante = new Estudiante();

            Console.Write(" Matricula: ");
            estudiante.Matricula = Console.ReadLine();

            Console.Write(" Nombre: ");
            estudiante.Nombre = Console.ReadLine();

            Console.Write(" Apellido: ");
            estudiante.Apellido = Console.ReadLine();

            Console.Write(" Telefono: ");
            estudiante.Telefono = Console.ReadLine();

            Console.Write(" Correo: ");
            estudiante.Correo = Console.ReadLine();

            Console.Write(" Carrera: ");
            estudiante.Carrera = Console.ReadLine();

            Console.Write(" Grado: ");
            estudiante.Grado = Console.ReadLine();

            gestor.AgregarEstudiante(estudiante);
        }

        static void ModificarEstudiante(GestorEstudiantes gestor)
        {
            Console.WriteLine("\n ****** Modificar Estudiante ******\n");
            Console.Write(" Ingrese la matrícula del estudiante a modificar: ");
            string matricula = Console.ReadLine();

            if (!string.IsNullOrEmpty(matricula))
            {
                Estudiante estudiante = new Estudiante();
                estudiante.Matricula = matricula;

                Console.Write(" Nuevo Nombre: ");
                estudiante.Nombre = Console.ReadLine();

                Console.Write(" Nuevo Apellido: ");
                estudiante.Apellido = Console.ReadLine();

                Console.Write(" Nuevo Teléfono: ");
                estudiante.Telefono = Console.ReadLine();

                Console.Write(" Nuevo Correo: ");
                estudiante.Correo = Console.ReadLine();

                Console.Write(" Nueva Carrera: ");
                estudiante.Carrera = Console.ReadLine();

                Console.Write(" Nuevo Grado: ");
                estudiante.Grado = Console.ReadLine();

                gestor.ModificarEstudiante(matricula, estudiante);
            }
            else 
                Console.WriteLine("\n Igresa una matricula para continuar");
                
        }

        static void EliminarEstudiante(GestorEstudiantes gestor)
        {
            Console.WriteLine("\n ****** Eliminar Estudiante ******\n");
            Console.Write(" Ingrese la matrícula del estudiante a eliminar: ");
            string matricula = Console.ReadLine();
            if (!string.IsNullOrEmpty(matricula))
                gestor.EliminarEstudiante(matricula);
            else
                Console.WriteLine("\n Igresa una matricula para continuar");
        }

        static void BuscarEstudiantes(GestorEstudiantes gestor)
        {
            Console.WriteLine("\n ****** Buscar Estudiantes ******\n");
            Console.WriteLine(" Criterios de busqueda: matricula, nombre, apellido, carrera, grado");
            Console.Write(" Ingrese el criterio de busqueda: ");
            string criterio = Console.ReadLine();

            Console.Write(" Ingrese el valor a buscar: ");
            string valor = Console.ReadLine();
            if (!string.IsNullOrEmpty(criterio) && !string.IsNullOrEmpty(valor))
            {
                Estudiante[] resultados = gestor.BuscarEstudiantes(criterio, valor);
                if (resultados != null)
                {
                    Console.WriteLine("\n ****** Resultados de la Búsqueda ******");
                    for (int i = 0; i < resultados.Length && resultados[i] != null; i++)
                    {
                        Console.WriteLine(resultados[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("\n Valores no validos, por favor ingrese valores validos para continuar");
            }

            
        }

    }


}
