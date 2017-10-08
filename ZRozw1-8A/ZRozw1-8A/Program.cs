using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZRozw1_8A
{
    class Program
    {
        static int ObliczSume(int a, int b)
        {
            return a + b;
        }
        
        static void Main(string[] args)
        {
            int a = 5, b = -7;
            Console.WriteLine(ObliczSume(a, b));
            Console.ReadKey();
        }
    }
}
