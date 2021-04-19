using System;

namespace Excepcion2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Ingrese dividendo");
                int dividendo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese divisor");
                int divisor = int.Parse(Console.ReadLine());

                Dividir obj = new Dividir();
                Console.WriteLine(obj.Division(dividendo,divisor));



            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Solo Chuck Norris divide por cero!:{0}", ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Seguro Ingreso una letra o no ingreso nada!:{0}", ex);
            }
        }
    }
}