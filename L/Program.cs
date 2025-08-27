// See https://aka.ms/new-console-template for more information

var persona = new Personas();
persona.Id = 12;
persona.Nombre = "Juan";
persona.Edad = 20;
persona.Mascotas = new List<Mascotas>();
persona.Mascotas.Add(new Mascotas() { Id = 12, Nombre = "Luca", Tipo = "Perro" });
persona.Mascotas.Add(new Mascotas() {Id= 23, Nombre= "Mia", Tipo= "Gato"});

var veterinario = new Veterinarios();
veterinario.Id = 1;
veterinario.Nombre = "Pedro";
veterinario.Edad = 25;
veterinario.Mascotas = new List<Mascotas>();
veterinario.Mascotas = persona.Mascotas;
veterinario.Especialidad = "No se, no soy veterinario";

Console.WriteLine("Mascotas atendidas por el veterinario ", veterinario.Nombre, " con especialidad ", veterinario.Especialidad);
foreach (var i in veterinario.Mascotas)
{
    Console.WriteLine("Nombre: ", i.Nombre);
    Console.WriteLine("Tipo: ", i.Tipo);
}

public class Personas
{
    public int Id;
    public string Nombre = "";
    public int? Edad;

    public List<Mascotas>? Mascotas;
}

public class Mascotas
{
    public int Id;
    public string Nombre = "";
    public string Tipo = "";
}

public class Veterinarios : Personas
{
    public string? Especialidad;
}