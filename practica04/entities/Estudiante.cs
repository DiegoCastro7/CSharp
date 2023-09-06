namespace practica04.entities;

public class Estudiante
{
    //Atributos de clase
    private string id;
    private string nombre;
    private string email;
    private string sex;
    private int edad;

    //Propiedades de clase
    public string Id
    {
        get { return id; }
        set { id = value; }
    }
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    public string Sex
    {
        get { return sex; }
        set { sex = value; }
    }
    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }

    //Constructor de Clase
    public Estudiante()
    {
    }
    public Estudiante(string id, string nombre, string email ,string sex, int edad){
        //this se usa para indicar que ese atributo pertenece a la clase para no tener problemas con los argumentos de entrada
        this.id = id;
        this.nombre = nombre;
        this.email = email;
        this.sex = sex;
        this.edad = edad;
    }
    
    
    

}
