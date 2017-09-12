using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava17
    {
        static public void t17()
        {
            int[] table1 = { 10, 20, 30, 40, 50 };
            int[] table2 = { 5, 15, 25, 35, 45 };
            int[] combined = table1.Concat(table2).ToArray();

            Array.Sort(combined);

            for (int i = 0; i < combined.Length; i++)
            {            
            Console.WriteLine(""+combined[i]);
            }            
        }
    }
}
