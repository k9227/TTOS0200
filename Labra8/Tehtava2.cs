using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra8
{
    class Tehtava2
    {
        public static void TestTehtava2()
        {
            try
            {                 
                Dictionary<string, int> Names = new Dictionary<string,int>();      
                string filu = @"D:\temp\nimet.txt";
                int allNames = 0;
                foreach(string line in File.ReadLines(filu))
                {
                    if (Names.ContainsKey(line))
                    {
                        Names[line] += 1;
                    }
                    else
                    {
                        Names.Add(line,1);
                    }
                }
                foreach(KeyValuePair<string,int> kvp in Names)
                {
                    Console.WriteLine("{0} {1}", kvp.Key, kvp.Value);
                    allNames += kvp.Value;
                }
                int uniqueNames= Names.Count;
                Console.WriteLine("Löytyi "+allNames+" nimeä joista "+uniqueNames+" on uniikkeja");
                //Esittäminen aakkostettuna
                var namesList = Names.Keys.ToList();
                namesList.Sort();
                foreach(var key in namesList)
                {
                    Console.WriteLine("{0}: {1}", key, Names[key]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
