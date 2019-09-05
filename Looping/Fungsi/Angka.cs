using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping.Fungsi
{
    public class Angka
    {
        public void Print()
        {
            int k = 1;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    //Console.Write(k++);
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
