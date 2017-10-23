using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra7
{
    class CD
    {        
        public string Artist { get; set; }
        public string Album { get; set; }
        public List<string> tracklist = new List<string>();

        public CD(string artist,string album)
        {
            Album = album;
            Artist = artist;
        }
        public override string ToString()
        {
            string retval = string.Format("Artist: {0}\nAlbum: {1}\nTracklist:\n",Artist,Album);
            foreach (string item in tracklist)
            {
                retval +="- "+ item.ToString() + "\n";
            }
            return retval;
        }
    }
    class Tehtava2
    {
        public static void TestCD()
        {
            CD platta = new CD("Wu-Tang Clan", "Enter The Wu-Tang-36 Chambers");
            platta.tracklist.Add("Bring Da Ruckus");
            platta.tracklist.Add("Shame on a Nigga");
            platta.tracklist.Add("Clan in da Front");
            platta.tracklist.Add("Wu-Tang: 7th Chamber");
            platta.tracklist.Add("Can It Be All So Simple");
            platta.tracklist.Add("Da Mystery of Chessboxin");
            platta.tracklist.Add("Wu-Tang Clan Ain't Nuthing ta F' Wit");
            platta.tracklist.Add("C.R.E.A.M.");
            platta.tracklist.Add("Method Man");
            platta.tracklist.Add("Protect Ya Neck");
            platta.tracklist.Add("Tearz");
            platta.tracklist.Add("Wu-Tang: 7th Chamber—Part II");
            platta.tracklist.Add("Method Man - Skunk Mix");
            platta.tracklist.Add("Conclusion");

            Console.WriteLine(platta.ToString());
        }
    }
}
