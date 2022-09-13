using System;
using System.Collections.Generic;

namespace Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número:");

            int k = int.Parse(Console.ReadLine());
            int h;
            int i;
            int j;            
            
            List<int> primos = new List<int>();

            for (h = 1; h <= k; h++)
            {
                List<int> num = new List<int>();
                for (i = 1; i <= h; i++)
                {
                    j = h % i;
                    if (j == 0 && i != 1 && i != h)
                    {
                        num.Add(h);                        
                    }                                        
                }
                if (num.Count == 0)
                {
                    primos.Add(h);
                }
            }
            Console.WriteLine($"Los números primos entre 1 y {k}");            
            foreach (int l in primos)
            {                
                Console.WriteLine(l);
            }
            
        }
    }
    
}
