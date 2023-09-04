using System.Runtime.InteropServices;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        
        //Comentario en una linea
        /*Comentario
        en
        bloque*/

        int edad;
        Console.WriteLine("Ingrese su edad:");
        try{
            edad=int.Parse(Console.ReadLine() ?? "0");
            edad=Convert.ToInt16(Console.ReadLine() ?? "0");
        }catch(Exception ex){
            Console.WriteLine("Errorrr {0} -- {1}",ex.Message.ToString(),"Segundo Mensaje");
        }
        //condicioneles
        if(10>=18){
                    Console.WriteLine("Es mayor de edad");
                }else{
                    Console.WriteLine("No es mayor de edad");
                }
                Console.ReadKey();
        //switch
        int valor=1;
        switch(valor){
            case 1:
                Console.WriteLine("Valor 1");
                break;
            case 2:
                Console.WriteLine("Valor 2");
                break;
            case 3:
                Console.WriteLine("Valor 3");
                break;
            default:
                Console.WriteLine("Valor no valido");
                break;
        }
        // Operadores logicos
        bool valor1=true;
        bool valor2=false;
        Console.WriteLine(valor1 && valor2);
        Console.WriteLine(valor1 || valor2);
        Console.WriteLine(!valor1);
        Console.ReadKey();
        // Operadores matematicos
        int num1=10;
        int num2=20;
        Console.WriteLine(num1+num2);
        Console.WriteLine(num1-num2);
        Console.WriteLine(num1*num2);
        Console.WriteLine(num1/num2);
        Console.WriteLine(num1%num2);
        Console.ReadKey();
        //Operadores relacionales
        int num3=10;
        int num4=20;
        Console.WriteLine(num3==num4);
        Console.WriteLine(num3!=num4);
        Console.WriteLine(num3>num4);
        //Uso de Format
        var a = 12.3;
        double b = 12.3;
        Console.WriteLine($"El valor de a es = {a}");
        Console.WriteLine($"El valor de b es = {b}");
        //Ejercicio
        double d= 3D;
        d = 4d;
        d = 3.934_001;
        Console.WriteLine($"{d}");
        float f = 3_000.5F;
        Console.WriteLine($"{f}");
        decimal myMoney = 3_000.5m;
        myMoney = 400.75M;
        Console.WriteLine($"{myMoney}");
        Console.WriteLine(myMoney.ToString("C2"));
        //Operador tenario
        bool check = true;
        Console.WriteLine(check ? "Activo" : "Inactivo");
        Console.WriteLine(false ? "Activo" : "Inactivo");
        //Ciclos repetitivos for
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        for (int i = 10; i > 0; i--)
        {
            Console.WriteLine(i);
        }
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine($"{i},{j}");
            }
        }
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    Console.WriteLine($"{i},{j},{k}");
                }
            }
        }
        //Ciclos repetitivos while
        int contador = 0;
        while (contador < 10)
        {
            Console.WriteLine(contador);
            contador++;
        }
        //Ciclos repetitivos do while
        int contador2 = 0;
        do
        {
            Console.WriteLine(contador2);
            contador2++;
        } while (contador2 < 10);
        //Ciclos repetitivos foreach
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
        //Ciclos iterativos foreach
        string[] nombres = { "Juan", "Pedro", "Maria", "Jose" };
        foreach (string nombre in nombres)
    }
}