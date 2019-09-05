using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping.Fungsi
{
    public class Ganjil
    {
        public void Print()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i);
                    Console.WriteLine();
                }
            }
        }
    }
}
