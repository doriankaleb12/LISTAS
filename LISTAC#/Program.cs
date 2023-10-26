using System;
using System.Collections.Generic;

class Nodo
{
    public int dato;
    public Nodo siguiente;
}

class Program
{
    static void agregarNodo(ref Nodo cabeza, int valor)
    {
        Nodo nuevoNodo = new Nodo();
        nuevoNodo.dato = valor;
        nuevoNodo.siguiente = null;

        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.siguiente != null)
            {
                actual = actual.siguiente;
            }
            actual.siguiente = nuevoNodo;
        }
    }

    static void imprimirLista(Nodo cabeza)
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.dato + " ");
            actual = actual.siguiente;
        }
        Console.WriteLine();
    }

    static void borrarLista(Nodo cabeza)
    {
        while (cabeza != null)
        {
            Nodo siguiente = cabeza.siguiente;
            cabeza = null;
            cabeza = siguiente;
        }
    }

    static void Main()
    {
        Nodo cabeza = null;
        int tamanolista;
        Console.WriteLine("Ingrese la cantidad de elementos que desea agregar a la lista:");
        tamanolista = Convert.ToInt32(Console.ReadLine());

        if (tamanolista <= 0)
        {
            Console.WriteLine("Cantidad de elementos no válida");
            return;
        }

        for (int i = 0; i < tamanolista; i++)
        {
            int valor;
            Console.WriteLine("Ingrese dato " + (i + 1) + ": ");
            valor = Convert.ToInt32(Console.ReadLine());
            agregarNodo(ref cabeza, valor);
        }

        Console.WriteLine("Imprimiendo Lista de números");


    }
}