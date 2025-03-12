using System;
public class OrdenarBurbuja
{
    public int [] numeros { get; set; }

    public OrdenarBurbuja(int [] Numeros) //Constructor
    {
        numeros = Numeros;
    }

    public void OrdenBurbuja(int[] orden) //Método de burbuja para ordenar los números
    {
        int n = orden.Length;
        for (int i = 0; i < n - 1; i++) //Bucle para recorrer el arreglo
        {
            for (int j = 0; j < n - i - 1; j++) //Bucle para comparar y ordenar los números
            {
                if (orden[j] > orden[j + 1]) //Si el número actual es mayor al siguiente, se intercambian
                {
                    int igualar = orden[j];
                    orden[j] = orden[j + 1];
                    orden[j + 1] = igualar;
                }
            }
        }
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese cuantos numeros desea ingresar"); //Pedimos al usuario que ingrese la cantidad de números
        int cantidad = int.Parse(Console.ReadLine()); //Guardamos la cantidad de números que el usuario ingresó
        int [] numeros = new int[cantidad]; //Creamos un arreglo con la cantidad de números que el usuario ingresó

        for (int i = 0; i < cantidad; i++) //Bucle para ingresar los números
        {
            Console.WriteLine("Ingrese el numero " + (i + 1));
            numeros[i] = int.Parse(Console.ReadLine()); //Guardamos los números en el arreglo
        }

        OrdenarBurbuja orden = new OrdenarBurbuja(numeros); //Creamos un objeto de la clase OrdenarBurbuja

        orden.OrdenBurbuja(numeros); //Llamamos al método OrdenBurbuja para ordenar los números

        Console.WriteLine("Los números en orden son"); //Mostramos los números ordenados
        
        foreach (int numero in numeros) //Bucle para mostrar los números ordenados
        {
            Console.WriteLine(numero); //Mostramos los números ordenados
        }
    }
}