﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping.Fungsi
{
    public class Piramid
    {
        public void Print()
        {
            int i, j, spc, k;
            spc = 6 + 4 - 1;
            for (i = 1; i <= 6; i++)
            {
                for (k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (j=1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                spc--;
            }
        }
    }
}
