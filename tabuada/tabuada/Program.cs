using System;

namespace tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (var y = 1; y <= 10; y++)
            {

                for (var x = 1; x <= 10; x++)
                {
                    Console.WriteLine(y + " x " + x + " = " + (1 * x ) );
                 }
               
             }
            Console.Write("---------------------------------------");
        }
    }
}
