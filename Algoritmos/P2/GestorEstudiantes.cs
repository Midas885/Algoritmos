

namespace Algoritmos.P2
{
    public class GestorEstudiantes
    {
        private Estudiante[] estudiantes;
        private int cantidad;
        private const int MAX_ESTUDIANTES = 30;

        public GestorEstudiantes()
        {
            estudiantes = new Estudiante[MAX_ESTUDIANTES];
            cantidad = 0;
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            if (cantidad < MAX_ESTUDIANTES)
            {
                estudiantes[cantidad] = estudiante;
                cantidad++;
                Console.WriteLine("\n Estudiante agregado con exito");
            }
            else
            {
                Console.WriteLine("\n No se pueden agregar mas estudiantes");
            }
        }

        public void ModificarEstudiante(string matricula, Estudiante nuevosDatos)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (estudiantes[i].Matricula == matricula)
                {
                    estudiantes[i] = nuevosDatos;
                    Console.WriteLine("\n Estudiante modificado con exito");
                    return;
                }
            }
            Console.WriteLine("\n Estudiante no encontrado");
        }

        public void EliminarEstudiante(string matricula)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (estudiantes[i].Matricula == matricula)
                {
                    for (int j = i; j < cantidad - 1; j++)
                    {
                        estudiantes[j] = estudiantes[j + 1];
                    }
                    cantidad--;
                    Console.WriteLine("\n Estudiante eliminado con exito");
                    return;
                }
            }
            Console.WriteLine("\n Estudiante no encontrado");
        }

        public Estudiante[] BuscarEstudiantes(string criterio, string valor)
        {
            Estudiante[] resultados = new Estudiante[MAX_ESTUDIANTES];
            int contador = 0;

            for (int i = 0; i < cantidad; i++)
            {
                bool coincide = false;
                switch (criterio.ToLower())
                {
                    case "matricula":
                        coincide = estudiantes[i].Matricula.Contains(valor);
                        break;
                    case "nombre":
                        coincide = estudiantes[i].Nombre.Contains(valor);
                        break;
                    case "apellido":
                        coincide = estudiantes[i].Apellido.Contains(valor);
                        break;
                    case "carrera":
                        coincide = estudiantes[i].Carrera.Contains(valor);
                        break;
                    case "grado":
                        coincide = estudiantes[i].Grado.Contains(valor);
                        break;
                    default:
                        Console.WriteLine("\n Criterio de busqueda no valido");
                        return null;
                }

                if (coincide)
                {
                    resultados[contador] = estudiantes[i];
                    contador++;
                }
            }

            if (contador == 0)
            {
                Console.WriteLine("\n No se encontraron resultados");
                return null;
            }

            return resultados;
        }

        public void ListarEstudiantes()
        {
            if (cantidad == 0)
            {
                Console.WriteLine("\n No hay estudiantes registrados");
                return;
            }

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"\n ****** Estudiante {i + 1} ******\n");
                Console.WriteLine($"{estudiantes[i]}");
            }
        }
    }



}
