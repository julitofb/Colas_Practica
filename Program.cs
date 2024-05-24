using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cola cola = new Cola();
            cola.InsrtarNodo();
            cola.InsrtarNodo();
            cola.InsrtarNodo();
            Console.WriteLine("Cola ingresada");
            cola.Desplegar();
            cola.BuscarNodo();
            Console.ReadKey();

        }
    }
}
