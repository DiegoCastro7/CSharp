internal class Program
{
    private static void Main(string[] args)
    {
        
        List<String> Materias = new List<string>();
        int idx = 0;
        Materias.Add("Calculo");
        Materias.Add("Programacao");
        Materias.Add("Linguagem");
        Materias.Add("Arquitetura");
        ContarLista(Materias);
        Console.WriteLine("Ingrese la posicion");
        idx = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("El elemento en el indice {0} es: {1}", idx, ObtenerElemento(idx,Materias));
        Materias.Add(AddItemData());

        Console.WriteLine("Ingrese la palabra a buscar:");
        if (ValidarItem(Materias,Console.ReadLine().ToLower())){
            Console.WriteLine("Ok, lo encontre");
        }else{
            Console.WriteLine("No lo encontre");
        }
        Console.ReadKey();

        String ? palabra=null;
        List<String> Dinosaurios = new List<string>();
        string[] Dinos={
            "Brach",
            "Amaraga",
            "Mamenchi"
        };
        Dinosaurios.AddRange(Dinos);
        Console.WriteLine("Ingrese el nombre del Dinosaurio a buscar: ");
        palabra = Console.ReadLine();
        string nombre = Dinosaurios.Find(n => n.StartsWith(palabra ?? String.Empty));
        Console.WriteLine(nombre!=null?"Se encontro el dinosaurio":"No se encontro el dinosaurio");
    }
    public static void ContarLista(List<String> Lista){
        Console.WriteLine("Total de elementos de la lista {0}", Lista.Count());
    }
    /// <summary>
    /// Metodo para obtener el elemento de una posicion de una lista generica
    /// </summary>
    /// <param name="idx">Indice de la posicion a obtener</param>
    /// <param name="Lista">Coleccion generica de los datos</param>
    /// <returns></returns>
    public static string ObtenerElemento(int idx,List<String> Lista){
        return Lista[idx];
    }
    public static string AddItemData(){
        Console.WriteLine("Ingrese el elemento a agregar:");
        return Console.ReadLine();
    }
    public static bool ValidarItem(List<string> Lista,string valor){
        return Lista.Exists(l =>l.ToLower().Equals(valor));
    }
    
}