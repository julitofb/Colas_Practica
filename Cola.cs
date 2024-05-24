using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_Practica
{
    public class Cola
    {
        private Nodo Primero= new Nodo();
        private Nodo Ultimo = new Nodo();
        public Cola()
        {
            Primero = null;
        }
        public void InsrtarNodo()
        {
            Nodo Nuevo=new Nodo();
            Console.Write("Ingrese un dato a la fila: ");
            Nuevo.Dato=int.Parse(Console.ReadLine());
            if(Primero==null)
            {
                Primero = Nuevo;
                Primero.Siguiente=null;
                Ultimo = Nuevo;

            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo= Nuevo;
            }
            Console.WriteLine("Nodo ingresado");
        }
        public void Desplegar()
        {
            Nodo Actual=new Nodo();
            Actual = Primero;
            if (Actual != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine(" " + Actual.Dato);
                    Actual = Actual.Siguiente;

                }

            }
            else
            {
                Console.WriteLine(" La cola se encuentra vacia");
            }
        }
        public void BuscarNodo()
        {
            Nodo Actual= new Nodo();
            Actual = Primero;
            bool encontrado = false;
            Console.Write("Ingrese el dato que quiere buscar: ");
            int nodoBuscado= int.Parse(Console.ReadLine());
            if(Primero != null)
            {
                while(Actual != null&&encontrado !=true)
                {
                    if (Actual.Dato == nodoBuscado)
                    {
                        Console.WriteLine("Nodo con el dato {0} encontrado ",nodoBuscado);
                        encontrado = true;

                    }
                    Actual = Actual.Siguiente;
                }
                if (!encontrado)
                {
                    Console.WriteLine("Nodo no encontrado");
                }
            }
            else
            {
                Console.WriteLine("La cola se encuentra vacia");
            }
        }

    }
}
