using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping.Fungsi
{
    public class Hitung
    {
        public void Print()
        {
            int total = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i);
                total += i;
            }
            Console.WriteLine();
            Console.Write(total);
        }
    }
}
