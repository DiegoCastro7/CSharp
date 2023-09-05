using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //Estructuras de datos
        //Arrays
        int[] array = new int[10];
        for (int i = 0; i < 10; i++)
        {
            array[i] = i;
        }
        Console.WriteLine(array[0]);
        Console.WriteLine(array[1]);
        Console.WriteLine(array[2]);
        Console.WriteLine(array[3]);
        Console.WriteLine(array[4]);
        Console.WriteLine(array[5]);
        Console.WriteLine(array[6]);
        Console.WriteLine(array[7]);
        Console.WriteLine(array[8]);
        Console.WriteLine(array[9]);
        //Diccionarios
        Dictionary<string, string> dic = new Dictionary<string, string>();
        dic.Add("Nombre", "Juan");
        dic.Add("Apellido", "Pérez");
        dic.Add("Edad", "25");
        Console.WriteLine(dic["Nombre"]);
        Console.WriteLine(dic["Apellido"]);
        Console.WriteLine(dic["Edad"]);
        Console.WriteLine(dic.Count);
        //ArrayList
        //E1
        ArrayList myAL = new ArrayList();
        myAL.Add("The");
        myAL.Add("quick");
        myAL.Add("brown");
        myAL.Add("fox");
        foreach (object n in myAL) {
            Console.WriteLine(n.ToString());
        }
        //E2
        ArrayList Carnivoros = new ArrayList();
        ArrayList Acuaticos = new ArrayList();
        ArrayList Animales = new ArrayList();
        Carnivoros.Add("Tigre");
        Carnivoros.Add("Leon");
        Carnivoros.Add("Pantera");
        Carnivoros.Add("Leopardo");
        Acuaticos.Add("Tiburon");
        Acuaticos.Add("Delfin");
        Acuaticos.Add("Ballena");
        Acuaticos.Add("Pulpo");
        Animales.AddRange(Carnivoros);
        foreach (Object n in Animales)
        {
            Console.WriteLine(n.ToString());
        }
        Console.WriteLine("=====================");
        Animales.AddRange(Acuaticos);
        foreach (Object n in Animales)
        {
            Console.WriteLine(n.ToString());
        }
        Animales.Clear();
        foreach (Object n in Animales)
        {
            Console.WriteLine(n.ToString());
        }
        Console.WriteLine("=====================");
        //E3
        string ? palabra;
        int idx;
        ArrayList Materias = new ArrayList();
        ArrayList Cursos = new ArrayList();
        Materias.Add("Calculo");
        Materias.Add("Español");
        Materias.Add("Dibujo tecnico");
        Materias.Add("Ingles");
        
        Cursos.Add("8vo");
        Cursos.Add("9no");
        Console.WriteLine("Escriba una materia buscar: ");
        palabra = Console.ReadLine();
        Console.WriteLine(Materias.Contains(palabra) ? "La materia esta disponible" : "La materia no se encontro");

        do{
            Console.WriteLine("Ingrese la posicion donde desea insertar la asignatura: ");
            idx = Convert.ToInt32(Console.ReadLine());
        }while (idx>Materias.Count);

        Console.Write("Escriba una materia a insertar: ");
        palabra = Console.ReadLine();

        Materias.Insert(idx, palabra);
        Materias.InsertRange(0, Cursos);
        foreach (Object n in Materias)
        {
            Console.WriteLine(n.ToString());
        }
        //E4
        string[] prueba = new string[2];
        prueba[0] = "Hola";
        prueba[1] = "Mundo";
        ArrayList frases = new ArrayList();
        frases.Add("Hola");
        frases.AddRange(prueba);
        foreach (Object n in frases)
        {
            Console.WriteLine(n.ToString());
        }
        //Listas
        //Stack
        //Queque
    }
}