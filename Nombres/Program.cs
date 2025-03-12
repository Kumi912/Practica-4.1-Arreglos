using System;
public class Nombre
{
    public string [] nombres {get; set;}
    public string buscar {get; set;}

    public Nombre(string [] Nombres, string Buscar) //Constructor
    {
        nombres = Nombres;
        buscar = Buscar;
    }

    public void BuscarNombre() //Método para buscar el nombre
    {
        for (int i = 0; i < 5; i++) //Bucle que recorre el arreglo de nombres
        {
            if (nombres[i] == buscar) //Condición para saber si el nombre se encuentra en el arreglo
            {
                Console.WriteLine("El nombre " + buscar + " se encuentra en la posición " + (i + 1));
            }
        }
    }

    public void IngresarNombres() //Método para ingresar los nombres
    {
        for (int i = 0; i < 5; i++) //Bucle que recorre el arreglo de nombres
        {
            nombres[i] = Console.ReadLine(); //Guardamos los nombres en el arreglo
        }
    }
}

class Program
{
    static void Main()
    {
        string [] nombres = new string [5]; //Creamos un arreglo de 5 nombres

        Console.WriteLine("Escriba el nombre que quiere buscar"); //Pedimos al usuario que ingrese el nombre a buscar
        string buscar = Console.ReadLine(); //Guardamos el nombre a buscar en la variable buscar

        Nombre nombre = new Nombre(nombres, buscar); //Creamos un objeto de la clase Nombre
        
        Console.WriteLine("Ingrese 5 nombres"); //Pedimos al usuario que ingrese los nombres
        nombre.IngresarNombres(); //Llamamos al método IngresarNombres
        
        nombre.BuscarNombre(); //Llamamos al método BuscarNombre
    }
}