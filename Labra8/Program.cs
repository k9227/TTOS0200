using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra8
{
    class Program
    {
        static void Main(string[] args)
        {
            //KÄYTTÄKÄÄ AINA TRY-CATCHIA
            try
            {
                string nimi;
                string filepath =Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filu = filepath + @"\testi.txt";
                //kirjoitetaa käyttäjän antamat rivit tiedosotoon
                //luodaan StreamWriter tyyppinen olio johon kirjoitetaan
                StreamWriter sw = new StreamWriter(filu);
                do
                {
                    Console.Write("Anna nimi (Enter lopettaa): ");
                    nimi = Console.ReadLine();
                    if (nimi.Length > 0)
                    {
                        sw.WriteLine(nimi);
                    }
                } while (nimi.Length != 0);
                sw.Close();
                //avataan tiedosto uudestaan ja luetaan sen sisältö joka näytetään konsolissa
                if (File.Exists(filu))
                { 
                    string teksti = File.ReadAllText(filu);
                    Console.WriteLine(teksti);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);               
            }
        }
    }
}
