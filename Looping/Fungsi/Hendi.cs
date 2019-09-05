using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping.Fungsi
{
    public class Hendi
    {
        public void Print()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                    Console.WriteLine("Hendi");
                else if (i % 3 == 0)
                    Console.WriteLine("Hen");
                else if (i % 5 == 0)
                    Console.WriteLine("Di");
                else
                    Console.WriteLine(i.ToString());
            }
        }
    }
}
