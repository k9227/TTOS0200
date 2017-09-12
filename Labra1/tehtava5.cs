using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava5
    {
        public static void t5()
        {
            int time;
            int minute;
            int hour;
            int second;
            Console.Write("Give time as seconds to convert ");
            time = int.Parse(Console.ReadLine());
            hour = time / 3600;
            minute = (time % 3600) / 60;
            second = time % 60;
            
            Console.WriteLine("Time you gave can be expressed "+hour+ " hr " +minute+" min " +second+ " sec");
        }
    }
}
