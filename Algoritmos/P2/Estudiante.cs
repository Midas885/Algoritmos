


public class Estudiante
{
    public string Matricula { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
    public string Carrera { get; set; }
    public string Grado { get; set; }

    public override string ToString()
    {
        return $"Matrícula: {Matricula}\nNombre: {Nombre} {Apellido}\nTeléfono: {Telefono}\nCorreo: {Correo}\nCarrera: {Carrera}\nGrado: {Grado}\n";
    }
}



