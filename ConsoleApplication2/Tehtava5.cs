using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra9
{
    public class ArrayCalcs
    {
        public static void Sum(double[] values)
        {
            double sum=0;
            foreach (var item in values)
            {
                sum += item;
            }
            Console.WriteLine("sum = " +sum);
        }
        public static void Average(double[] values)
        {
            double sum = 0;
            foreach (var item in values)
            {
                sum += item;
            }
            sum=sum / values.Length;
            Console.WriteLine("Ave = " + sum);
        }
        public static void Min(double[] values)
        {
            Console.WriteLine("Min = " + values.Min());
        }
        public static void Max(double[] values)
        {
            Console.WriteLine("Max = " + values.Max());
        }
    }

    public class Tehtava5
    {
        public static void TestTehtava5()
        {
            try
            {
                double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
                ArrayCalcs.Sum(array);
                ArrayCalcs.Average(array);
                ArrayCalcs.Min(array);
                ArrayCalcs.Max(array);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
