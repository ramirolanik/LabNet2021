using System;

public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Ingrese dividendo");
            int dividendo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese divisor");
            int divisor = int.Parse(Console.ReadLine());


            int total = dividendo / divisor;

            Console.WriteLine(total);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Solo Chuck Norris divide por cero!:{0}", ex);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("“Seguro Ingreso una letra o no ingreso nada!:{0}", ex);

        }

    }
}
