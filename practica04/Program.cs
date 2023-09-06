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
    public string Ingresar() {
        //Uso de instancias y objetos
        Estudiante estudiante = new Estudiante();
        //Implementar valor autoincrementable
        estudiante.Id = Guid.NewGuid().ToString();
        Console.WriteLine("Ingrese el nombre: ");
        estudiante.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el Email: ");
        estudiante.Email = Console.ReadLine();
        Console.WriteLine("Ingrese el Sex: ");
        estudiante.Sex = Console.ReadLine();
        Console.WriteLine("Ingrese el Edad: ");
        estudiante.Edad = int.Parse(Console.ReadLine());
    }
}