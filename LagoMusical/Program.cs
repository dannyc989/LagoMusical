using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LagoMusical
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("--------Presione CTRT+C para Terminar--------------");
                Console.Write("Ingrese un sonido:");
                string sonido = Console.ReadLine();
                
                LagoMusicalBLL.clsCancion objCancion = new LagoMusicalBLL.clsCancion();
                string restoCancion = objCancion.getRestoCancion(sonido);
                Console.Out.WriteLine("El Resto de la canción es--> {0}",restoCancion);
                Console.WriteLine("");
                Console.WriteLine("");

            }
            

        }
    }
}
