using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping.Fungsi
{
    public class Fibonaci
    {
        public void Print()
        {
            int a = 0;
            int b = 1;
            Console.Write(a);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
                int temp = a;
                a = b;
                b = temp + b;
                Console.Write(a);
            }
        }
    }
}
