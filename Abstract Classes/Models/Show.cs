using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes.Models
{
    public class Show : Media
    {
        public int Episode { get; set; }
        public int Season { get; set; }
        public string Writers { get; set; }

        List<int> showIds = new List<int>();
        List<string> showTitles = new List<string>();
        List<int> showEpisodes = new List<int>();
        List<int> showSeasons = new List<int>();
        List<string> showWriters = new List<string>();

        public override void Display()
        {
            for (int i = 0; i < showIds.Count; i++)
            {
                Console.WriteLine($"Id: {showIds[i]}");
                Console.WriteLine($"Title: {showTitles[i]}");
                Console.WriteLine($"Episodes: {showEpisodes[i]}");
                Console.WriteLine($"Seasons: {showSeasons[i]}");
                Console.WriteLine($"Writer(s): {showWriters[i]}");
                Console.WriteLine();
            }
        }

        public override void Read()
        {
            StreamReader sr = new StreamReader("shows.csv");
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                int idx = line.IndexOf('"');
                if (idx == -1)
                {
                    string[] movieDetails = line.Split(',');
                    showIds.Add(int.Parse(movieDetails[0]));
                    showTitles.Add(movieDetails[1]);
                    showEpisodes.Add(int.Parse(movieDetails[2]));
                    showSeasons.Add(int.Parse(movieDetails[3]));
                    showWriters.Add(movieDetails[4].Replace("|", ", "));
                }

            }
            sr.Close();
        }
    }
}
