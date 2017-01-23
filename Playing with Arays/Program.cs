using System;
using System.Collections.Generic;
using System.Linq;

namespace Playing_with_Arays
{
    class Program
    {
        static void Main()
        {


            Console.WriteLine("Suma primelor X numere, unde X = ");
            int numar = Convert.ToInt32(Console.ReadLine());
            var createNumberArray =  Numarator(numar);
            
            int total = Sum(createNumberArray);
            Console.WriteLine(total);
            Console.ReadKey();
        }


        static int Sum(params int[] ints)
        {
            int sum = ints.Sum();
            return sum;
        }

        static int[] Numarator( int numar)
        {

            List<int> lista = new List<int>();
            for (int i = 0; i <= numar; i++)
            {
                lista.Add(i);
            }
            return lista.ToArray();
        }
    }
}

