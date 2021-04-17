using System;
using System.Collections.Generic;

namespace ProyectoPoo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Transporte> tranportes = new List<Transporte>
            {
                new Avion(100,"Avion1"),
                new Avion(30,"Avion2"),
                new Avion(10,"Avion3"),
                new Avion(60,"Avion4"),
                new Avion(90,"Avion5"),
                new Automovil(4,"Automovil1"),
                new Automovil(2,"Automovil2"),
                new Automovil(5,"Automovil3"),
                new Automovil(3,"Automovil4"),
                new Automovil(6,"Automovil5")
            };

            foreach (var item in tranportes)
            {
                Console.WriteLine(item.Pasajeros() );
            }
            Console.ReadLine();
        }
    }
}
