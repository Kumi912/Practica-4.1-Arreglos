using System;
public class Numero
{
    public int [] numeros { get; set; }

    public Numero(int [] Numeros) //Constructor
    {
        numeros = Numeros;
    }

    public void NumerosIngresado() //Método para mostrar los números ingresados
    {
        for (int i = 0; i < 5; i++) //Bucle para recorre el arreglo de números
        {
            Console.WriteLine(numeros[i]); //Mostramos los números ingresados
        }
    }

    public void NumerosInvertidos() //Método para mostrar los números invertidos
    {
        for (int i = 4; i >= 0; i--) //Bucle para recorre el arreglo de números
        {
            Console.WriteLine(numeros[i]); //Mostramos los números invertidos
        }
    }
}

class Program
{
    static void Main()
    {
        int [] numeros = new int [5]; //Creamos un arreglo de 5 números

        Console.WriteLine("Ingrese 5 números"); //Pedimos al usuario que ingrese 5 números

        for (int i = 0; i < 5; i++) //Bucle para recorre el arreglo de números
        {
            Console.WriteLine("Ingrese el número " + (i + 1));
            numeros[i] = int.Parse(Console.ReadLine()); //Guardamos el número ingresado en el arreglo
        }

        Numero numero = new Numero(numeros); //Creamos un objeto de la clase Numero

        Console.WriteLine("Los números ingresados son ");
        numero.NumerosIngresado(); //Llamamos al método para mostrar los números ingresados
        Console.WriteLine("Los números invertidos son ");
        numero.NumerosInvertidos(); //Llamamos al método para mostrar los números invertidos
    }
}