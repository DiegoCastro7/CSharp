using System.Collections;
using System.Reflection.Metadata;
using practica04.entities;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList Data = new ArrayList();
        //Relacionar la clase
        bool Bandera = true; 
        int seleccion = 0;
        while (Bandera)
                {
                    Console.WriteLine("Seleccione lo que desea hacer:");
                    Console.WriteLine("1. Agregar Estudiante");
                    Console.WriteLine("2. Visualizar estudiantes");
                    Console.WriteLine("3. Salir");
                    seleccion = int.Parse(Console.ReadLine());
                    if (seleccion ==1) {
                        Ingresar();
                    }
                    else if (seleccion == 3){
                        Bandera = false;
                    }
                    else {
                        Console.WriteLine("Opcion no valida");
                    }
                }
    }
    public static string Ingresar(){
        Dictionary<string, string> Info = new Dictionary<string, string>();
        //Uso de instancias y objetos
        Estudiante estudiante = new Estudiante();
        //Implementar valor autoincrementable
        estudiante.Id = Guid.NewGuid().ToString();
        Console.WriteLine("Ingrese el nombre: ");
        estudiante.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el Email: ");
        estudiante.Email = Console.ReadLine();
        Console.WriteLine("Ingrese el Sexo: ");
        estudiante.Sex = Console.ReadLine();
        Console.WriteLine("Ingrese el Edad: ");
        estudiante.Edad = int.Parse(Console.ReadLine());
        Info.Add("Id", estudiante.Id);
        Info.Add("Nombre", estudiante.Nombre);
        Info.Add("Email", estudiante.Email);
        Info.Add("Sex", estudiante.Sex);
        //Info.Add("Edad", estudiante.Edad);
        return Info;
    }
}