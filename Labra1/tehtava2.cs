using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava2
    {
        public static void t2()
        {
            int point;
            int maxpoint = 13;   //suurimmat mahdolliset pisteet, määrittää taulukon koon
            int grade0 = 2; //arvosanoihin vaadittavat pisteet
            int grade1 = 4;
            int grade2 = 6;
            int grade3 = 8;
            int grade4 = 10;
            int grade5 = 13;
            int[] grades = new int[maxpoint];

            //taulukon luonti annettuja arvoja käyttäen
            for (int i = 0; i < grade0; i++)
            {
                    grades[i] = 0;
            }
            for (int i = grade0; i < grade1; i++)
            {
                grades[i] = 1;
            }
            for (int i = grade1; i < grade2; i++)
            {
                grades[i] = 2;
            }
            for (int i = grade2; i < grade3; i++)
            {
                grades[i] = 3;
            }
            for (int i = grade3; i < grade4; i++)
            {
                grades[i] = 4;
            }
            for (int i = grade4; i < grade5; i++)
            {
                grades[i] = 5;
            }

            Console.Write("Input achieved points ");
            point = int.Parse(Console.ReadLine());
            Console.Write(("Grade is ")+grades[point]);
        }
    }
}
