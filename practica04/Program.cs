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
        List<Estudiante> lstClase = new List<Estudiante>();
        while (Bandera)
                {
                    Console.WriteLine("Seleccione lo que desea hacer:");
                    Console.WriteLine("1. Agregar Estudiante");
                    Console.WriteLine("2. Visualizar estudiantes");
                    Console.WriteLine("3. Salir");
                    seleccion = int.Parse(Console.ReadLine());
                    if (seleccion == 1) {
                        Ingresar(lstClase);
                    }
                    if (seleccion == 2) {
                        Visualizar(lstClase);
                    }
                    else if (seleccion == 3){
                        Bandera = false;
                    }
                    else {
                        Console.WriteLine("Opcion no valida");
                    }
                }
    }
    public static void Ingresar(List<Estudiante> lstClase){
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
        lstClase.Add(estudiante);
        Console.Clear();
    }
    public static void Visualizar(List<Estudiante> lstClase){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("{0,-36} {1,-30} {2,5} {3,5} {4,20}","Cod.Estudiante","Nombre Estudiante","Edad","Sexo","Correo Electronico");
        foreach (Estudiante a in lstClase){
            Console.WriteLine("{0,36} {1,-30} {2,5} {3,5} {4,20}",a.Id,a.Nombre,a.Edad,a.Sex,a.Email);
        }
        Console.ReadKey();
        Console.Clear();
        Console.ResetColor();
    }
}