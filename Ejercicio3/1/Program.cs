using System;

namespace Excepciones
{
    class Program
    {    
       static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero");
            int a = int.Parse(Console.ReadLine());
            int b = 0;

            try
            {
                int total = a / b;

                Console.WriteLine(total);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Ha ocurrido un error:{0}", ex);
            }

            finally

            { Console.WriteLine("La operacion ha finalizado"); }
        }
    }
}
