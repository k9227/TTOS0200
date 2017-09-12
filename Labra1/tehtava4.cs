using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava4
    {
        public static void t4()
        {
            int age;
            Console.Write("Give your age ");
            age = int.Parse(Console.ReadLine());
            if (age<18)
            {
                Console.Write("Alaikäinen");
            }
            if(age>=18 & age < 66)
            {
                Console.Write("Aikuinen");
            }
            if (age > 65)
            {
                Console.Write("Seniori");
            }
        }
    }
}
