using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping.Fungsi
{
    public class Bintang
    {
        public void Print()
        {            
            for (int i = 1; i <= 10; i++)
            {
                if(i <= 5)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                if (i >= 6)
                {
                    for (int j = 10; j >= i; j--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
