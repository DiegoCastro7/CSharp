using System.Collections;
using ejercicio01.entities;

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
                    Console.Clear();
                    Console.WriteLine("Seleccione lo que desea hacer:");
                    Console.WriteLine("1. Agregar Estudiante");
                    Console.WriteLine("2. Visualizar notas estudiantes");
                    Console.WriteLine("3. Agregar Notas");
                    Console.WriteLine("4. Salir");
                    
                    try
                    {   
                        seleccion = int.Parse(Console.ReadLine());
                        switch (seleccion)
                        {
                            case 1:
                                Ingresar(lstClase);
                                break;
                            case 2:
                                Visualizar(lstClase);
                                break;
                            case 3:
                                Notas(lstClase);
                                break;
                            case 4:
                                Bandera = false;
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Opcion no valida, presione enter para continuar y digite una opcion valida");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                    }
                    //Revisar
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Opcion no valida, presione enter para continuar y digite una opcion valida");
                        Console.ReadKey();
                        Console.Clear();
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
        Console.WriteLine("Ingrese la direccion: ");
        estudiante.Direccion = Console.ReadLine();
        Console.WriteLine("Ingrese el Edad: ");
        estudiante.Edad = int.Parse(Console.ReadLine());
        lstClase.Add(estudiante);
        Console.Clear();
    }
    public static void Visualizar(List<Estudiante> lstClase){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("{0,-36} {1,-30} {2,5} {3,5} {4,20}","Cod.Estudiante","Nombre Estudiante","Edad","Direccion","Correo Electronico");
        foreach (Estudiante a in lstClase){
            Console.WriteLine("{0,36} {1,-30} {2,5} {3,5} {4,20}",a.Id,a.Nombre,a.Edad,a.Direccion,a.Email);
        }
        Console.ReadKey();
        Console.Clear();
        Console.ResetColor();
    }
    public static void Notas(List<Estudiante> lstClase){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("{0,-36} {1,-30} {2,5} {3,5} {4,20}","Cod.Estudiante","Nombre Estudiante","Edad","Direccion","Correo Electronico");
        foreach (Estudiante a in lstClase){
            Console.WriteLine("{0,36} {1,-30} {2,5} {3,5} {4,20}",a.Id,a.Nombre,a.Edad,a.Direccion,a.Email);
        }
        Console.ReadKey();
        Console.Clear();
        Console.ResetColor();
    }
}