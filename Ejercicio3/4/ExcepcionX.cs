using System;
using System.Collections.Generic;
using System.Text;

namespace Excepcion2
{
    public class ExcepcionX : Exception
    {
        public ExcepcionX(int a, int b)
        {
            if (b > a)
            {
                Console.WriteLine("b no puede ser mayor que a");
            }
        }
    }
}




