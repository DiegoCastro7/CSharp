using System.Collections;
using ejercicio01.entities;

internal class Program
{
    private static void Main(string[] args)
    {
        //Relacionar la clase
        bool Bandera = true; 
        int seleccion = 0;
        List<Estudiante> lstClase = new List<Estudiante>();
        List<Notas> lstNotas = new List<Notas>();
        while (Bandera)
                {
                    Console.Clear();
                    Console.WriteLine("   UIS - Universidad Industrial de Santander");
                    Console.WriteLine("        Sistema de registro de notas");
                    Console.WriteLine("               Menu Principal");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("| Bienvenido, seleccione lo que desea hacer: |");
                    Console.WriteLine("| 1. Agregar Estudiante                      |");
                    Console.WriteLine("| 2. Visualizar notas estudiantes            |");
                    Console.WriteLine("| 3. Agregar Notas                           |");
                    Console.WriteLine("| 4. Salir                                   |");
                    Console.WriteLine("----------------------------------------------");
                    try
                    {   
                        seleccion = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (seleccion)
                        {
                            case 1:
                                Ingresar(lstClase,lstNotas);
                                break;
                            case 2:
                                Visualizar(lstClase,lstNotas);
                                break;
                            case 3:
                                ANotas(lstNotas);
                                break;
                            case 4:
                                Console.WriteLine("Gracias por usar el sistema de notas, hasta pronto.");
                                Console.WriteLine("");
                                Console.WriteLine("¿Esta seguro de que desea salir del sistema de notas?");
                                Console.WriteLine("1. Si");
                                Console.WriteLine("2. No");
                                seleccion=int.Parse(Console.ReadLine());
                                try
                                {
                                    if (seleccion == 1 ){
                                        Bandera = false;
                                    }
                                    else if (seleccion != 2){
                                        Console.WriteLine("Seleccion incorrecta, oprima enter para regresar al menu principal");
                                        Console.ReadKey();
                                    }
                                }
                                catch (FormatException)
                                {
                                Console.WriteLine("Seleccion incorrecta, oprima enter para regresar al menu principal");
                                Console.ReadKey();
                                }
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Opcion no valida, presione enter para continuar y digite una opcion valida");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Opcion no valida, presione enter para continuar y digite una opcion valida");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    
                }
    }
    public static void Ingresar(List<Estudiante> lstClase, List<Notas> lstNotas){
        Console.WriteLine("Regitro del estudiante: ");
        //Uso de instancias y objetos
        Estudiante estudiante = new Estudiante();
        Notas notas = new Notas();
        Console.WriteLine("Ingrese el codigo del estudiante: ");
        string Id = Console.ReadLine();
        bool encontrado = false;
        bool banderdatos = true;
        foreach (Estudiante a in lstClase){
            if (a.Id == Id){
                encontrado = true;
            }
        }
        if (encontrado){
            Console.WriteLine("Este estudiante ya esta registrado en el sistema, presione enter para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        else if (!encontrado && Id.Count()<= 15 && Id.Count()> 0){
            estudiante.Id = Id;
            notas.Id = estudiante.Id;
            Console.WriteLine("Ingrese el nombre: ");
            string name = Console.ReadLine();
            if (name.Count()> 40 || name.Count()<= 0){
                banderdatos=false;
                Console.WriteLine("El nombre no es valido, su longitud excede los 40 caracteres o esta vacio");
                Console.WriteLine("Presione enter para volver al menu");
            Console.ReadKey();
            Console.Clear();
            }
            else if(name.Count()> 0){
                estudiante.Nombre = name;
            }
            bool banderedad = false;
            while (!banderedad && banderdatos) {
                try
                {
                    Console.WriteLine("Ingrese la Edad: ");
                    int Edad = int.Parse(Console.ReadLine());
                    if (Edad > 0 && Edad < 150){
                        estudiante.Edad = Edad;
                        banderedad = true;
                    }
                    else{
                        Console.WriteLine("Incorrecto, presione enter para continuar e ingrese una edad valida");
                    Console.ReadKey();
                    }
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrecto, presione enter para continuar e ingrese una edad valida");
                    Console.ReadKey();
                }
            }
            if (banderdatos) {
                Console.WriteLine("Ingrese el Email: ");
                string email = Console.ReadLine();
                if (email.Count()> 40 || email.Count()<= 0){
                    banderdatos=false;
                    Console.WriteLine("El email no es valido, su longitud excede los 40 caracteres o esta vacio");
                    Console.WriteLine("Presione enter para volver al menu");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (email.Count()> 0){
                    estudiante.Email = email;
                            }
            }
            if (banderdatos) {
                Console.WriteLine("Ingrese la direccion: ");
                string direccion = Console.ReadLine();
                if (direccion.Count()> 35 || direccion.Count()<= 0){
                    banderdatos=false;
                    Console.WriteLine("La direccion no es valida, su longitud excede los 35 caracteres o esta vacio");
                    Console.WriteLine("Presione enter para volver al menu");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (direccion.Count()> 0){
                    estudiante.Direccion = direccion;
                }
            }
            if (banderdatos){
                lstClase.Add(estudiante);
                lstNotas.Add(notas);
            }
            
            Console.Clear();
        }
        else{
            if (Id.Count()> 15){
                Console.WriteLine("El codigo no es valido, su longitud excede los 15 caracteres o esta vacio");
            }
            Console.WriteLine("Informacion erronea");
            Console.WriteLine("Presione enter para volver al menu");
            Console.ReadKey();
            Console.Clear();
        }

        
    }
    public static void Visualizar(List<Estudiante> lstClase, List<Notas> lstNota){
        bool Bandera1 = true; 
        int seleccion = 0;
        while (Bandera1)
                {
                    Console.Clear();
                    Console.WriteLine("   UIS - Universidad Industrial de Santander");
                    Console.WriteLine("        Sistema de registro de notas");
                    Console.WriteLine("              Menu de Informes");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("| Bienvenido, seleccione lo que desea hacer: |");
                    Console.WriteLine("| 1. Visualizar notas generales              |");
                    Console.WriteLine("| 2. Visualizar notas definitivas            |");
                    Console.WriteLine("| 3. Salir                                   |");
                    Console.WriteLine("----------------------------------------------");
                    try
                    {   
                        seleccion = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (seleccion)
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("| {0,-20} | {1,-40} | {2,-29} | {3,-13} | {4,-21} |","Cod.Estudiante","Nombre Estudiante","Quizzes","Trabajos","Parciales");
                                Console.WriteLine("| {0,-20} | {1,-40} | {2,-5} | {3,-5} | {4,-5} | {5,-5} | {6,-5} | {7,-5} | {8,-5} | {9,-5} | {10,-5} |","","","Q1","Q2","Q3","Q4","T1","T2","P1","P2","P3");
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------");
                                int i = 0;
                                int contador = 0;
                                foreach (Estudiante c in lstClase){
                                        i=i+1;
                                    }
                                float x = (float)i/10;
                                int j = (int)x;
                                    Console.WriteLine("Actualmente hay {0} estudiantes registrados",i);
                                    Console.WriteLine("");
                                foreach (Estudiante a in lstClase){
                                    foreach (Notas b in lstNota){
                                        if (a.Id == b.Id){
                                            string Q1 = (b.Quizzes[0]==-1) ? "N/R" : b.Quizzes[0].ToString();
                                            string Q2 = (b.Quizzes[1]==-1) ? "N/R" : b.Quizzes[1].ToString();
                                            string Q3 = (b.Quizzes[2]==-1) ? "N/R" : b.Quizzes[2].ToString();
                                            string Q4 = (b.Quizzes[3]==-1) ? "N/R" : b.Quizzes[3].ToString();
                                            string T1 = (b.Trabajos[0]==-1) ? "N/R" : b.Trabajos[0].ToString();
                                            string T2 = (b.Trabajos[1]==-1) ? "N/R" : b.Trabajos[1].ToString();
                                            string P1 = (b.Parciales[0]==-1) ? "N/R" : b.Parciales[0].ToString();
                                            string P2 = (b.Parciales[1]==-1) ? "N/R" : b.Parciales[1].ToString();
                                            string P3 = (b.Parciales[2]==-1) ? "N/R" : b.Parciales[2].ToString();
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("| {0,-20} | {1,-40} | {2,-5} | {3,-5} | {4,-5} | {5,-5} | {6,-5} | {7,-5} | {8,-5} | {9,-5} | {10,-5} |",a.Id,a.Nombre,Q1,Q2,Q3,Q4,T1,T2,P1,P2,P3);
                                        }
                                    }
                                    contador=contador+1;
                                    float fl = (float)contador/10;
                                    int jfl = (int)fl;
                                    //Funciona
                                    if (contador % 10 == 0 && i==contador){
                                        Console.WriteLine("");int pgactual;
                                        int totalpg;
                                        if ((float)fl*20>jfl*20){
                                            pgactual = jfl + 1;
                                        }
                                        else {
                                            pgactual = jfl;
                                        }
                                        if ((float)x*20>j*20){
                                            totalpg = j + 1;
                                        }
                                        else {
                                            totalpg = j;
                                        }
                                        Console.WriteLine("Pagina {0} de {1}",pgactual,totalpg);
                                        Console.WriteLine("Presione enter para terminar de ver el informe");
                                        Console.WriteLine("*N/R: Nota No Registrada Aun");
                                        Console.ReadKey();
                                    } 
                                    //Funciona 
                                    if (contador % 10 == 0 && i!=contador){
                                        Console.WriteLine("");
                                        int pgactual;
                                        int totalpg;
                                        if ((float)fl*20>jfl*20){
                                            pgactual = jfl + 1;
                                        }
                                        else {
                                            pgactual = jfl;
                                        }
                                        if ((float)x*20>j*20){
                                            totalpg = j + 1;
                                        }
                                        else {
                                            totalpg = j;
                                        }
                                        Console.WriteLine("Pagina {0} de {1}",pgactual,totalpg);
                                        Console.WriteLine("Presione enter para pasar a la siguiente pagina");
                                        Console.WriteLine("*N/R: Nota No Registrada Aun");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine("| {0,-20} | {1,-40} | {2,-29} | {3,-13} | {4,-21} |","Cod.Estudiante","Nombre Estudiante","Quizzes","Trabajos","Parciales");
                                        Console.WriteLine("| {0,-20} | {1,-40} | {2,-5} | {3,-5} | {4,-5} | {5,-5} | {6,-5} | {7,-5} | {8,-5} | {9,-5} | {10,-5} |","","","Q1","Q2","Q3","Q4","T1","T2","P1","P2","P3");
                                        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------");
                                        Console.WriteLine("Actualmente hay {0} estudiantes registrados",i);
                                        Console.WriteLine("");
                                    }
                                    //Funciona
                                    if (contador % 10 != 0 && contador > 10 && contador == i){
                                        Console.WriteLine("");
                                        int pgactual;
                                        int totalpg;
                                        if ((float)fl*20>jfl*20){
                                            pgactual = jfl + 1;
                                        }
                                        else {
                                            pgactual = jfl;
                                        }
                                        if ((float)x*20>j*20){
                                            totalpg = j + 1;
                                        }
                                        else {
                                            totalpg = j;
                                        }
                                        Console.WriteLine("Pagina {0} de {1}",pgactual,totalpg);
                                        Console.WriteLine("Presione enter para terminar de ver el informe");
                                        Console.WriteLine("*N/R: Nota No Registrada Aun");
                                        Console.ReadKey();
                                    }
                                }
                                //funciona
                                if (i < 10 && i>0){
                                        Console.WriteLine("");
                                        Console.WriteLine("Pagina 1 de 1");
                                        Console.WriteLine("Presione enter para terminar de ver el informe");
                                        Console.WriteLine("*N/R: Nota No Registrada Aun");
                                        Console.ReadKey();
                                    }
                                //funciona
                                if (i==0){
                                        Console.ReadKey();
                                    }
                                Console.Clear();
                                Console.ResetColor();
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("| {0,-20} | {1,-40} | {2,-15} | {3,-15} | {4,-15} | {5,-15} |","Cod.Estudiante","Nombre Estudiante","Def. Quizzes","Def. Trabajos","Def. Parciales","Nota Final");
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------");
                                int est = 0;
                                foreach (Estudiante c in lstClase){
                                    est=est+1;
                                }
                                Console.WriteLine("Actualmente hay {0} estudiantes registrados",est);
                                Console.WriteLine("");
                                foreach (Estudiante a in lstClase){
                                    foreach (Notas b in lstNota){
                                        if (a.Id == b.Id){
                                            float Q1 = (b.Quizzes[0]==-1) ? 0 : b.Quizzes[0];
                                            float Q2 = (b.Quizzes[1]==-1) ? 0 : b.Quizzes[1];
                                            float Q3 = (b.Quizzes[2]==-1) ? 0 : b.Quizzes[2];
                                            float Q4 = (b.Quizzes[3]==-1) ? 0 : b.Quizzes[3];
                                            float DQ = ((float)Q1 + (float)Q2 + (float)Q3+(float)Q4) / 4;

                                            float T1 = (b.Trabajos[0]==-1) ? 0 : b.Trabajos[0];
                                            float T2 = (b.Trabajos[1]==-1) ? 0 : b.Trabajos[1];
                                            float DT = ((float)T1 + (float)T2) / 2;

                                            float P1 = (b.Parciales[0]==-1) ? 0 : b.Parciales[0];
                                            float P2 = (b.Parciales[1]==-1) ? 0 : b.Parciales[1];
                                            float P3 = (b.Parciales[2]==-1) ? 0 : b.Parciales[2];
                                            float DP = ((float)P1 + (float)P2 + (float)P3) / 3;

                                            float NF = (float)DQ*0.25f + (float)DT*0.15f + (float)DP*0.6f;
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("| {0,-20} | {1,-40} | {2,-15} | {3,-15} | {4,-15} | {5,-15} |",a.Id,a.Nombre,DQ,DT,DP,NF);
                                        }
                                    }
                                }
                                Console.WriteLine("");
                                Console.WriteLine("Presione enter para terminar de ver el informe");
                                Console.ReadKey();
                                Console.ResetColor();
                                break;
                            case 3:
                                Bandera1 = false;
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Opcion no valida, presione enter para continuar y digite una opcion valida");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Opcion no valida, presione enter para continuar y digite una opcion valida");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    
                }
        
    }
    public static void ANotas(List<Notas> lstNotas){
        bool Bandera2 = true; 
        int seleccion = 0;
        Notas notas = new Notas();
        while (Bandera2)
                {   
                    Console.Clear();
                        Console.WriteLine("Ingrese el codigo del estudiante: ");
                        string Id = Console.ReadLine();
                        Console.Clear();
                        bool encontrado = false;
                        foreach (Notas a in lstNotas){
                            if (a.Id == Id){
                                encontrado = true;
                                notas=a;
                            }
                        }

                    
                    try
                    {   
                        
                        
                        if (encontrado){
                            Console.Clear();
                            Console.WriteLine("   UIS - Universidad Industrial de Santander");
                            Console.WriteLine("        Sistema de registro de notas");
                            Console.WriteLine("                 Menu de Notas");
                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine("| Bienvenido, seleccione lo que desea hacer: |");
                            Console.WriteLine("| 1. Agregar nota quiz                       |");
                            Console.WriteLine("| 2. Agregar nota trabajo                    |");
                            Console.WriteLine("| 3. Agregar nota examen                     |");
                            Console.WriteLine("| 4. Salir                                   |");
                            Console.WriteLine("----------------------------------------------");
                            seleccion = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (seleccion)
                        {
                            case 1:
                                if (notas.Quizzes[0] == -1.0f){
                                    Console.WriteLine("Ingrese la nota del quiz #1");
                                    float Nota = 0.0f;
                                    Nota=ValidarNota(Nota);
                                    notas.Quizzes[0] = Nota;
                                    Bandera2 = false;
                                }
                                else if (notas.Quizzes[1] == -1.0f){
                                    Console.WriteLine("Ingrese la nota del quiz #2");
                                    float Nota = 0.0f;
                                    Nota=ValidarNota(Nota);
                                    notas.Quizzes[1] = Nota;
                                    Bandera2 = false;
                                }
                                else if (notas.Quizzes[2] == -1.0f){
                                    Console.WriteLine("Ingrese la nota del quiz #3");
                                    float Nota = 0.0f;
                                    Nota=ValidarNota(Nota);
                                    notas.Quizzes[2] = Nota;
                                    Bandera2 = false;
                                }
                                else if (notas.Quizzes[3] == -1.0f){
                                    Console.WriteLine("Ingrese la nota del quiz #4");
                                    float Nota = 0.0f;
                                    Nota=ValidarNota(Nota);
                                    notas.Quizzes[3] = Nota;
                                    Bandera2 = false;
                                }
                                else{
                                    Console.WriteLine("Todos los quizzes de este estudiante ya fueron registrados, presione enter para continuar");
                                    Console.ReadKey();
                                    Bandera2 = false;
                                }
                                break;
                            case 2:
                                if (notas.Trabajos[0] == -1.0f){
                                    Console.WriteLine("Ingrese la nota del trabajo #1");
                                    float Nota = 0.0f;
                                    Nota=ValidarNota(Nota);
                                    notas.Trabajos[0] = Nota;
                                    Bandera2 = false;
                                }
                                else if (notas.Trabajos[1] == -1.0f){
                                    Console.WriteLine("Ingrese la nota del trabajo #2");
                                    float Nota = 0.0f;
                                    Nota=ValidarNota(Nota);
                                    notas.Trabajos[1] = Nota;
                                    Bandera2 = false;
                                }
                                else{
                                    Console.WriteLine("Todos los trabajos de este estudiante ya fueron registrados, presione enter para continuar");
                                    Console.ReadKey();
                                    Bandera2 = false;
                                }
                                break;
                            case 3:
                                if (notas.Parciales[0] == -1.0f){
                                    Console.WriteLine("Ingrese la nota del parcial #1");
                                    float Nota = 0.0f;
                                    Nota=ValidarNota(Nota);
                                    notas.Parciales[0] = Nota;
                                    Bandera2 = false;
                                }
                                else if (notas.Parciales[1] == -1.0f){
                                    Console.WriteLine("Ingrese la nota del parcial #2");
                                    float Nota = 0.0f;
                                    Nota=ValidarNota(Nota);
                                    notas.Parciales[1] = Nota;
                                    Bandera2 = false;
                                }
                                else if (notas.Parciales[2] == -1.0f){
                                    Console.WriteLine("Ingrese la nota del parcial #3");
                                    float Nota = 0.0f;
                                    Nota=ValidarNota(Nota);
                                    notas.Parciales[2] = Nota;
                                    Bandera2 = false;
                                }
                                else{
                                    Console.WriteLine("Todos los parciales de este estudiante ya fueron registrados, presione enter para continuar");
                                    Console.ReadKey();
                                    Bandera2 = false;
                                }
                                break;
                            case 4:
                                Bandera2 = false;
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Opcion no valida, presione enter para continuar y digite una opcion valida");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                        }
                        else if (!encontrado){
                            Console.WriteLine("El estudiante no esta creado en la base de datos, presione enter para continuar");
                            Console.ReadKey();
                            Bandera2 = false;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Opcion no valida, presione enter para continuar y digite una opcion valida");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    
                }
    }
    public static float ValidarNota(float Nota){
        bool bandervn=false;
        while (bandervn==false){
            try
        {
            Console.WriteLine("Ingrese la nota en formato #,# desde 0,0 hasta 5,0");
            Nota = float.Parse(Console.ReadLine());
            
            if (Nota >= 0.0 && Nota <= 5.0){
                bandervn = true;
            }
            else{
                Console.WriteLine("Nota no valida, presione enter para continuar y digite una nota valida");
                Console.ReadKey();
                Console.WriteLine("Ingrese una nota valida:");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Nota no valida, presione enter para continuar y digite una nota valida");
            Console.ReadKey();
            Console.WriteLine("Ingrese una nota valida:");
        }
        }
        return Nota;
        
    }
}