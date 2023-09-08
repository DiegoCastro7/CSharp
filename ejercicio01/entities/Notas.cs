namespace ejercicio01.entities; 

public class Notas
{
    //Atributos de clase
    private string id;
    private float[] quizzes = new float[]{-1.0f,-1.0f,-1.0f,-1.0f};
    private float[] trabajos = new float[]{-1.0f,-1.0f};
    private float[] parciales = new float[]{-1.0f,-1.0f,-1.0f};

    //Propiedades de clase
    public string Id
    {
        get { return id; }
        set { id = value; }
    }
    public float[] Quizzes
    {
        get { return quizzes; }
        set { quizzes = value; }
    }
    public float[] Trabajos
    {
        get { return trabajos; }
        set { trabajos = value; }
    }
    public float[] Parciales
    {
        get { return parciales; }
        set { parciales = value; }
    }

    //Constructor de Clase
    public Notas()
    {
    }
    public Notas(string id, float[] quizzes, float[] trabajos, float[] parciales){
        //this se usa para indicar que ese atributo pertenece a la clase para no tener problemas con los argumentos de entrada
        this.id = id;
        this.quizzes = quizzes;
        this.trabajos = trabajos;
        this.parciales = parciales;
    }
}
