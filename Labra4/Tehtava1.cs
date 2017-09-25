using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4
{
    class Tehtava1
    {
        public static bool OnkoLuku(string syote)
        {
            bool tulos;
            decimal numero;
            //tulos = syote.All(char.IsDigit);
            tulos = decimal.TryParse(syote, out numero);
            return tulos;
        }
        public static bool OnkoPvm(string syote)
        {
            bool tulos;
            DateTime pvm;
            string[] format = new string[] { "d.M.yyyy", "d.M.yy"};
            tulos = DateTime.TryParseExact(syote,format,System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeLocal,out pvm);
            return tulos;
        }
    }    

    public static class TestiPeti
        {
          public static void TestOnkoLuku() {
            string test;
            Console.WriteLine("Näiden tulisi antaa False:");
            test = "sana";
            Console.WriteLine(Tehtava1.OnkoLuku(test));
            test = "";
            Console.WriteLine(Tehtava1.OnkoLuku(test));
            test = "123.3";
            Console.WriteLine(Tehtava1.OnkoLuku(test));
            test = "17a";
            Console.WriteLine(Tehtava1.OnkoLuku(test));
            Console.WriteLine("Näiden tulisi antaa True");
            test = "15";
            Console.WriteLine(Tehtava1.OnkoLuku(test));
            test = "0,15";
            Console.WriteLine(Tehtava1.OnkoLuku(test));
            test = "-1500";
            Console.WriteLine(Tehtava1.OnkoLuku(test));
            test = "+1800,15";
            Console.WriteLine(Tehtava1.OnkoLuku(test));
        }
        public static void TestOnkoPvm()
        {
            string test;
            test = "08.11.1993";
            Console.WriteLine(test + " = " + Tehtava1.OnkoPvm(test));
            test = "10.11.1993";
            Console.WriteLine(test + " = " + Tehtava1.OnkoPvm(test));
            test = "10.11.93";
            Console.WriteLine(test + " = " + Tehtava1.OnkoPvm(test));
            test = "8.11.93";
            Console.WriteLine(test + " = " + Tehtava1.OnkoPvm(test));
            test = "40.12.1993";
            Console.WriteLine(test + " = " + Tehtava1.OnkoPvm(test));
            test = "08/11/1993";
            Console.WriteLine(test + " = " + Tehtava1.OnkoPvm(test));
            test = "10-11-1993";
            Console.WriteLine(test + " = " + Tehtava1.OnkoPvm(test));
            test = "1993-10-10";
            Console.WriteLine(test + " = " + Tehtava1.OnkoPvm(test));
            test = "1993,10,10";
            Console.WriteLine(test + " = " + Tehtava1.OnkoPvm(test));
        }
    }
}

    
