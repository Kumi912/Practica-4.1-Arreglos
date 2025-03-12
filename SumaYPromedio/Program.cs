using System;
class Numero
{
    public int [] numeros { get; set; }

    public Numero(int [] Numeros) //Constructor
    {
        numeros = Numeros;
    }

    public int SumaTotal() //Método para sumar los números
    {
        int suma = 0; //Variable para guardar la suma de los números

        for (int i = 0; i < 10; i++) //Bucle para recorrer el arreglo
        {
            suma += numeros[i]; //Sumamos los números
        }

        return suma; //Retornamos la suma
    }

    public double PromedioNumeros() //Método para calcular el promedio de los números
    {
        return (double) SumaTotal() / 10; //Retornamos el promedio llamndo al metodo SumaTotal y dividiendo entre 10
    }
}

class Program
{
    static void Main()
    {
        int [] numeros = new int [10]; //Creamos un arreglo para guardar 10 números

        Console.WriteLine("Ingrese 10 números"); //Pedimos al usuario que ingrese los números

        for (int i = 0; i < 10; i++) //Bucle para ingresar los números
        {
            numeros[i] = int.Parse(Console.ReadLine()); //Guardamos los números en el arreglo
        }

        Numero numero = new Numero(numeros); //Creamos un objeto de la clase Numero

        Console.WriteLine("La suma total de los números es " + numero.SumaTotal()); //Mostramos la suma total de los números llmaando al método SumaTotal

        Console.WriteLine("El promedio de los números es " + numero.PromedioNumeros()); //Mostramos el promedio de los números llamando al método PromedioNumeros
    }
}